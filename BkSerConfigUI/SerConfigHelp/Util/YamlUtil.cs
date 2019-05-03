using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace BkSerConfigUI.SerConfigHelp.Util
{
    public class YamlUtil
    {

        private Dictionary<string,Node> rootNode = new Dictionary<string, Node>();
        private string ymlPath;

        public YamlUtil(string ymlPath)
        {
            if (!string.IsNullOrWhiteSpace(ymlPath) && File.Exists(ymlPath))
                read(File.ReadAllLines(ymlPath));
            this.ymlPath = ymlPath;
        }

        public void read(List<string> lines){ read(lines.ToArray()); }
        
        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="lines">文件行内容</param>
        private void read(string[] lines)
        {
            List<Node> allNode = new List<Node>();
            /// 移除所有注释内容;
            for (int i = 0; i < lines.Length; i++)
                if (lines[i].IndexOf('#') >= 0)
                    lines[i] = lines[i].Substring(0, lines[i].IndexOf('#'));
            // 将行内容转换为节点
            foreach (string line in lines)
            {
                if (line.Trim().Equals("")){ continue; } // 空行不计入节点
                // 判断是否为节点的多行值
                if (line.Trim().IndexOf('-') == 0 && !CurrencyUtil.IsNumber(line.Trim()))
                {
                    allNode[allNode.Count - 1].NodeType = Node.NodeTypes.OBJECT;
                    allNode[allNode.Count - 1].Values.Add(line.Substring(line.IndexOf('-') + 1).Trim());
                    continue;
                }
                Node node = new Node(); // 创建新的节点
                node.SpaceNumber = line.IndexOf(line.Trim().ToArray()[0]);
                node.Name = line.Trim().Substring(0, line.Trim().IndexOf(':')).Trim(); // 获取节点的名称
                /*if (node.Name.Equals("kit"))
                {
                    string s = "";
                }*/
                string value = CurrencyUtil.RemoveFirstAndLastChar(line.Trim().Substring(line.Trim().IndexOf(':') + 1).Trim(), '\'');
                if (value.Trim().IndexOf('"') == 0 && value.LastIndexOf('"') == value.Length - 1)
                    value = CurrencyUtil.RemoveFirstAndLastChar(value, '"');
                if (!string.IsNullOrEmpty(value))
                    node.Values.Add(value);
                // 根据缩进寻找节点父集
                if (allNode.Count > 0 && node.SpaceNumber > 0)
                {
                    // 倒序根据缩进空格数量寻找最近的父级
                    for (int i = allNode.Count - 1; i >= 0; i--)
                    {
                        if (allNode[i].SpaceNumber < node.SpaceNumber)
                        {
                            allNode[i].ChildNodes.Add(node.Name,node) ;
                            node.Level = allNode[i].Level + 1;
                            break;
                        }
                    }
                }
                allNode.Add(node);
            }
            foreach (Node node in allNode)
                if(node.Level == 0 && !rootNode.ContainsKey(node.Name))
                    rootNode.Add(node.Name, node);
            
        }
        
        public bool Edit(string key, string value)
        {
            return Edit(key, new List<string>() { value });
        }

        /// <summary>
        /// 修改属性值,多级获取使用"."分级
        /// 例如：key1.key2.key3
        /// </summary>
        /// <param name="key">需要修改的键</param>
        /// <param name="value">修改后的内容</param>
        /// <param name="nodeList">修改的集合</param>
        /// <returns>修改的结果</returns>
        public bool Edit(string key, List<string> value)
        {
            Node node = FindNodeByKey(key);
            if (node == null) return false;
            node.Values = value;
            return true;
        }

        /// <summary>
        /// 根据键寻找节点多级获取使用"."分级
        /// 例如：key1.key2.key3
        /// </summary>
        /// <param name="key">需要获取的键</param>
        /// <param name="nodeList">节点集合</param>
        /// <returns>该键对应的节点</returns>
        public Node FindNodeByKey(string key)
        {
            return FindNodeByKey(key, "");
        }

        /// <summary>
        /// 根据键寻找节点多级获取使用"."分级
        /// 例如：key1.key2.key3
        /// </summary>
        /// <param name="key">需要获取的键</param>
        /// <param name="nodeList">节点集合</param>
        /// <returns>该键对应的节点</returns>
        public Node FindNodeByKey(string key,string description)
        {
            if (null == rootNode) return null;
            string[] ks = key.Split('.');
            try
            {
                Node nodeL = rootNode[ks[0]];
                for (int i = 1; i < ks.Length; i++)
                    nodeL = nodeL.ChildNodes[ks[i]];
                if (nodeL.Level != ks.Length - 1) return null;
                nodeL.Description = description;
                nodeL.CompleteNodeName = key;
                return nodeL;
            }
            catch (Exception)
            {
                return new Node();
            }
        }

        public string GetValue(string key)
        {
            if (GetValues(key).Count == 0)
                return "";
            return GetValues(key)[0];
        }

        public List<string> GetValues(string key)
        {
            return FindNodeByKey(key).Values;
        }

        private void SaveNode(Node node, StreamWriter stream)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < node.Level; j++) { sb.Append("  "); } // 加入前缀空格
            sb.Append(node.Name); // 添加节点名称
            sb.Append(": "); // 添加节点冒号分隔符
            if (node.Values.Count != 0)
                if (node.NodeType.Equals(Node.NodeTypes.OBJECT))
                {
                    foreach (string value in node.Values)
                    {
                        sb.AppendLine();
                        for (int j = 0; j < node.Level * 2 + 2; j++) { sb.Append(" "); } // 加入前缀空格
                        if (value.IndexOf('-') != 0 || CurrencyUtil.IsNumber(value))
                            sb.Append("- " + value);
                    }
                }
                else if (CurrencyUtil.IsNumber(node.Values[0]) || CurrencyUtil.IsBool(node.Values[0]))
                    sb.Append(node.Values[0]);
                else
                    sb.Append("'" + node.Values[0] + "'");
            stream.WriteLine(sb.ToString());
            foreach (Node zNode in node.ChildNodes.Values)
                SaveNode(zNode, stream);

        }

        /// <summary>
        /// 将数据保存到文件中
        /// </summary>
        /// <param name="path">保存的文件地址</param>
        /// <param name="nodeList">保存的文件内容</param>
        /// <returns>返回保存结果</returns>
        public bool Save()
        {
            if (string.IsNullOrEmpty(ymlPath)) return false;
            StreamWriter stream = File.CreateText(ymlPath); // 加载文件
            foreach (Node node in rootNode.Values)
                SaveNode(node, stream);
            stream.Flush();
            stream.Close();
            return true;
        }
    }

    public class Node
    {
        public string Name { get; set; }

        public string CompleteNodeName { get; set; }

        public int SpaceNumber { get; set; }

        public List<string> Values = new List<string>();
        
        public int Level { get; set; }

        public string Description { get; set; }

        public Dictionary<string,Node> ChildNodes = new Dictionary<string, Node>();

        public NodeTypes NodeType = NodeTypes.ATTRIBUTE;

        public enum NodeTypes{ ATTRIBUTE,OBJECT }
    }

}
