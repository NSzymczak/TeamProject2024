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
using System.Windows.Shapes;

namespace AnimalHotel.Page.DailyActivity
{
    /// <summary>
    /// Logika interakcji dla klasy DailyActivityPage.xaml
    /// </summary>
    public partial class DailyActivityPage : Window
    {
        public DailyActivityPage()
        {
            InitializeComponent();
            DataContext = new DailyActivityPageModel(new Connection.ConnectToDb());
        }
    }
}