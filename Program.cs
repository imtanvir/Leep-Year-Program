using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leep_Year_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            /*if (year % 400 == 0 || (Convert.ToString(year).Length != 4 && year % 4 == 0))*/
            if((year % 400 == 0 && year % 100 != 0) || (year % 100 != 0 && year % 4 == 0))
            {
                Console.WriteLine("Leep Year");
            }
            else
            {
                Console.WriteLine("Not a leep year");
            }
            {

            }
            Console.ReadLine();
        }
    }
}
