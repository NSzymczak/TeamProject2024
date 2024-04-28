using AnimalHotel.Connection;
using AnimalHotel.Page.AddAnimal;
using AnimalHotel.Page.AddDailyActivity;
using AnimalHotel.Page.AddOwner;
using AnimalHotel.Page.AddVisit;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnimalHotel.Page.DailyActivity
{
    public partial class DailyActivityPageModel(ConnectToDb connectToDb) : ObservableObject
    {
        private ObservableCollection<Model.DailyActivity>? dailyActivities;
        public ObservableCollection<Model.DailyActivity>? DailyActivities { get => dailyActivities; set => SetProperty(ref dailyActivities, value); }

        public bool IsBusy { get; set; } = false;

        public async Task LoadDailyActivity()
        {
            IsBusy = true;
            var dailyActivities = await connectToDb.GetDailyActivity();

            if (dailyActivities == null)
                MessageBox.Show("Ostrzeżenie", "Nie znaleziono żadnych wpisów", MessageBoxButton.OK);

            DailyActivities = new ObservableCollection<Model.DailyActivity>(dailyActivities!);
            IsBusy = false;
        }

        [RelayCommand]
        public static void AddNewDailyActivites()
        {
            (new AddDailyActivityPage()).ShowDialog();
        }

        [RelayCommand]
        public static void OpenAddAnimal()
        {
            (new AddAnimalPage()).ShowDialog();
        }

        [RelayCommand]
        public static void OpenAddOwner()
        {
            (new AddOwnerPage()).ShowDialog();
        }

        [RelayCommand]
        public static void OpenAddVisit()
        {
            (new AddVisitPage()).ShowDialog();
        }
    }
}