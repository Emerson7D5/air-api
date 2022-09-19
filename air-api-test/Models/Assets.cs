using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace air_api_test.Models
{
    public class Assets
    {
        [Key]
        public string id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string ci_type_id { get; set; }

        public string impact { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public string user_id { get; set; }

        public string department_id { get; set; }

        public DateTime? assigned_on { get; set; }

        public string agent_id { get; set; }

        public string display_id { get; set; }

        public string location_id { get; set; }

        public string depreciation_id { get; set; }

        public string salvage { get; set; }

        public string usage_type { get; set; }

        public string asset_tag { get; set; }

        public string department_name { get; set; }

        public string used_by { get; set; }

        public string business_impact { get; set; }

        public string agent_name { get; set; }

        public string ci_type_name { get; set; }

        public string location_name { get; set; }

        public string product_name { get; set; }

        public string vendor_name { get; set; }

        public string state_name { get; set; }

        public string location_sub_parent { get; set; }

        public string location_parent { get; set; }

        public string location_parent_value { get; set; }

        public string location_subparent_value { get; set; }

        public string location_child_value { get; set; }

        public string location_operation_report { get; set; }

        public byte? operation_report_asset { get; set; }

        public bool? report_asset { get; set; }

        public bool? report_asset_bluefox { get; set; }

        public string country { get; set; }

        public string business_unit { get; set; }

        public DateTime? acquisition_date { get; set; }

        public DateTime? warranty_expiry_date { get; set; }

        public string broadcasting { get; set; }

        public string dms_type { get; set; }

        public string system { get; set; }

        public string parent_location { get; set; }

        [NotMapped]
        public virtual List<AssetType> AssetType { get; set; }
    }
}
