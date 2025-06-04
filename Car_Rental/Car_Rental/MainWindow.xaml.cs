using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Car_Rental
{
    public partial class MainWindow : Window
    {
        private static UserStore _userStore = new();

        public MainWindow()
        {
            InitializeComponent();
            PasswordBox.PasswordChanged += PasswordBox_PasswordChanged;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
        }

        private void ShowPasswordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = PasswordBox.Password;
            PasswordBox.Visibility = Visibility.Collapsed;
            PasswordTextBox.Visibility = Visibility.Visible;
        }

        private void ShowPasswordCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = PasswordTextBox.Text;
            PasswordBox.Visibility = Visibility.Visible;
            PasswordTextBox.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (ShowPasswordCheckBox.IsChecked == true)
                PasswordTextBox.Text = PasswordBox.Password;
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ShowPasswordCheckBox.IsChecked == true)
                PasswordBox.Password = PasswordTextBox.Text;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordBox.Visibility == Visibility.Visible ? PasswordBox.Password : PasswordTextBox.Text;

            var user = _userStore.ValidateUser(username, password);
            if (user != null)
            {
                if (user.Role == UserRole.Admin)
                {
                    var adminWindow = new AdminWindow(new Dictionary<string, string>()); // Poprawka
                    adminWindow.Show();
                }
                else
                {
                    var empWindow = new EmployeeWindow();
                    empWindow.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawid³owy login lub has³o.", "B³¹d logowania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
