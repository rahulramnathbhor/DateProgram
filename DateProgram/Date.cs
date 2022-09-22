using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProgram
{
    internal class Date1
    {
        int day, year;
        string month;

        public void AssignValue()
        {
            day = 14;
            month = "sep";
            year = 2022;
        }

        public string DisplayValue()
        {
            return $"Date is :{day} / {month} / {year}";
        }





    }
}
