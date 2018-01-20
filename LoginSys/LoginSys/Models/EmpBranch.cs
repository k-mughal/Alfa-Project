using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoginSys.Models
{
    public class EmpBranch
    {

      
        [Key]
        [Column(Order = 1)]
        public int BrID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int EmpID { get; set; }


        public int IsAuthorised { get; set; }

        public virtual Employees Employees { get; set; }
        public virtual Branch Branch { get; set; }

    }
}