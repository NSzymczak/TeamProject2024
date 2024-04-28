using AnimalHotel.Model;
using System.Windows;

namespace AnimalHotel.Page.AddOwner
{
    /// <summary>
    /// Logika interakcji dla klasy AddOwnerPage.xaml
    /// </summary>
    public partial class AddOwnerPage : Window
    {
        public AddOwnerPage(Owner? owner = null)
        {
            InitializeComponent();
            owner ??= new Owner();
            DataContext = new AddOwnerPageModel(new Connection.ConnectToDb(), owner);
        }
    }
}