using AnimalHotel.Model;
using System.Windows;

namespace AnimalHotel.Page.AddAnimal
{
    /// <summary>
    /// Logika interakcji dla klasy AddAnimalPage.xaml
    /// </summary>
    public partial class AddAnimalPage : Window
    {
        public AddAnimalPage(Animal? animal = null)
        {
            InitializeComponent();
            animal ??= new Animal();
            var pageModel = new AddAnimalPageModel(new Connection.ConnectToDb(), animal);
            DataContext = pageModel;
            Loaded += async (s, e) =>
            {
                await pageModel.LoadOwners();
            };
        }
    }
}