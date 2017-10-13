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
namespace WpfApp1.crawler
{
    /// <summary>
    /// info_leader.xaml 的交互逻辑
    /// </summary>
    public partial class info_leader : Page
    {
        public info_leader()
        {
            InitializeComponent();
        }

        private void info_add(object sender, RoutedEventArgs e)
        {
            cinfo ia = new cinfo();
            this.frmInfo.Navigate(ia);
        }

        private void info_list(object sender, RoutedEventArgs e)
        {
            info_list il = new info_list();
            this.frmInfo.Navigate(il);
        }
    }
}
