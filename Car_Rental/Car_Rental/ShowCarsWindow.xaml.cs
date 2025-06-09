using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Car_Rental
{
    public class CarInfo
    {
        public required string Brand { get; set; } // Dodano w³aœciwoœæ Brand
        public required string Model { get; set; }
        public required string Registration { get; set; }
        public required bool IsAvailable { get; set; }
        public required string ImagePath { get; set; }
        public int Year { get; set; }
        public BitmapImage Image => !string.IsNullOrEmpty(ImagePath) 
            ? new BitmapImage(new System.Uri(ImagePath, System.UriKind.RelativeOrAbsolute)) 
            : new BitmapImage();
    }

    public partial class ShowCarsWindow : Window
    {
        public ObservableCollection<CarInfo> Cars { get; set; }

        public ShowCarsWindow(List<string> cars)
        {
            InitializeComponent();
            Cars = new ObservableCollection<CarInfo>
            {
                new CarInfo { Brand = "Toyota", Model = "Corolla", Year = 2020, Registration = "KR12345", IsAvailable = true, ImagePath = "Images/toyota.jpg" },
                // Dodaj pozosta³e auta z odpowiedni¹ mark¹ i modelem
            };
            DataContext = this;
        }

        private void ServiceButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.DataContext is CarInfo car)
            {
                MessageBox.Show($"Serwisowanie auta: {car.Model} ({car.Registration})", "Serwis", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}