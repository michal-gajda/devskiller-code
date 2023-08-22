using System;
using System.Windows;
using UserDataRegistration.Model;

namespace UserDataRegistration.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RegisterUserWindow : Window
    {
        public Func<string> OnRegister { get; set; }

        public UserDataViewModel UserData
        {
            get
            {
                return DataContext as UserDataViewModel;
            }
        }

        public RegisterUserWindow()
        {
            DataContext = new UserDataViewModel();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.edFirstName.Text) || string.IsNullOrEmpty(this.edLastName.Text) || this.edAggree.IsChecked == false)
            {
                this.labResult.Content = "The form is not correctly completed!";

                return;
            }

            if (this.OnRegister != null)
            {
                this.labResult.Content = this.OnRegister.Invoke();
            }
        }
    }
}
