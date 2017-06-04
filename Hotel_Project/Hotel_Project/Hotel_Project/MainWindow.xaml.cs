using Hotel_Project.View.HotelsWindows;
using Hotel_Project.View.PaymentWindows;
using Hotel_Project.View.RoomsWindows;
using Hotel_Project.View.UsersWindows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel_Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HotelDB db = new HotelDB();

        Users user = new Users();
        Hotels hotel = new Hotels();
        Rooms room = new Rooms();
        public MainWindow()
        {
            InitializeComponent();
            listHotels.ItemsSource = db.Hotels.ToList();
            listRooms.ItemsSource = db.Rooms.ToList();
            cbx_RoomTypes.ItemsSource = db.RoomTypes.ToList();
            
        }
        private void btn_blockNumber_Click(object sender, RoutedEventArgs e)
        {
            userGrid.Visibility = System.Windows.Visibility.Visible;
        }
        private void btn_next1_Click(object sender, RoutedEventArgs e)
        {
            userGrid.Visibility = System.Windows.Visibility.Collapsed;
            hotelGrid.Visibility = System.Windows.Visibility.Visible;

            user.FullName = txt_UserNameFull.Text;
            user.PassportSeria = txt_UserPassportSeria.Text;
            user.PassportNum = txt_UserPassportNum.Text;
            user.Phone = txt_UserPhone.Text;
        }
        private void btn_next2_Click(object sender, RoutedEventArgs e)
        {
            hotelGrid.Visibility = System.Windows.Visibility.Collapsed;
            roomGrid.Visibility = System.Windows.Visibility.Visible;

            hotel = (Hotels)listHotels.SelectedItem;
            listRooms.ItemsSource = db.Rooms.ToList().Where(x => x.HotelsID == hotel.Id && x.IsBlocked == false);
        }
        private void btn_back1_Click(object sender, RoutedEventArgs e)
        {
            hotelGrid.Visibility = System.Windows.Visibility.Collapsed;
            userGrid.Visibility = System.Windows.Visibility.Visible;
            
        }
        private void btn_back2_Click(object sender, RoutedEventArgs e)
        {
            hotelGrid.Visibility = System.Windows.Visibility.Visible;
            roomGrid.Visibility = System.Windows.Visibility.Collapsed;
            
        }
        private void cbx_RoomTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listRooms.ItemsSource = db.Rooms.ToList().Where(x=>x.RoomTypesID == Convert.ToInt32(cbx_RoomTypes.SelectedValue) && x.HotelsID == hotel.Id && x.IsBlocked ==false);
        }
        private void btn_block_Click(object sender, RoutedEventArgs e)
        { 
            if (db.Users.Where(x => x.FullName == txt_UserNameFull.Text).ToList().Count != 0)
            {
                //Проверка, существует ли пользователь с таким NameFull в БД
                user = (Users)db.Users.Where(x => x.FullName == txt_UserNameFull.Text).ToList().First();
            }
                     
            room = (Rooms)listRooms.SelectedItem;

            OrdersToReservations order = new OrdersToReservations();
            order.RoomID = room.Id;
            order.IsPayment = false;
            order.DateStart = Convert.ToDateTime(datePicker1.Text);
            order.DateEnd = Convert.ToDateTime(datePicker2.Text);           
            order.Users = user;
            db.OrdersToReservations.Add(order);
            room.IsBlocked = true;

            db.SaveChanges();

            MessageBox.Show("Операція пройшла успішно!");
            roomGrid.Visibility = System.Windows.Visibility.Collapsed;
        }     

        private void btn_payment_Click(object sender, RoutedEventArgs e)
        {
            PaymentWindow paymentWindow = new PaymentWindow();
            paymentWindow.Show();
        }
        private void btn_clearNumber_Click(object sender, RoutedEventArgs e)
        {
            FreeRoomWindow freeRoomWindow = new FreeRoomWindow();
            freeRoomWindow.Show();
        }

        private void MenuItemShowUsers_Click(object sender, RoutedEventArgs e)
        {
            UsersWindow windowUsers = new UsersWindow();
            windowUsers.Show();
        }

        private void MenuItemAddHotel_Click(object sender, RoutedEventArgs e)
        {
            AddHotelWindow addHotelWidow = new AddHotelWindow();
            addHotelWidow.Show();
        }

        private void MenuItemReviseHotels_Click(object sender, RoutedEventArgs e)
        {
            ReviseHotels reviseHotelsWidow = new ReviseHotels();
            reviseHotelsWidow.Show();
        }

        private void MenuItemAddRoom_Click(object sender, RoutedEventArgs e)
        {
            AddRoomWindow addRoomWindow = new AddRoomWindow();
            addRoomWindow.Show();
        }

        private void MenuItemReviseRooms_Click(object sender, RoutedEventArgs e)
        {
            ReviseRoomsWindow r = new ReviseRoomsWindow();
            r.Show();
        }
    }
}
