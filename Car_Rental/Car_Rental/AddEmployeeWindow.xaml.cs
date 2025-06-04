using System.Windows;

namespace Car_Rental
{
    public partial class AddEmployeeWindow : Window
    {
        public string Username => UsernameTextBox.Text.Trim();
        public string Password => PasswordBox.Password;

        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Wprowad� nazw� u�ytkownika i has�o.", "B��d", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}