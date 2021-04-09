using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Ppassword { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PersonalId { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public bool Activity { get; set; }
        public DateTime DateOfDismissaL  { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
