using System.Windows.Controls;
using System.Collections.ObjectModel;
using WpfApp1.dol;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WpfApp1.crawler
{
    /// <summary>
    /// info_list.xaml 的交互逻辑
    /// </summary>
    public partial class info_list : Page
    {
        public info_list()
        {
            InitializeComponent();
            ObservableCollection<Member> memberdata = new ObservableCollection<Member>();
            dol.dol dl = new dol.dol();
            //dl.getmysqlcom("insert into crawl_info values(1,'crawl1','','','',1)");
            MySqlDataReader md = dl.getmysqlread("select * from crawl_info");
            while (md.Read())
            {
                memberdata.Add(new Member()
                {
                    busi = md.GetString(1),
                    dev = md.GetString(2),
                    logic = md.GetString(3),
                    locate = md.GetString(4),
                });

            }
            info_list_dg.DataContext = memberdata;
        }
    }
    public class Member {
        public string busi { get; set; }
        public string dev { get; set; }
        public string logic { get; set; }
        public string locate { get; set; }
    }
}
