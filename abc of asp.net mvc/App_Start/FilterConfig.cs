﻿using System.Web;
using System.Web.Mvc;

namespace abc_of_asp.net_mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}