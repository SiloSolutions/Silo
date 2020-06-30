using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace SiloModel
{
    public class Data
    {
        public DateTime CreationDate { get; set; }

        public int LiquidLevel { get; set; }

        public float Pressure { get; set; }

        public int Temperature { get; set; }

    }
}
