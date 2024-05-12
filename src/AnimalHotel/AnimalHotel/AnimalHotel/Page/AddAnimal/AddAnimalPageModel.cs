using AnimalHotel.Connection;
using AnimalHotel.Model;
using AnimalHotel.Page.AddOwner;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnimalHotel.Page.AddAnimal
{
    public partial class AddAnimalPageModel(ConnectToDb connectToDb, Animal animal) : ObservableObject
    {
        public Animal Animal { get; set; } = animal;
        private ObservableCollection<Owner> owners;
        public ObservableCollection<Owner> Owners { get => owners; set => SetProperty(ref owners, value); }

        public async Task LoadOwners()
        {
            var owners = await connectToDb.GetOwners();

            if (owners == null)
                MessageBox.Show("Ostrzeżenie", "Nie znaleziono żadnych właścicieli. Dodaj najpierw właściciela.", MessageBoxButton.OK);
            Owners = new ObservableCollection<Owner>(owners!);
        }

        [RelayCommand]
        public async Task AddAnimal()
        {
            await connectToDb.AddOrEditAnimal(Animal);
        }

        [RelayCommand]
        public Task Back()
        {
            //Close somehow
            return Task.CompletedTask;
        }

        [RelayCommand]
        public async Task EditOwner()
        {
            if (Animal.Owner != null)
            {
                (new AddOwnerPage(Animal.Owner)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Ostrzeżenie", "Nie wybrano właściciela do edycji", MessageBoxButton.OK);
            }
        }
    }
}