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

namespace Hotel_Project.View.PaymentWindow
{
    /// <summary>
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        Users user;
        public PaymentWindow()
        {
            InitializeComponent();
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
