using AnimalHotel.Connection;
using AnimalHotel.Model;
using AnimalHotel.Page.AddOwner;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AnimalHotel.Page.AddAnimal
{
    public partial class AddAnimalPageModel(ConnectToDb connectToDb, Animal animal) : ObservableObject
    {
        public Animal Animal { get; set; } = animal;
        public List<Owner> Owners { get; set; }

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