using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfApp1.dol;
namespace WpfApp1.crawler
{
    /// <summary>
    /// info.xaml 的交互逻辑
    /// </summary>
    public partial class cinfo : Page
    {
        public cinfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加爬虫信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string busi = this.busi.Text.Trim();
            string dev = this.dev.Text.Trim();
            string logic = this.logic.Text.Trim();
            string locate = this.locate.Text.Trim();
            string sql = string.Format("insert into busi_control.crawl_info(busi,dev,logic,locate,status) values('{0}','{1}','{2}','{3}',{4})",busi,dev,logic,locate,2);
            dol.dol d = new dol.dol();
            try
            {
                d.getmysqlcom(sql);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
            //info_list il = new info_list();
            //il.load_datagrid();
        }
    }
}
