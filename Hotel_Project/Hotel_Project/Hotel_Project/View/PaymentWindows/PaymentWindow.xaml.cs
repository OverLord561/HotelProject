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

namespace Hotel_Project.View.PaymentWindows
{
    /// <summary>
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        HotelDB db = new HotelDB();
        OrdersToReservations order = new OrdersToReservations();
        public PaymentWindow()
        {
            InitializeComponent();
            GetListOrder();
        }

        private void GetListOrder()
        {
            listOrders.ItemsSource = db.OrdersToReservations.Where(x => x.IsPayment == false).Select(o => new
            {
                Id = o.Id,
                DateStart = o.DateStart,
                DateEnd = o.DateEnd,
                HotelName = o.Rooms.Hotels.Name,
                RoomNum = o.Rooms.Number,
                Price = o.Rooms.Price,
                RoomTypesName = o.Rooms.RoomTypes.Title,
                UserName = o.Users.FullName
            }).ToList();
        }

        private void btn_payment_Click(object sender, RoutedEventArgs e)
        {
            int orderID = Convert.ToInt32(listOrders.SelectedValue);
            order = db.OrdersToReservations.FirstOrDefault(x => x.Id == orderID);
            order.IsPayment = true;
            db.SaveChanges();
            GetListOrder();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
