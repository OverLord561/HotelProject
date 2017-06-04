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
    /// Логика взаимодействия для AddRoomWindow.xaml
    /// </summary>
    public partial class AddRoomWindow : Window
    {
        HotelDB db = new HotelDB();
        Rooms room;
        Hotels hotel;
        public AddRoomWindow()
        {
            InitializeComponent();
            listHotels.ItemsSource = db.Hotels.ToList();
            cbx_RoomTypes.ItemsSource = db.RoomTypes.ToList();
        }

        private void listHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbl_InfoRoom.Visibility = System.Windows.Visibility.Visible;
            grdRoomInfo.Visibility = System.Windows.Visibility.Visible;
            hotel = (Hotels)listHotels.SelectedItem;

            listRooms.ItemsSource = db.Rooms.Where(x => x.HotelsID == hotel.Id).Select(r => new
            {
                Number = r.Number,
                Count = r.Count,
                Price = r.Price,
                RoomTypesName = r.RoomTypes.Title
            }).ToList();
        }

        private void btn_addRoom_Click(object sender, RoutedEventArgs e)
        {
            int allRoomCount = hotel.RoomsCount;

            if (db.Rooms.ToList().Where(x => x.HotelsID == hotel.Id).Count() < allRoomCount)
            {
                room = new Rooms();
                room.Number = Convert.ToInt32(txt_Number.Text);
                room.Price = Convert.ToDecimal(txt_Price.Text);
                room.Count = Convert.ToInt32(txt_Count.Text);
                room.RoomTypesID = Convert.ToInt32(cbx_RoomTypes.SelectedValue);
                room.HotelsID = hotel.Id;

                db.Rooms.Add(room);
                db.SaveChanges();
                listRooms.ItemsSource = db.Rooms.Where(x => x.HotelsID == hotel.Id).Select(r => new
                {
                    Number = r.Number,
                    Count = r.Count,
                    Price = r.Price,
                    RoomTypesName = r.RoomTypes.Title
                }).ToList();
            }
            else
            {
                string message = string.Format("Ви не можете додати кімнату до даного готелю! ( Максимальний ліміт {0} кімнат(и) )", allRoomCount);
                MessageBox.Show(message);
            }
        }

        private void btn_cancelRoom_Click(object sender, RoutedEventArgs e)
        {
            txt_Number.Text = String.Empty;
            txt_Count.Text = String.Empty;
            txt_Price.Text = String.Empty;
            grdRoomInfo.Visibility = System.Windows.Visibility.Collapsed;
            lbl_InfoRoom.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
