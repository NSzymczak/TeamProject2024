using System.Windows;

namespace AnimalHotel.Page.AddDailyActivity
{
    public partial class AddDailyActivityPage : Window
    {
        public AddDailyActivityPage(Model.DailyActivity? dailyActivity = null)
        {
            InitializeComponent();

            dailyActivity ??= new Model.DailyActivity();
            DataContext = new AddDailyActivityPageModel(new Connection.ConnectToDb(), dailyActivity);
        }
    }
}