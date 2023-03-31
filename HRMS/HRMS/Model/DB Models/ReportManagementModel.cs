using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model.DB_Models
{
    public class ReportManagementModel
    {
        [DisplayName("Dept ID")]
        [Required(ErrorMessage = "This is a required field")]
        public int DeptID { get; set; }

        [DisplayName("Management Report")]
        [Required(ErrorMessage = "This is a required field")]
        public string ManagementReport { get; set; }

        [DisplayName("Date Posted")]
        [Required(ErrorMessage = "This is a required field")]
        public DateTime DatePosted { get; set; }

    }
}

