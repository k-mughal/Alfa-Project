using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoginSys.Models
{
    public class EmpRole
    {
        [Key]
        [Column(Order = 1)]
        public int EmpID { get; set; }



        [Key]
        [Column(Order = 2)]

        public int RoleID { get; set; }
        //public int ProfID { get; set; }


        public string UserName { get; set; }
        public string Password { get; set; }


        public virtual Employees Employees { get; set; }
        public virtual Role Role { get; set; }



    }
}