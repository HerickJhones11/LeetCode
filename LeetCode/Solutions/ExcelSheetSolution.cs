using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class ExcelSheetSolution
    {
        public string ConvertToTitle(int columnNumber)
        {
            string result = "";
            while(columnNumber > 0)
            {
                columnNumber--;
                char c = (char)('As' + columnNumber % 26);
                result = c + result;
                columnNumber /= 26;
            }
            return result;
        }
        public void Run()
        {
            int columnNumber = 1;
            var res = ConvertToTitle(columnNumber);
            Console.WriteLine(res);
            columnNumber = 28;
            res = ConvertToTitle(columnNumber);
            Console.WriteLine(res);
            columnNumber = 701;
            res = ConvertToTitle(columnNumber);
            Console.WriteLine(res);
        }
    }
}
