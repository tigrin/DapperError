using System;
using System.Data.SqlClient;
using Dapper;

namespace StandardDll
{
    public static class Class1
    {
        public static string GetName()
        {
            SqlConnection conn = new SqlConnection("blank.  Not needed to demonstrate the problem");
            DateTime d = conn.QuerySingle<DateTime>("select getDate()");


            return d.ToLongDateString();
        }
    }
}
