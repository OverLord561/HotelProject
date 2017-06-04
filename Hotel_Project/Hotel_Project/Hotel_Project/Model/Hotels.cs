namespace Hotel_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hotels
    {
        public Hotels()
        {
            Rooms = new HashSet<Rooms>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Description { get; set; }

        public int Stars { get; set; }

        public int RoomsCount { get; set; }

        public byte[] Photo { get; set; }

        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
