using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.dol;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApp1.login
{
    /// <summary>
    /// login.xaml 的交互逻辑
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //todo
            //MessageBox.Show("confirm?");
        }
        private void reclosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //todo
        }

        //private void Window_Closed(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Application.Current.Shutdown();//关闭窗体后仍然有进程 重大error
        //    //Environment.Exit(0);
        //}

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            string user = this.txt_userName.Text;
            //string passwd = this.txt_Pwd.Password;
            IntPtr p = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this.txt_Pwd.SecurePassword);
            string passwd = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(p);
            if (String.IsNullOrEmpty(user)) {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (String.IsNullOrEmpty(passwd) | passwd == "123456") {
                MessageBox.Show("密码不能为空，或过于简单");
                return;
            }
            //dol.dol d= new dol.dol("test");
            //MySqlDataReader data= d.getmysqlread("show tables");
            //while (data.Read()) {
            //    MessageBox.Show(data.GetString(0));
            //}
            string user_info = string.Format("{0}\t{1}", user, passwd);
            if (File.Exists(@"../../user.txt"))
            {
                StreamReader sr = new StreamReader(@"../../user.txt", Encoding.Default);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.ToString() == user_info) {
                        //MessageBox.Show("congurations");
                        MainWindow mainwindow = new MainWindow();
                        this.Close();
                        mainwindow.Show();
                        break;
                    }
                    MessageBox.Show(line.ToString()+user_info);
                }
            }
        }

        private void btn_loginout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //Application.Current.Shutdown();#关闭窗体后仍然有进程 重大error
            Environment.Exit(0);
        }


        //private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Do you really want to exit?", "", MessageBoxButton.YesNo);
        //    if (result == MessageBoxResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}
