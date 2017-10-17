using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.utils
{
    /// <summary>
    /// string类型的扩展方法
    /// </summary>
    public static class eString
    {
        /// <summary>
        /// 去掉文件名中的.txt
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string dtxt(this string t)
        {
            return t.Replace(".txt", "");
        }
    }

    public static class static_info{
        /// <summary>
        /// 数据库配置文件存储路径
        /// </summary>
        public static string origin_db_path = "./dbs";
        public static string img_path = "./resource/img/";

    }
}
