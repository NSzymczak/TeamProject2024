using AnimalHotel.Page.Visit;
using System.Windows;

namespace AnimalHotel.Page.AddDailyActivity
{
    public partial class AddDailyActivityPage : Window
    {
        public AddDailyActivityPage(Model.DailyActivity? dailyActivity = null)
        {
            InitializeComponent();

            dailyActivity ??= new Model.DailyActivity();
            var pageModel = new AddDailyActivityPageModel(new Connection.ConnectToDb(), dailyActivity);
            DataContext = pageModel;
            Loaded += async (s, e) =>
            {
                await pageModel.LoadAnimals();
            };
        }
    }
}