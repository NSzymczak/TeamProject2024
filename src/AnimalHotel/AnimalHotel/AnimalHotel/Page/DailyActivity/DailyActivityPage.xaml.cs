using System.Windows;

namespace AnimalHotel.Page.DailyActivity;

/// <summary>
/// Logika interakcji dla klasy DailyActivityPage.xaml
/// </summary>
public partial class DailyActivityPage : Window
{
    public DailyActivityPage()
    {
        InitializeComponent();
        var pageModel = new DailyActivityPageModel(new Connection.ConnectToDb());
        DataContext = pageModel;
        Loaded += async (s, e) =>
        {
            await pageModel.LoadDailyActivity();
        };
    }
}