using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatering
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övn 1
            DateTime dt = new DateTime(2016, 10, 7);
            Console.WriteLine(dt.ToString("d"));
            */

            //Övn 2
            double area = Math.PI * 4 * 4;
            Console.WriteLine(area.ToString("F4"));


        }
    }
}
