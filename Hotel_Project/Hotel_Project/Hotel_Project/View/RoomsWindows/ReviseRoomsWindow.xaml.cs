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

namespace Hotel_Project.View.RoomsWindows
{
    /// <summary>
    /// Логика взаимодействия для ReviseRoomsWindow.xaml
    /// </summary>
    public partial class ReviseRoomsWindow : Window
    {
        HotelDB db = new HotelDB();
        Hotels hotel = new Hotels();
        public ReviseRoomsWindow()
        {
            InitializeComponent();
            listHotels.ItemsSource = db.Hotels.ToList();
            listRooms.ItemsSource = db.Rooms.Select(r => new
            {
                HotelName = r.Hotels.Name,
                Number = r.Number,
                Count = r.Count,
                Price = r.Price,
                IsBlock = r.IsBlocked == true? "Зайнятий" : "Вільний"
            }).ToList();
        }

        private void listHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            hotel = (Hotels)listHotels.SelectedItem;
            grdHotelInfo.DataContext = hotel; 

            try
            {
                hotel = (Hotels)listHotels.SelectedItem;
                listRooms.ItemsSource = db.Rooms.Where(x => x.HotelsID == hotel.Id).Select(r => new
                {
                    HotelName = r.Hotels.Name,
                    Number = r.Number,
                    Count = r.Count,
                    Price = r.Price,
                    IsBlock = r.IsBlocked == true ? "Зайнятий" : "Вільний"
                }).ToList();
            }
            catch { }
        }
    }
}
