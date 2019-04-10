using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace InsertUpdateDeleteSearch
{
    class Commons
    {
        public static string GetConnectionString
        {
            get
            {
                string str = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
                return str;
            }
        }
    }
}
