﻿using System.Web;
using System.Web.Mvc;

namespace _2.MetropoliaDbFirst {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
