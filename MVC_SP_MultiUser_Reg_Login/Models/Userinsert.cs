using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_SP_MultiUser_Reg_Login.Models
{
    public class Userinsert
    {
        [Required(ErrorMessage ="Enter the Name")]
        public string name { set; get; } 
        public int age { set; get; }

        [Required(ErrorMessage ="Enter Address")]
        public string address { set; get; }
        public string email { set; get; }
        public string photo { set; get; }
        public string username { set; get; }
        public string pwd { set; get; }

        [Compare("pwd",ErrorMessage ="Password FOund Mismatch")]
        public string cpwd { set; get; }
        public string usermsg { set; get; }
    }
}