using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace SiloUserModel
{
    [Table("boredApi")]
    public class BoredApi
    {

        [Key]
        public int Id { get; set; }

        public string Activity { get; set; }

        public string Type { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
