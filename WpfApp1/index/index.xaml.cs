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
using WpfApp1.crawler;

namespace WpfApp1.index
{
    /// <summary>
    /// index.xaml 的交互逻辑
    /// </summary>
    public partial class index : Page
    {
        public index()
        {
            InitializeComponent();
        }

        private void jump_to_crawler(object sender, RoutedEventArgs e)
        {
            spider sp = new spider();
            this.NavigationService.Navigate(sp);
        }
    }
}
