using AnimalHotel.Model;
using System.Windows;

namespace AnimalHotel.Page.AddVisit;

/// <summary>
/// Logika interakcji dla klasy AddVisitPage.xaml
/// </summary>
public partial class AddVisitPage : Window
{
    public AddVisitPage(Visit? visit = null)
    {
        InitializeComponent();
        visit ??= new Visit();
        var pageModel = new AddVisitPageModel(new Connection.ConnectToDb(), visit);
        DataContext = pageModel;
        Loaded += async (s, e) =>
        {
            await pageModel.LoadAnimals();
        };
    }
}