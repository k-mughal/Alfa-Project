using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginSys.Models
{
    public class Branch
    {
        [Key]
        public int BrID { get; set; }
        public string BrName { get; set; }

        public virtual ICollection<EmpBranch> BranchAllocation { get; set; }

    }
}