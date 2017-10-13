using System.Windows.Controls;
using System.Collections.ObjectModel;
using WpfApp1.dol;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Windows;
using WpfApp1.crawler;
using System;
using System.Windows.Input;

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
            load_datagrid();
        }
        /// <summary>
        /// 重新加载datagrid内容
        /// </summary>
        public void load_datagrid()
        {
            ObservableCollection<Member> memberdata = new ObservableCollection<Member>();
            dol.dol dl = new dol.dol();
            //dl.getmysqlcom("insert into crawl_info values(1,'crawl1','','','',1)");
            MySqlDataReader md = dl.getmysqlread("select * from crawl_info");
            while (md.Read())
            {
                memberdata.Add(new Member()
                {
                    id = md.GetInt32(0),
                    busi = md.GetString(1),
                    dev = md.GetString(2),
                    logic = md.GetString(3),
                    locate = md.GetString(4),
                });

            }
            info_list_dg.DataContext = memberdata;
        }

        private void info_delete(object sender, RoutedEventArgs e) {
            int count = this.info_list_dg.SelectedItems.Count;
            Member[] dt = new Member[count];
            string[] ids = new string[count];
            for (int i = 0; i < count; i++) {
                dt[i] = this.info_list_dg.SelectedItems[i] as Member;
                try
                {
                    ids[i] = dt[i].id.ToString();
                }
                catch {
                    MessageBox.Show("没有选中");
                }
            }
            string all_id = string.Join(",",ids);
            string sql = string.Format("delete from crawl_info where id in ({0})", all_id);
            dol.dol dl = new dol.dol();
            try
            {
                Debug.WriteLine(sql);
                dl.getmysqlcom(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                load_datagrid();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Member {
        public int id { get; set; }
        public string busi { get; set; }
        public string dev { get; set; }
        public string logic { get; set; }
        public string locate { get; set; }
    }
}
