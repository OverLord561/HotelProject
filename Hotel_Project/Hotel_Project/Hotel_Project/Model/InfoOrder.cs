using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project.Model
{
   public class InfoOrder
    {
       public  string HotelName { get;set; }
       public int RoomNum { get;set; }
        public DateTime DateStartOrd { get;set; }
        public DateTime DateEndOrd { get;set; }
    }
}
