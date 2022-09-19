using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace air_api_test.Models
{
    public class AssetType
    {
        [Key]
        public string id { get; set; }

        public string description { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public string label { get; set; }

        public string disabled { get; set; }

        public string Type { get; set; }
    }
}
