using AnimalHotel.Connection;
using AnimalHotel.Model;
using CommunityToolkit.Mvvm.Input;

namespace AnimalHotel.Page.AddOwner
{
    public partial class AddOwnerPageModel(ConnectToDb connectToDb, Owner owner)
    {
        public Owner AnimalOwner { get; set; } = owner;

        [RelayCommand]
        public async Task AddOrEditOwner()
        {
            await connectToDb.AddOrEditOwner(AnimalOwner);
        }

        [RelayCommand]
        public async Task Back()
        {
        }
    }
}