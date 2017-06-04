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
    /// Логика взаимодействия для FreeRoomWindow.xaml
    /// </summary>
    public partial class FreeRoomWindow : Window
    {
        HotelDB db = new HotelDB();
        Rooms room = new Rooms();
        public FreeRoomWindow()
        {
            InitializeComponent();
            GetListRooms();
            cbx_RoomTypes.ItemsSource = db.RoomTypes.ToList();
            cbx_Hotels.ItemsSource = db.Hotels.ToList();
        }

        private void GetListRooms()
        {
            listRooms.ItemsSource = db.Rooms.Where(x => x.IsBlocked == true).Select(r => new
            {
                Id = r.Id,
                HotelName = r.Hotels.Name,
                Number = r.Number,    
                Price = r.Price,
                Count = r.Count,
                TypeRoomTitle = r.RoomTypes.Title,
               // UserName = r.OrdersToReservations.FirstOrDefault(o=>o.Rooms.Id == r.Id).Users.FullName,
                UserName = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).Users.FullName,
                //IsPayment = r.OrdersToReservations.FirstOrDefault(o => o.Rooms.Id == r.Id).IsPayment == true? "Так":"Ні"
                IsPayment = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).IsPayment == true ? "Так" : "Ні"
            }).ToList();
        }

        private void btn_freeRoom_Click(object sender, RoutedEventArgs e)
        {
            int roomID = Convert.ToInt32(listRooms.SelectedValue);
            room = (Rooms)db.Rooms.FirstOrDefault(x => x.Id == roomID);
            room.IsBlocked = false;
            db.SaveChanges();
            GetListRooms();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbx_RoomTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_Hotels.SelectedValue == null)
            {
                listRooms.ItemsSource = db.Rooms.ToList().Where(x => x.RoomTypesID == Convert.ToInt32(cbx_RoomTypes.SelectedValue) && x.IsBlocked == true).Select(r => new
                {
                    Id = r.Id,
                    HotelName = r.Hotels.Name,
                    Number = r.Number,
                    Price = r.Price,
                    Count = r.Count,
                    TypeRoomTitle = r.RoomTypes.Title,
                    UserName = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).Users.FullName,
                    IsPayment = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).IsPayment == true ? "Так" : "Ні"
                });
            }
            else
            {
                listRooms.ItemsSource = db.Rooms.ToList().Where(x => x.RoomTypesID == Convert.ToInt32(cbx_RoomTypes.SelectedValue)
                                                                  && x.HotelsID == Convert.ToInt32(cbx_Hotels.SelectedValue) && x.IsBlocked == true).Select(r => new
                {
                    Id = r.Id,
                    HotelName = r.Hotels.Name,
                    Number = r.Number,
                    Price = r.Price,
                    Count = r.Count,
                    TypeRoomTitle = r.RoomTypes.Title,
                    UserName = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).Users.FullName,
                    IsPayment = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).IsPayment == true ? "Так" : "Ні"
                });
            }            
        }

        private void cbx_Hotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx_RoomTypes.SelectedValue == null)
            {
                listRooms.ItemsSource = db.Rooms.ToList().Where(x => x.HotelsID == Convert.ToInt32(cbx_Hotels.SelectedValue) && x.IsBlocked == true).Select(r => new
                {
                    Id = r.Id,
                    HotelName = r.Hotels.Name,
                    Number = r.Number,
                    Price = r.Price,
                    Count = r.Count,
                    TypeRoomTitle = r.RoomTypes.Title,
                    UserName = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).Users.FullName,
                    IsPayment = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).IsPayment == true ? "Так" : "Ні"
                });
            }
            else
            {
                listRooms.ItemsSource = db.Rooms.ToList().Where(x => x.RoomTypesID == Convert.ToInt32(cbx_RoomTypes.SelectedValue)
                                                                  && x.HotelsID == Convert.ToInt32(cbx_Hotels.SelectedValue) && x.IsBlocked == true).Select(r => new
                                                                  {
                                                                      Id = r.Id,
                                                                      HotelName = r.Hotels.Name,
                                                                      Number = r.Number,
                                                                      Price = r.Price,
                                                                      Count = r.Count,
                                                                      TypeRoomTitle = r.RoomTypes.Title,
                                                                      UserName = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).Users.FullName,
                                                                      IsPayment = r.OrdersToReservations.ToList().OrderByDescending(o => o.Id).FirstOrDefault(o => o.Rooms.Id == r.Id).IsPayment == true ? "Так" : "Ні"
                                                                  });
            }
        }
    }
}
