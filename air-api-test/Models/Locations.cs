using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace air_api_test.Models
{
    public class Locations
    {
        [Key]
        public int ID { get; set; }

        public string Parent { get; set; }

        public string SubParent { get; set; }

        public string Child { get; set; }
    }
}
