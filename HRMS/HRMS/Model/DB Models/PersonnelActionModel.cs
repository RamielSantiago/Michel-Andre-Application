using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DB_Models
{
    public class PersonnelActionModel
    {
        [DisplayName("Employee ID")]
        [Required(ErrorMessage = "This is a required field")]
        public int EmployeeID { get; set; }

        [DisplayName("Date of Adjustment")]
        [Required(ErrorMessage = "This is a required field")]
        public DateTime DateOfAdjustment { get; set; }

        [DisplayName("Personnel Action Report")]
        [Required(ErrorMessage = "This is a required field")]
        public string PersonnelActionReport { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "This is a required field")]
        public bool Status { get; set; }

    }
}

