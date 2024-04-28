using AnimalHotel.Core;
using AnimalHotel.Page.DailyActivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace AnimalHotel.Page.Login
{
    public partial class LoginPageModel(AnimalHotelDb animalHotelDb) : ObservableObject
    {
        private string? _login;
        private string? _password;
        public string? Login { get => _login; set => SetProperty(ref _login, value); }
        public string? Password { get => _password; set => SetProperty(ref _password, value); }
        public int LoginLefts { get; set; }

        [RelayCommand]
        public void LogIn()
        {
#if DEBUG
            (new DailyActivityPage()).Show();
#endif
            if (string.IsNullOrEmpty(Login) ||
                string.IsNullOrEmpty(Password))
            {
                return;
            }
            var user = animalHotelDb.User.Where(x => x.Login == Login && x.Password == Password);

            if (user == null)
            {
                LoginLefts--;
                MessageBox.Show("Niepoprawne dane! Pozostało " + LoginLefts + " prób logowania.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                (new DailyActivityPage()).Show();
            }

            if (LoginLefts == 0)
            {
                var result = MessageBox.Show("Konto zostało zablokowane!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    Environment.Exit(LoginLefts);
                }
            }
        }
    }
}