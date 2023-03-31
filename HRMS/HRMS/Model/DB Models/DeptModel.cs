using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Model
{
    public class DeptModel
    {
        [DisplayName("Job ID")]
        [Required(ErrorMessage = "This is a required field")]
        public int jobID { get; set; }


        [DisplayName("Department")]
        [Required(ErrorMessage = "This is a required field")]
        public string deptName { get; set; }


        [DisplayName("Access Rights")]
        [Required(ErrorMessage = "This is a required field")]
        public int accessRights { get; set; }


        [DisplayName("Position")]
        [Required(ErrorMessage = "This is a required field")]
        public string EmpPos { get; set; }


        [DisplayName("Job Level")]
        [Required(ErrorMessage = "This is a required field")]
        public int jobLvl { get; set; }


        [DisplayName("Job Position Document")]
        [Required(ErrorMessage = "This is a required field")]
        public string jobPosDoc { get; set; }
    }
}
