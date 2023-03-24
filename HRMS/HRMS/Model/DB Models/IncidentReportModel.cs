using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Model
{
    public class IncidentReportModel
    {
        [DisplayName("Incident ID")]
        [Required(ErrorMessage = "This is a required field")]
        public int IncidentID { get; set; }


        [DisplayName("Date of Incident")]
        [Required(ErrorMessage = "This is a required field")]
        public DateTime DateOccurred { get; set; }


        [DisplayName("Date Posted")]
        [Required(ErrorMessage = "This is a required field")]
        public DateTime DatePosted { get; set; }


        [DisplayName("Employees Involved (Last names only)")]
        [Required(ErrorMessage = "This is a required field")]
        public string EmployeesInvolved { get; set; }


        [DisplayName("Incident Type")]
        [Required(ErrorMessage = "This is a required field")]
        public string TypeOfIncident { get; set; }


        [DisplayName("Reported By")]
        [Required(ErrorMessage = "This is a required field")]
        public string ReportedBy { get; set; }


        [DisplayName("Reporter's ID")]
        [Required(ErrorMessage = "This is a required field")]
        public int ReportersID { get; set; }


        [DisplayName("Specifics")]
        [Required(ErrorMessage = "This is a required field")]
        public string Specifics { get; set; }


        [DisplayName("Instigator")]
        [Required(ErrorMessage = "This is a required field")]
        public string Instigator { get; set; }


        [DisplayName("Solution")]
        public string Solution { get; set; }


        [DisplayName("Penalty")]
        [Required(ErrorMessage = "This is a required field")]
        public string Penalty { get; set; }


        [DisplayName("Remarks")]
        public string Remarks { get; set; }


    }
}
