using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Models.ViewModels
{
    public class RegisterModel
    {
        [DisplayName("User name")]
        [Required]
        public string Username { get; set; }
        [DisplayName("Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        [Required]
        public string MiddleName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("EGN")]
        [Required]
        public string PersonalID { get; set; }
        [DisplayName("Phone number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }
        [DisplayName("Administrator rights")]
        [Required]
        public bool IsAdmin { get; set; }


        public bool RegisterUser()
        {
            var userRole = Role.User;
            var isActive = true;
            using (var context = new HotelContext())
            {
                if (!context.Users.Any())
                {
                    userRole = Role.HeadAdmin;
                }
                else if(this.IsAdmin)
                {
                    isActive = false;
                    userRole = Role.Admin;
                }

                var result = context.Users.Add(new User() { 
                    Username = this.Username,
                    Password = this.Password,
                    FirstName = this.FirstName,
                    MiddleName = this.MiddleName,
                    LastName = this.LastName,
                    PersonalID = this.PersonalID,
                    PhoneNumber = this.PhoneNumber,
                    Email = this.Email,
                    Active = isActive,
                    Role = userRole
                });

                context.SaveChanges();

                return true;
            }
        }
    }
}
