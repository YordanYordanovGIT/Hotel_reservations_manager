using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Models
{
    public enum RoomType
    {
        Single = 0,
        Double = 1,
        Triple = 2,
        Quad = 3,
        Queen = 4,
        Other = 5
    }
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public RoomType Type { get; set; }
        public bool IsFree { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
