using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddHotelWindow.xaml
    /// </summary>
    public partial class AddHotelWindow : Window
    {
        string imgLocation;
        public AddHotelWindow()
        {
            InitializeComponent();
        }

        private void txt_Photo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Виберіть фото";
                if (dlg.ShowDialog() == true)
                {
                    imgLocation = dlg.FileName.ToString();

                    BitmapImage b = new BitmapImage();
                    b.BeginInit();
                    b.UriSource = new Uri(imgLocation);
                    b.EndInit();
                    picture.Source = b;

                }
            }
            catch { }            
        }


        private void btn_addHotel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                using (HotelDB db = new HotelDB())
                {
                    Hotels hotel = new Hotels();
                    hotel.Name = txt_Name.Text;
                    hotel.Address = txt_Address.Text;
                    hotel.Description = txt_Description.Text;
                    hotel.Stars = Convert.ToInt32(txt_Stars.Text);
                    hotel.RoomsCount = Convert.ToInt32(txt_RoomsCount.Text);
                    hotel.Photo = img;
                    db.Hotels.Add(hotel);

                    db.SaveChanges();
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelHotel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
