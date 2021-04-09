using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Room : BaseEntity
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public string RoomType { get; set; }
        public float PriceForBedAdult  { get; set; }
        public float PriceForBedChild { get; set; }
        public bool IsFree { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
