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
using WpfApp1.utils;
namespace WpfApp1.crawler
{
    /// <summary>
    /// spider.xaml 的交互逻辑
    /// </summary>
    public partial class spider : Page
    {
        public spider()
        {
            InitializeComponent();
        }

        private void do_crawl(object sender, RoutedEventArgs e)
        {
            string lurl = this.url.Text;
            string headers = this.headers.Text;
            string cookies = this.cookies.Text;
            dospider sp = new dospider();
            try
            {
                sp.Url = lurl;
            }
            catch {
                MessageBox.Show("请检查URL是否输入有误！","温馨提示");
                return;
            }
            sp.Headers = headers;
            sp.Cookies = cookies;
            //string html = sp.crawler();
            if (headers == "")
            {
                MessageBox.Show("yes");
            }
            if (cookies == "")
            {
                MessageBox.Show("another yes");
            }
            MessageBox.Show(sp.crawler());
        }
    }
}
