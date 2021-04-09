using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Reservation : BaseEntity
    {
        public int ReservationId { get; set; }
        public int RoomNumber { get; set; }
        public virtual Room numberRoom { get; set; }
        public int UserId { get; set; }
        public virtual User idUser { get; set; }
        public string RoomType { get; set; }
        public DateTime DateOfAccomodation { get; set; }
        public DateTime DateOfRelease { get; set; }
        public bool BreakfastIncluded  { get; set; }
        public bool AllInclusive { get; set; }
        public float PaymentAmount { get; set; }
    }
}
