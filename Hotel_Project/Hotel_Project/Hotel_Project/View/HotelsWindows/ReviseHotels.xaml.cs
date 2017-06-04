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

namespace Hotel_Project.View.HotelsWindows
{
    /// <summary>
    /// Логика взаимодействия для ReviseHotels.xaml
    /// </summary>
    public partial class ReviseHotels : Window
    {
        HotelDB db = new HotelDB();
        Hotels hotel = new Hotels();
        public ReviseHotels()
        {
            InitializeComponent();
            listHotels.ItemsSource = db.Hotels.ToList();
        }

        private void listHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                grdHotelInfo.Visibility = System.Windows.Visibility.Visible;
                hotel = (Hotels)listHotels.SelectedItem;

                grdHotelInfo.DataContext = hotel;          

            }
            catch { grdHotelInfo.Visibility = System.Windows.Visibility.Collapsed; }
        }
    }
}
