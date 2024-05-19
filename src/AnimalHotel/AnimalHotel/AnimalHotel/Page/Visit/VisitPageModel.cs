using AnimalHotel.Connection;
using AnimalHotel.Page.AddVisit;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnimalHotel.Page.Visit
{
    public partial class VisitPageModel(ConnectToDb connectToDb) : ObservableObject
    {
        private ObservableCollection<Model.Visit>? visits;
        public ObservableCollection<Model.Visit>? Visits { get => visits; set => SetProperty(ref visits, value); }

        public bool IsBusy { get; set; } = false;

        public async Task LoadVisits()
        {
            IsBusy = true;
            var visits = await connectToDb.GetVisits();

            if (visits == null)
            {
                MessageBox.Show("Ostrzeżenie", "Nie znaleziono żadnych wizyt", MessageBoxButton.OK);
                return;
            }

            Visits = new ObservableCollection<Model.Visit>(visits);
            IsBusy = false;
        }

        [RelayCommand]
        public async Task OpenAddVisit()
        {
            (new AddVisitPage()).ShowDialog();
            await LoadVisits();
        }
    }
}