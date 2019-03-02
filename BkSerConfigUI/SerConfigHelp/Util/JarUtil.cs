using BkSerConfigUI.SerConfigTool.Util;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace BkSerConfigUI.SerConfigTool.Util
{
    class JarUtil
    {
        /*public static ZipArchive GetJarFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath)) return null;
            return ZipFile.OpenRead(filePath);
        }

        /// <summary>
        /// 扫描并返回服务器信息
        /// </summary>
        /// <param name="filePath">服务器文件地址</param>
        /// <returns></returns>
        public static string[] ScanningBkServer(string filePath)
        {
            ZipArchive zipArchive = GetJarFile(filePath);
            if (zipArchive == null) return new string[0];
            ZipArchiveEntry serverInfo = zipArchive.GetEntry("mcpmod.info");
            if (serverInfo == null) return new string[0];
            return new StreamReader(serverInfo.Open()).ReadToEnd().Split('\n');
        }

        /// <summary>
        /// 扫描并返回插件信息
        /// </summary>
        /// <param name="filePath"></param>
        public static PluginInfo ScanningPlugin(string filePath)
        {
            ZipArchive zipArchive = GetJarFile(filePath);
            if (zipArchive == null) return null;
            ZipArchiveEntry pluginInfo = ZipFile.OpenRead(filePath).GetEntry("plugin.yml");
            if (pluginInfo == null) return null;
            Stream stream = pluginInfo.Open();
            // stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            List<Node> nodes = YmlUtil.read(reader.ReadToEnd().Split('\n'));
            PluginInfo plugin = new PluginInfo(filePath.Substring(filePath.LastIndexOf('\\')+1));
            plugin.PluFilePath = filePath;
            plugin.PluVersion = YmlUtil.ReadValueOnly("version", nodes);
            
            return plugin;
        }*/
    }
}
