using System;

namespace SiloApplication.Models
{
    public class Lambda
    {
        public int Id { get; set; }
        public decimal? LiquidLevel { get; set; }
        public decimal? Pressure { get; set; }
        public int Temperature { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
