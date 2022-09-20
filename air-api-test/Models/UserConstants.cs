using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace air_api_test.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel()
            {
                UserName = "admin_user",
                EmailAddress = "admin_user@nomail.com",
                Password = "MyPassword",
                GiveName = "Admin",
                SurName = "User",
                Role = "Administrator"
            },
            new UserModel()
            {
                UserName = "report_user",
                EmailAddress = "report_user@nomail.com",
                Password = "MyPassword",
                GiveName = "Report",
                SurName = "User",
                Role = "Reporting"
            }
        };
    }
}
