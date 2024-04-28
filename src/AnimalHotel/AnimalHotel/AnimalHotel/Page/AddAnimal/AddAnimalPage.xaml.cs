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
            DataContext = new AddAnimalPageModel(new Connection.ConnectToDb(), animal);
        }
    }
}