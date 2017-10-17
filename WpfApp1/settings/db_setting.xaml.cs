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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp1.utils.static_info;
namespace WpfApp1.settings
{
    /// <summary>
    /// db_setting.xaml 的交互逻辑
    /// </summary>
    public partial class db_setting : Page
    {
        public db_setting()
        {
            InitializeComponent();
            this.Background = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(img_path + "back.jpg", UriKind.Relative))
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string host = this.host.Text;
            string conn_name = this.conn_name.Text;
            string port = this.port.Text;
            string user = this.user.Text;
            string passwd = this.passwd.Text;
            string[] info = { host, port, user, passwd };
            try
            {
                System.IO.File.WriteAllLines(string.Format(@"./dbs/{0}_db.txt",conn_name), info);
            }
            finally {
                MessageBox.Show("保存成功");
            }
        }
    }
}
