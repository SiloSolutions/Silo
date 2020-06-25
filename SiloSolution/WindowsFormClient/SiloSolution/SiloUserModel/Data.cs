using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace SiloUserModel
{
    public class Data
    {
        public DateTime CreationDate { get; set; }

        public double LiquidLevel { get; set; }

        public double Pressure { get; set; }

        public int Temperature { get; set; }

    }
}
