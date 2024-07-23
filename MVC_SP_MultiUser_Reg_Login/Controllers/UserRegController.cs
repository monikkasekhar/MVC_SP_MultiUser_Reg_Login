using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SP_MultiUser_Reg_Login.Models;

namespace MVC_SP_MultiUser_Reg_Login.Controllers
{
    public class UserRegController : Controller
    {
        MVC_New_DBEntities dbobj = new MVC_New_DBEntities();
        // GET: UserReg
        public ActionResult Insertuser_Pageload()
        {
            return View();
        }

        public ActionResult InsertUser_Click(Userinsert clsobj,HttpPostedFileBase file)
        {
            if(ModelState.IsValid)
            {
                if(file.ContentLength>0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/PHS");
                    string pa = Path.Combine(s,fname);
                    file.SaveAs(pa);


                    var fullpath = Path.Combine("~\\PHS",fname);
                    clsobj.photo = fullpath;

                }

                var getmaxid = dbobj.sp_MaxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if (mid == 0)
                {
                    regid = 1;

                }
                else
                {
                    regid = mid + 1;
                }
                //get
                dbobj.sp_userReg(regid, clsobj.name, clsobj.age, clsobj.address, clsobj.email,clsobj.photo);
                dbobj.sp_logininsert(regid, clsobj.username, clsobj.pwd, "User");
                clsobj.username = "Successfully Inserted";
                return View("Insertuser_Pageload", clsobj);
            }
            return View("Insertuser_Pageload", clsobj);
        }

        
    }
}