using System.Collections.Generic;
using System.Windows;

namespace Car_Rental
{
    public partial class AdminWindow : Window
    {
        private readonly Dictionary<string, string> _employees;

        public AdminWindow(Dictionary<string, string> employees)
        {
            InitializeComponent();
            _employees = employees;
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddEmployeeWindow();
            if (addWindow.ShowDialog() == true)
            {
                string username = addWindow.Username;
                string password = addWindow.Password;
                if (!_employees.ContainsKey(username))
                {
                    AddEmployee(username, password);
                    MessageBox.Show("Pracownik dodany!", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Pracownik o takiej nazwie ju¿ istnieje.", "B³¹d", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void AddEmployee(string username, string password)
        {
            _employees[username] = password;
        }

        private void ShowCarsButton_Click(object sender, RoutedEventArgs e)
        {
            var cars = new List<string>
            {
                "Toyota Corolla 2020",
                //"Ford Focus 2019",
                //"Volkswagen Golf 2018",
                //"BMW 3 Series 2021"
            };
            this.Hide(); // Ukryj okno AdminWindow
            var showCarsWindow = new ShowCarsWindow(cars);
            showCarsWindow.Closed += (s, args) => this.Show(); // Po zamkniêciu okna aut poka¿ ponownie AdminWindow
            showCarsWindow.ShowDialog();
        }
    }
}