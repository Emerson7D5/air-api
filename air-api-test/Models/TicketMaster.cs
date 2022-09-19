using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace air_api_test.Models
{
    public class TicketMaster
    {
        public string Category { get; set; }

        public DateTime? Closed_Time { get; set; }

        public DateTime? Created_Time { get; set; }

        public string Department { get; set; }

        public string Description { get; set; }
        [Key]
        public string Ticket_Id { get; set; }

        public DateTime? Due_by_Time { get; set; }

        public string First_Response_Time__in_Hrs_ { get; set; }

        public string First_Response_Status { get; set; }

        public string Initial_Response_Time { get; set; }

        public string Group { get; set; }

        public string Impact { get; set; }

        public string Issue_type { get; set; }

        public string Item { get; set; }

        public string Location { get; set; }

        public string Priority { get; set; }

        public string Requester_Name { get; set; }

        public string Resolution_Status { get; set; }

        public string Resolution_Time__in_Hrs_ { get; set; }

        public DateTime? Resolved_Time { get; set; }

        public string Agent { get; set; }

        public string Source { get; set; }

        public string Status { get; set; }

        public string Subject { get; set; }

        public string Tags { get; set; }

        public string Type { get; set; }

        public DateTime? Time_Tracked { get; set; }

        public string Type_of_Request { get; set; }

        public DateTime? Last_Updated_Time { get; set; }

        public string Urgency { get; set; }

        public string Sub_Category { get; set; }

        public string display_id { get; set; }

        public string email_config_id { get; set; }

        public string isescalated { get; set; }

        public string item_category { get; set; }

        public string owner_id { get; set; }

        public string requester_id { get; set; }

        public string responder_id { get; set; }

        public string spam { get; set; }

        public string to_email { get; set; }

        public string trained { get; set; }

        public string status_name { get; set; }

        public string priority_name { get; set; }

        public string source_name { get; set; }

        public string requester_status_name { get; set; }

        public string to_emails { get; set; }

        public string assoc_change_id { get; set; }

        public string assoc_problem_id { get; set; }

        public string assoc_change_cause_id { get; set; }

        public string fr_escalated { get; set; }

        public string assoc_asset_id { get; set; }

        public DateTime? Start_Time { get; set; }

        public DateTime? End_Time { get; set; }

        public long? stats_ticket_id { get; set; }

        public DateTime? stats_resolved_at { get; set; }

        public DateTime? stats_closed_at { get; set; }

        public DateTime? stats_first_assigned_at { get; set; }

        public DateTime? stats_assigned_at { get; set; }

        public DateTime? stats_created_at { get; set; }

        public DateTime? stats_updated_at { get; set; }

        public bool? stats_group_escalated { get; set; }

        public int? stats_inbound_count { get; set; }

        public DateTime? stats_status_updated_at { get; set; }

        public int? stats_outbound_count { get; set; }

        public int? PageNumber { get; set; }

        public string issue_type_188548 { get; set; }

        public string Requester_Name_Old { get; set; }

        public DateTime? operation_report_date { get; set; }

        public string requester_shift { get; set; }

        public long? resolution_time_in_secs { get; set; }

        public string country { get; set; }

        public string business_unit { get; set; }

        [NotMapped]
        public virtual List<Assets> Assets { get; set; }
    }
}
