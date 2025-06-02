using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP4_reuseOOP2
{
    public static class YourUtils
    {
        public static int Tuoi (this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year;
        }
    }
}
