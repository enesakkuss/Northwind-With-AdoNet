using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    internal static class DbSetting
    {
        public static string ConntectionString
        {
            get
            {
                return "Server=.;Database=Northwind;Integrated Security=true";
            }
        }
    }
}
