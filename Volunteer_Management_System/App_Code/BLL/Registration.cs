using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volunteer_Management_System.App_Code.BLL
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public int VID { get; set; }
        public int ActivitieID { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationStatus { get; set; }
    }
}