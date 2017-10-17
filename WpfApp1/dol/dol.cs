using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace WpfApp1.dol
{
    class dol
    {
        private string host;
        private string port;
        private string user;
        private string passwd;
        //private string charset ="utf8";
        private MySqlConnection myCon;
        public dol(string db_path)
        {
            get_config(db_path);
            myCon = this.db_connect();
        }
        public dol()
        {
            this.host = ConfigurationManager.AppSettings["server"];
            this.user = ConfigurationManager.AppSettings["uid"];
            this.passwd = ConfigurationManager.AppSettings["pwd"];
            myCon = this.db_connect();
        }
        private void get_config() {
            /*动态获取数据库连接信息*/
            //if (File.Exists(@"db_config.txt"))
            //{
            //    StreamReader sr = new StreamReader(@"db_config.txt", Encoding.Default);
            //    this.host = sr.ReadLine();
            //    this.port = sr.ReadLine();
            //    this.user = sr.ReadLine();
            //    this.passwd = sr.ReadLine();
            //}
            //else {
                //bool isFirstRun = bool.Parse(ConfigurationManager.AppSettings["first_run"]);//此处出现异常，先注释 以后解决
                //if (isFirstRun) {
            this.host = ConfigurationManager.AppSettings["server"];
            this.user = ConfigurationManager.AppSettings["uid"];
            this.passwd = ConfigurationManager.AppSettings["pwd"];
                //}
            //}
        }

        private void get_config(string db_path) {
            StreamReader sr = new StreamReader(db_path, Encoding.Default);
            this.host = sr.ReadLine();
            this.port = sr.ReadLine();
            this.user = sr.ReadLine();
            this.passwd = sr.ReadLine();
        }

        private MySqlConnection db_connect() {
            /*连接数据库*/
            //string info = "server={0};uid ={1};password={2};database={3};Charset=utf8";           
            string info = "server={0};uid ={1};password={2};Charset=utf8";
            string cinfo = string.Format(info,this.host,this.user,this.passwd);
            try {
                MySqlConnection myCon = new MySqlConnection(cinfo);
                return myCon;
            }
            catch{
                throw new Exception("MySQL配置信息失败！");
            }
        }
        /// <summary>
        /// 执行sql语句,无返回值 update或insert
        /// </summary>
        /// <param name="sql"></param>
        public void getmysqlcom(string sql)
        {
            this.myCon.Open();
            MySqlCommand mysqlcom = new MySqlCommand(sql, this.myCon);
            try
            {
                mysqlcom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                mysqlcom.Dispose();
                myCon.Close();
                myCon.Dispose();
            }
        }

        public MySqlDataReader getmysqlread(string sql)
        {
            MySqlCommand mycom = new MySqlCommand(sql, this.myCon);
            myCon.Open();
            try
            {
                MySqlDataReader reader = mycom.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally {
                myCon.Clone();
            }
        }
    }
}
