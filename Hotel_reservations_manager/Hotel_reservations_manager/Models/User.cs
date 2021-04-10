using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Models
{
    public enum Role
    {
        User = 0,
        Admin = 1,
        HeadAdmin = 2
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PersonalID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
