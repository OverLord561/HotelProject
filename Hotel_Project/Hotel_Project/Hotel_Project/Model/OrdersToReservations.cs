namespace Hotel_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrdersToReservations
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int RoomID { get; set; }

        public bool IsPayment { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public virtual Rooms Rooms { get; set; }

        public virtual Users Users { get; set; }
    }
}
