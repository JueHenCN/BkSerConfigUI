using System;
using System.Collections.Generic;
using BkSerConfigUI.SerConfigHelp.Model;
using System.IO;
using System.Text;

namespace BkSerConfigUI.SerConfigTool.Util
{
    class CsvUtil
    {
        /// <summary>
        /// 读取CSV文件
        /// </summary>
        /// <param name="filePath">文件地址</param>
        /// <returns></returns>
        public static List<Item> OpenCSV(string filePath)
        {
            Encoding encoding = GetType(filePath); //Encoding.ASCII;//
            List<Item> allItem = new List<Item>();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, encoding);

            //记录每次读取的一行记录
            string strLine = "";
            //逐行读取CSV中的数据
            while ((strLine = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(strLine))
                    continue;
                string[] aryLine = strLine.Split(',');
                if (aryLine.Length > 0 && aryLine[0].Trim().IndexOf('#') == 0)
                    continue;
                Item item = new Item(aryLine);
                allItem.Add(item);
            }
            sr.Close();
            fs.Close();
            List<Item> items = new List<Item>();
            bool itemIsRepeat = false;
            foreach (Item item in allItem)
            {
                itemIsRepeat = false;
                foreach (Item itemVal in items)
                {
                    if (item.ItemId.Equals(itemVal.ItemId) && item.ItemMetadata.Equals(itemVal.ItemMetadata))
                        itemIsRepeat = true;
                }
                if (!itemIsRepeat)
                    items.Add(item);
            }
            return items;
        }

        /// 给定文件的路径，读取文件的二进制数据，判断文件的编码类型
        /// <param name="FILE_NAME">文件路径</param>
        /// <returns>文件的编码类型</returns>
        public static Encoding GetType(string FILE_NAME)
        {
            FileStream fs = new FileStream(FILE_NAME, FileMode.Open,
                FileAccess.Read);
            Encoding r = GetType(fs);
            fs.Close();
            return r;
        }

        /// 通过给定的文件流，判断文件的编码类型
        /// <param name="fs">文件流</param>
        /// <returns>文件的编码类型</returns>
        public static Encoding GetType(FileStream fs)
        {
            byte[] Unicode = new byte[] { 0xFF, 0xFE, 0x41 };
            byte[] UnicodeBIG = new byte[] { 0xFE, 0xFF, 0x00 };
            byte[] UTF8 = new byte[] { 0xEF, 0xBB, 0xBF }; //带BOM
            Encoding reVal = Encoding.Default;

            BinaryReader r = new BinaryReader(fs, Encoding.Default);
            int i;
            int.TryParse(fs.Length.ToString(), out i);
            byte[] ss = r.ReadBytes(i);
            if (IsUTF8Bytes(ss) || (ss[0] == 0xEF && ss[1] == 0xBB && ss[2] == 0xBF))
            {
                reVal = Encoding.UTF8;
            }
            else if (ss[0] == 0xFE && ss[1] == 0xFF && ss[2] == 0x00)
            {
                reVal = Encoding.BigEndianUnicode;
            }
            else if (ss[0] == 0xFF && ss[1] == 0xFE && ss[2] == 0x41)
            {
                reVal = Encoding.Unicode;
            }
            r.Close();
            return reVal;
        }

        /// 判断是否是不带 BOM 的 UTF8 格式
        /// <param name="data"></param>
        /// <returns></returns>
        private static bool IsUTF8Bytes(byte[] data)
        {
            int charByteCounter = 1;  //计算当前正分析的字符应还有的字节数
            byte curByte; //当前分析的字节.
            for (int i = 0; i < data.Length; i++)
            {
                curByte = data[i];
                if (charByteCounter == 1)
                {
                    if (curByte >= 0x80)
                    {
                        //判断当前
                        while (((curByte <<= 1) & 0x80) != 0)
                        {
                            charByteCounter++;
                        }
                        //标记位首位若为非0 则至少以2个1开始 如:110XXXXX...........1111110X　
                        if (charByteCounter == 1 || charByteCounter > 6)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    //若是UTF-8 此时第一位必须为1
                    if ((curByte & 0xC0) != 0x80)
                    {
                        return false;
                    }
                    charByteCounter--;
                }
            }
            if (charByteCounter > 1)
            {
                throw new Exception("非预期的byte格式");
            }
            return true;
        }
    }
}
