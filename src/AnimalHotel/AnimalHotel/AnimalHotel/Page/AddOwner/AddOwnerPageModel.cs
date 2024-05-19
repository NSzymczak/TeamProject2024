using AnimalHotel.Connection;
using AnimalHotel.Model;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace AnimalHotel.Page.AddOwner
{
    public partial class AddOwnerPageModel(ConnectToDb connectToDb, Owner owner)
    {
        public Owner AnimalOwner { get; set; } = owner;

        [RelayCommand]
        public async Task AddOrEditOwner(Window window)
        {
            await connectToDb.AddOrEditOwner(AnimalOwner);
            await Back(window);
        }

        [RelayCommand]
        public async Task Back(Window window)
        {
            window.Close();
        }
    }
}