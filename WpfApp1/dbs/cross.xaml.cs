using System;
using System.Collections.Generic;
using System.IO;
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
namespace WpfApp1.dbs
{
    /// <summary>
    /// cross.xaml 的交互逻辑
    /// </summary>
    public partial class cross : Page
    {
        private Dictionary<string, string> dbs_names = new Dictionary<string, string>();
        public cross()
        {
            InitializeComponent();
            DirectoryInfo theFolder = new DirectoryInfo(static_info.origin_db_path);
            foreach (FileInfo nextFile in theFolder.GetFiles()) {
                if (nextFile.Name.Contains("_db.txt")) {
                    dbs_names.Add(nextFile.Name.dtxt(), nextFile.Name.dtxt());
                }
            }
            this.dbs_name_con.ItemsSource = dbs_names;
            this.dbs_name_con.SelectedIndex = 0;
            this.dbs_name_con.SelectedValuePath = "Key";
            this.dbs_name_con.DisplayMemberPath = "Value";
        }
        
    }
   
}
