using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginSys.Models
{
    public enum Gender { Male, Female }

    public class Employees
    {
        [Key]
        public int EmpID { get; set; }
        public int EmpNumber { get; set; }
        public Gender EmpGener { get; set; }
        public string Designation { get; set; }

        public string EmpFName { get; set; }
        public string EmpLName { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }


        public int IsActive { get; set; }


        public virtual ICollection<EmpBranch> EmpBranch { get; set; }
        public virtual ICollection<EmpRole> EmpRoles { get; set; }
    }
}