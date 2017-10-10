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
using WpfApp1.settings;
using WpfApp1.crawler;
namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void db_setting(object sender,RoutedEventArgs e) {
            db_setting ds = new db_setting();
            this.frmMain.Navigate(ds);
        }

        private void crawl_test(object sender, RoutedEventArgs e)
        {
            spider sp = new spider();
            this.frmMain.Navigate(sp);
        }

        private void main_close(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void crawl_info(object sender, RoutedEventArgs e)
        {
            info_leader il = new info_leader();
            this.frmMain.Navigate(il);
        }
    }
}
