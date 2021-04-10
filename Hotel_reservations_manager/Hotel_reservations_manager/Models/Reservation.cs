using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int ClientId { get; set; }
        public virtual User Client { get; set; }
        public DateTime DateOfAccomodation { get; set; }
        public DateTime DateOfRelease { get; set; }
        public bool BreakfastIncluded { get; set; }
        public bool AllInclusive { get; set; }
        public float PaymentAmount { get; set; }
    }
}
