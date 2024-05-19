using AnimalHotel.Connection;
using AnimalHotel.Model;
using AnimalHotel.Page.AddAnimal;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnimalHotel.Page.AddVisit
{
    public partial class AddVisitPageModel(ConnectToDb connectToDb, Model.Visit visit) : ObservableObject
    {
        public Model.Visit Visit { get; set; } = visit;

        private ObservableCollection<Animal>? animals;
        public ObservableCollection<Animal>? Animals { get => animals; set => SetProperty(ref animals, value); }

        public async Task LoadAnimals()
        {
            var animals = await connectToDb.GetAnimals();

            if (animals == null)
            {
                MessageBox.Show("Ostrzeżenie", "Nie znaleziono żadnych zwierząt", MessageBoxButton.OK);
                return;
            }

            Animals = new ObservableCollection<Animal>(animals);
        }

        [RelayCommand]
        public async Task AddOrEditVisit()
        {
            await connectToDb.AddOrEditVisit(Visit);
        }

        [RelayCommand]
        public async Task Back(Window window)
        {
            window.Close();
        }

        [RelayCommand]
        public async Task EditAnimal(Window window)
        {
            if (Visit.Animal != null)
            {
                (new AddAnimalPage(Visit.Animal)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Ostrzeżenie", "Nie wybrano zwierzaka do edycji", MessageBoxButton.OK);
            }
            await Back(window);
        }
    }
}