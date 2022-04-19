using System;
using System.Collections.Generic;
using System.Text;

namespace _20aprel_task_.Data.Entities
{
    internal class Stadion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal HourPrice { get; set; }
        public int Capacity { get; set; }
    }
}
