using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Models.Rooms
{
    public class RoomsEditModel
    {
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public RoomType Type { get; set; }
        [Required]
        public bool IsFree { get; set; }
    }
}
