using System;
using System.Collections.Generic;
using System.Globalization;

namespace CustomOrderBy.WithIComparer
{
    public class EmployeeAscendingHierachicalComparer : IComparer<Employee>
    {
        /// <summary>
        /// This Comparer receive 2 params to compare their codes
        /// 1st: i get the 1st level of hierarchy
        /// 2nd: get the other level's and remove '.'
        /// 3rd: concat with 1st level and ',' 
        /// finally: cast to decimal and compare if is bigger or less than
        /// 
        /// note: In this approach i can do the ascending order with less.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Employee x, Employee y)
        {
            if (GetDecimal(x.Code) > GetDecimal(y.Code)) return 1;
            if (GetDecimal(x.Code) < GetDecimal(y.Code)) return -1;
            return 0;
        }

        public static decimal GetDecimal(string code)
        {
            var cleanCode = code.Replace(".", "").Trim();

            var str = cleanCode.Length > 1 ? cleanCode.Insert(1, ",") : cleanCode;
            return decimal.Parse(str, NumberStyles.AllowDecimalPoint);
        }
    }
}
