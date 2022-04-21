using System;
using System.Collections.Generic;

namespace StadiumTask2.Models
{
    public class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal HourlyPrice { get; set; }
        public byte Capacity { get; set; }
    }
}
