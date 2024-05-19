using AnimalHotel.Connection;
using AnimalHotel.Model;
using AnimalHotel.Page.AddAnimal;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnimalHotel.Page.AddDailyActivity
{
    public partial class AddDailyActivityPageModel(ConnectToDb connectToDb, Model.DailyActivity dailyActivity) : ObservableObject
    {
        public Model.DailyActivity DailyActivity { get; set; } = dailyActivity;

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
        public async Task AddOrEditDailyActivity()
        {
            await connectToDb.AddOrEditDailyActivity(DailyActivity);
        }

        [RelayCommand]
        public async Task Back(Window window)
        {
            window.Close();
        }

        [RelayCommand]
        public async Task EditAnimal(Window window)
        {
            if (DailyActivity.Animal != null)
            {
                (new AddAnimalPage(DailyActivity.Animal)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Ostrzeżenie", "Nie wybrano zwierzaka do edycji", MessageBoxButton.OK);
            }
            await Back(window);
        }
    }
}