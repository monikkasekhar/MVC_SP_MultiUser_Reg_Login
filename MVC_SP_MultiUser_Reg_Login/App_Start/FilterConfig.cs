﻿using System.Web;
using System.Web.Mvc;

namespace MVC_SP_MultiUser_Reg_Login
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
