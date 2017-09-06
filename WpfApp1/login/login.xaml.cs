using System;
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

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            string user = this.txt_userName.Text;
            //string passwd = this.txt_Pwd.Password;
            IntPtr p = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this.txt_Pwd.SecurePassword);
            string passwd = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(p);
            MessageBox.Show(user);
            MessageBox.Show(passwd);
            MainWindow mainwindow = new MainWindow();
            this.Close();
            mainwindow.Show();
        }

        private void btn_loginout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
            //Environment.Exit(0);
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
