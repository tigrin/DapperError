using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data.SqlClient;

namespace CoreWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name1 = StandardDll.Class1.GetName();
            string name2 = GetName();


            return View();
        }

        public static string GetName()
        {
            SqlConnection conn = new SqlConnection("blank.  Not needed to demonstrate the problem");
            DateTime d = conn.QuerySingle<DateTime>("select getDate()");


            return d.ToLongDateString();
        }
    }
}
