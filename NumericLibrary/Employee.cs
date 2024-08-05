using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary
{
    public class Employee
    {
        public string GetLeaves(string dept, int exp)
        {
            if ((dept.Equals("HR") || dept.Equals("Accts")) && exp > 10)
                return "Max 10 Leaves allowed";
            else if ((dept.Equals("HR") || dept.Equals("Accts")) && exp <= 10)
                return "Only 6 Leaves allowed";
            else if (dept.Equals("IT")) return "No Leaves";
            else
                return null;
        }

        }
    }
