using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace air_api_test.Models
{
    public class Requesters
    {
        public bool? active { get; set; }

        public bool? can_see_all_tickets_from_associated_departments { get; set; }

        public DateTime? created_at { get; set; }

        public string country { get; set; }

        public string business_unit { get; set; }

        public string first_name { get; set; }

        public bool? has_logged_in { get; set; }
        [Key]
        public long? id { get; set; }

        public bool? is_agent { get; set; }

        public string job_title { get; set; }

        public string language { get; set; }

        public string last_name { get; set; }

        public long? location_id { get; set; }

        public string mobile_phone_number { get; set; }

        public string primary_email { get; set; }

        public long? reporting_manager_id { get; set; }

        public string time_format { get; set; }

        public string time_zone { get; set; }

        public DateTime? updated_at { get; set; }

        public bool? vip_user { get; set; }

        public string work_phone_number { get; set; }

    }
}
