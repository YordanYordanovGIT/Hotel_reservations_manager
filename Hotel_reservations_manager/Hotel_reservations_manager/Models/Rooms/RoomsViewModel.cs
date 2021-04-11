using Hotel_reservations_manager.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Models.Rooms
{
    public class RoomsViewModel
    {
        public PagerViewModel Pager { get; set; }
        public ICollection<Room> Items { get; set; }
        public bool IsAdmin { get; set; }
    }
}
