namespace Hotel_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomTypes
    {
        public RoomTypes()
        {
            Rooms = new HashSet<Rooms>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
