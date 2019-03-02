using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BkSerConfigUI.SerConfigHelp.Util
{
    class CurrencyUtil
    {
        /// <summary>
        /// 判断字符串是否为数字
        /// </summary>
        public static bool IsNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;
            string[] number = s.Split(',');
            foreach(string num in number)
            {
                if (!Regex.IsMatch(num, @"^[+-]?\d*[.]?\d*$"))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// string转换long
        /// </summary>
        public static long ChangeLongNumber(string s)
        {
            return IsNumber(s) ? long.Parse(s) : 0;
        }

        /// <summary>
        /// string转换double
        /// </summary>
        public static decimal ChangeDecimalNumber(string s)
        {
            return IsNumber(s) ? decimal.Parse(s) : 0;
        }

        /// <summary>
        /// string转换bool
        /// </summary>
        public static bool ChangeBool(string s)
        {
            return !string.IsNullOrWhiteSpace(s) && s.Equals("true") ? true : false;
        }

        /// <summary>
        /// 检查字符串是否为Bool
        /// </summary>
        public static bool IsBool(string s)
        {
            return s.Equals("true") || s.Equals("false") ? true : false;
        }


        /// <summary> 
        /// 移除字符串中所有指定字符 
        /// </summary> 
        /// <param name="str">需要移除的字符串</param> 
        /// <param name="value">指定字符</param> 
        /// <returns>移除后的字符串</returns> 
        public static string RemoveChar(string str, char value)
        {
            char[] strChar = str.ToArray();
            str = "";
            foreach(char val in strChar)
                if (!val.Equals(value))
                    str = str + val;
            return str;
        }

        /// <summary> 
        /// 移除字符串中所有指定字符 
        /// </summary> 
        /// <param name="str">需要移除的字符串</param> 
        /// <param name="value">指定字符</param> 
        /// <returns>移除后的字符串</returns> 
        public static string RemoveFirstAndLastChar(string str, char value)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 2) return str;
            if (str.Trim().IndexOf(value) == 0 && str.Trim().LastIndexOf(value) == str.Length -1)
                return str.Trim().Substring(str.Length - (str.Length - 1), str.Length - 2);
            return str;
        }
    }
}
