using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SP_MultiUser_Reg_Login.Models;

namespace MVC_SP_MultiUser_Reg_Login.Controllers
{
    public class AdminRegController : Controller
    {
        MVC_New_DBEntities dbobj = new MVC_New_DBEntities();
        // GET: AdminReg
        public ActionResult Insertadmin_Pageload()
        {
            return View();
        }
        public ActionResult Insertadmin_click(Admininsert clsobj)
        {
            if(ModelState.IsValid)
            {
                var getmaxid = dbobj.sp_MaxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if(mid==0)
                {
                    regid = 1;

                }
                else
                {
                    regid = mid + 1;
                }
                //get
                dbobj.sp_adminReg(regid,clsobj.name,clsobj.address,clsobj.phone,clsobj.email);
                dbobj.sp_logininsert(regid,clsobj.username,clsobj.pass,"admin");
                clsobj.adminmsg = "Successfully Inserted";
                return View("Insertadmin_Pageload", clsobj);
            }
            return View("Insertadmin_Pageload", clsobj);
        }
    }
}