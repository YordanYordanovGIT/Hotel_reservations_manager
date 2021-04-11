using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_reservations_manager.Models.Shared;

namespace Hotel_reservations_manager.Models.Admins
{
    public class AdminsViewModel
    {
        public PagerViewModel Pager { get; set; }
        public ICollection<User> Items { get; set; }
    }
}
