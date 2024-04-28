using AnimalHotel.Connection;
using AnimalHotel.Model;
using AnimalHotel.Page.AddAnimal;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace AnimalHotel.Page.AddVisit
{
    public partial class AddVisitPageModel(ConnectToDb connectToDb, Visit visit)
    {
        public Visit Visit { get; set; } = visit;
        public List<Animal>? Animals { get; set; }

        [RelayCommand]
        public async Task AddOrEditVisit()
        {
            await connectToDb.AddOrEditVisit(Visit);
        }

        [RelayCommand]
        public async Task Back()
        {
        }

        [RelayCommand]
        public async Task EditAnimal()
        {
            if (Visit.Animal != null)
            {
                (new AddAnimalPage(Visit.Animal)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Ostrzeżenie", "Nie wybrano zwierzaka do edycji", MessageBoxButton.OK);
            }
        }
    }
}