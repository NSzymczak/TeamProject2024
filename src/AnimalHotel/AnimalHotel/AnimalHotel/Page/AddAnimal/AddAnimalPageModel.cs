using AnimalHotel.Connection;
using AnimalHotel.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel.Page.AddAnimal
{
    public partial class AddAnimalPageModel(ConnectToDb connectToDb, Animal animal) : ObservableObject
    {
        public Animal Animal { get; set; } = animal;

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
    }
}