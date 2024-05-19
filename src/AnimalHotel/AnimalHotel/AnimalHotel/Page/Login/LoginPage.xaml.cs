using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AnimalHotel.Page.Login
{
    /// <summary>
    /// Logika interakcji dla klasy LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        private readonly LoginPageModel pageModel;

        public LoginPage()
        {
            InitializeComponent();
            pageModel = new LoginPageModel(new Core.AnimalHotelDb());
            DataContext = pageModel;
        }

        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pageModel != null)
            {
                pageModel.Password = ((PasswordBox)sender).Password;
            }
        }
    }
}