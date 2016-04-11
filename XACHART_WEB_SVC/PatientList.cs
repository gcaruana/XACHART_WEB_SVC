using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XACHART_WEB_SVC
{
    public class PatientList
    {
        public string PatientName { get; set; }
        public string MRN { get; set; }
        public string Visitid { get; set; }
        public string DOB { get; set; }
        public DateTime AdmitDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string VisitYpe { get; set; }

    }
}