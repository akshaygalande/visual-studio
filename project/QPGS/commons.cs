using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace QPGS
{
    class commons
    {
        public static string GetConnectionString
        {
            get
            {
                string str = ConfigurationManager.ConnectionStrings["DQPGS"].ConnectionString;
                return str;

            }
        }
    }
}
