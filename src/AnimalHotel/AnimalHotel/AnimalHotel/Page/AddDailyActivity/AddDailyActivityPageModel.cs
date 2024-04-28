using AnimalHotel.Connection;
using AnimalHotel.Model;
using AnimalHotel.Page.AddAnimal;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace AnimalHotel.Page.AddDailyActivity
{
    public partial class AddDailyActivityPageModel(ConnectToDb connectToDb, Model.DailyActivity dailyActivity)
    {
        public Model.DailyActivity DailyActivity { get; set; } = dailyActivity;
        public List<Animal>? Animals { get; set; }

        [RelayCommand]
        public async Task AddOrEditDailyActivity()
        {
            await connectToDb.AddOrEditDailyActivity(DailyActivity);
        }

        [RelayCommand]
        public async Task Back()
        {
        }

        [RelayCommand]
        public async Task EditAnimal()
        {
            if (DailyActivity.Animal != null)
            {
                (new AddAnimalPage(DailyActivity.Animal)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Ostrzeżenie", "Nie wybrano zwierzaka do edycji", MessageBoxButton.OK);
            }
        }
    }
}