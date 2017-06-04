namespace Hotel_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public Users()
        {
           OrdersToReservations = new HashSet<OrdersToReservations>();
        }

        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [StringLength(2)]
        public string PassportSeria { get; set; }

        [Required]
        [StringLength(100)]
        public string PassportNum { get; set; }

        [Required]
        [StringLength(11)]
        public string Phone { get; set; }

       public virtual ICollection<OrdersToReservations> OrdersToReservations { get; set; }
    }
}
