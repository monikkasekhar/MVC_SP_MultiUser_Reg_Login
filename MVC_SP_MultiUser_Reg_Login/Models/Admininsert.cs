using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_SP_MultiUser_Reg_Login.Models
{
    public class Admininsert
    {
        [Required(ErrorMessage="Enter the name")]
        public string name { set; get; }


        [Required(ErrorMessage ="Enter the address")]
        public string address { set; get; }


       [Required(ErrorMessage ="Enter valid Phone Number")]
       [RegularExpression(@"^\d{10}$",ErrorMessage ="Enter valid number")]
        public string phone { set; get; }
        public string email { set; get; }
        public string username { set; get; }
        public string pass { set; get; }


        [Compare("pass",ErrorMessage ="Password mismatch")]
        public string cpassword { set; get; }
        public string adminmsg { set; get; }
    }
}