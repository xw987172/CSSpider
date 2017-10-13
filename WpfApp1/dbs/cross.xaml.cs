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

namespace WpfApp1.dbs
{
    /// <summary>
    /// cross.xaml 的交互逻辑
    /// </summary>
    public partial class cross : Page
    {
        private Dictionary<string, string> dbs_names = new Dictionary<string, string>() {
            { "this","this"},
            { "is","is"},
        };
        public cross()
        {
            InitializeComponent();
            //dbs_names.Add("a", "a");
            //dbs_names.Add("b", "b");
            //dbs_names.Add("c", "c");
            this.dbs_name_con.ItemsSource = dbs_names;
            this.dbs_name_con.SelectedValuePath = "Key";
            this.dbs_name_con.DisplayMemberPath = "Value";
        }
    }
}
