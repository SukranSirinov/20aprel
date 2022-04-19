using System;
using System.Collections.Generic;
using System.Text;

namespace _20aprel_task_.Data.Entities
{
    internal class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StadionId { get; set; }
        public Stadion Stadion { get; set; }    
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
