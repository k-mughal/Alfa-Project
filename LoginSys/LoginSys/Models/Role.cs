using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginSys.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string Profile { get; set; }

        public virtual ICollection<EmpBranch> EmpBranch { get; set; }

    }
}