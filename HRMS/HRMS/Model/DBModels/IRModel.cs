using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DBModels
{
    public class IRModel
    {
        [DisplayName("Incident ID")]
        [Required(ErrorMessage = "This is a required field")]
        public int IncidentID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "This is a required field")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This is a required field")]
        public string LastName { get; set; }
        [DisplayName("M.I.")]
        [Required(ErrorMessage = "This is a required field")]
        public string MiddleInitial { get; set; }

        [DisplayName("Department")]
        [Required(ErrorMessage = "This is a required field")]
        public string Department { get; set; }

        [DisplayName("Position")]
        [Required(ErrorMessage = "This is a required field")]
        public string Position { get; set; }

        [DisplayName("Date Posted")]
        [Required(ErrorMessage = "This is a required field")]
        public DateTime DatePosted { get; set; }


        [DisplayName("People Involved")]
        [Required(ErrorMessage = "This is a required field")]
        public string PeopleInvolved { get; set; }

        [DisplayName("Incident")]
        [Required(ErrorMessage = "This is a required field")]
        public string Incident { get; set; }

        [DisplayName("Approved By")]
        [Required(ErrorMessage = "This is a required field")]
        public string ApprovedBy { get; set; }

        [DisplayName("Remarks")]
        public string Remarks { get; set; }
    }
}
