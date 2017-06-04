namespace Hotel_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rooms
    {
        public Rooms()
        {
            OrdersToReservations = new HashSet<OrdersToReservations>();
        }

        public int Id { get; set; }

        public int Number { get; set; }
        public int? Count { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public bool IsBlocked { get; set; }

        public int RoomTypesID { get; set; }

        public int HotelsID { get; set; }

        public virtual Hotels Hotels { get; set; }

        public virtual ICollection<OrdersToReservations> OrdersToReservations { get; set; }

        public virtual RoomTypes RoomTypes { get; set; }
    }
}
