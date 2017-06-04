using Hotel_Project.Model;
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

namespace Hotel_Project.View.UsersWindows
{
    /// <summary>
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        HotelDB db = new HotelDB();
        Users user = new Users();
        public UsersWindow()
        {
            InitializeComponent();
            listUsers.ItemsSource = db.Users.ToList();
        }
        public List<InfoOrder> GetGridInfo(List<OrdersToReservations> ordersList)
        {
            List<InfoOrder> infoOrders = new List<Hotel_Project.Model.InfoOrder>();
            Hotels hotel = new Hotels();
            Rooms room = new Rooms();
            for (int i = 0; i < ordersList.Count; i++)
            {
                try
                {
                    room = (Rooms)db.Rooms.Find(ordersList[i].RoomID);
                    hotel = (Hotels)db.Hotels.Find( room.HotelsID);
                    InfoOrder ord = new InfoOrder();
                    ord.HotelName = hotel.Name;
                    ord.RoomNum = room.Number;
                    ord.DateStartOrd = ordersList[i].DateStart;
                    ord.DateEndOrd = ordersList[i].DateEnd;
                    infoOrders.Add(ord);
                }
                catch(Exception ex) { }
            }
            return infoOrders;
        }
        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                grdLastInfo.Visibility = System.Windows.Visibility.Visible;
                user = (Users)listUsers.SelectedItem;
                List<OrdersToReservations> ordersList = db.OrdersToReservations.Where(x => x.UserID == user.Id).ToList();
                OrdersToReservations lastOrder = new OrdersToReservations();
                lastOrder = ordersList.Last();
                lbl_DateStart.Content = lastOrder.DateStart;
                lbl_DateEnd.Content = lastOrder.DateEnd;
                listOrders.ItemsSource = GetGridInfo(ordersList);

            }
            catch { grdLastInfo.Visibility = System.Windows.Visibility.Collapsed; }
        }

        
    }
}
