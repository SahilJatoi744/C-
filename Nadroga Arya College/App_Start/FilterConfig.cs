﻿using System.Web;
using System.Web.Mvc;

namespace Nadroga_Arya_College
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
