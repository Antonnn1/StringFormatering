﻿using System;
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

            /*
            //Övn 2
            double area = Math.PI * 4 * 4;
            Console.WriteLine(area.ToString("F4"));
            */

            /*
            //Övn 3
            int tal = 1000000000;
            Console.WriteLine("{0:0,0}", tal);
            */

            /*
            //Övn 4
            double value = 123.00;
            Console.WriteLine("Det blir {0} kr och {1:00} öre", value, 00);
            */

            /*
            //Övn 5
            Console.WriteLine("Mata in ditt person nummer: ");
            string pn = Console.ReadLine();
            decimal pndelat = decimal.Parse(pn);
            Console.WriteLine("{0:#### ## ##-####}", pndelat);
            */

            //Övn 6
            const string myForm = "{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-10}";
            Console.WriteLine("----------------------------Veckoschema------------------------");
            Console.WriteLine(String.Format(myForm, "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag"));
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine(String.Format(myForm, "Fysik", "Inbokat", "Matte", "Franska", "Matte"));
            Console.WriteLine(String.Format(myForm, "Matte", "Inbokat", "Teknik", "Matte", "Webb"));
            Console.WriteLine(String.Format(myForm, "Franska", "Inbokat", "Idrott", "Engelska", "Prog"));
            Console.WriteLine(String.Format(myForm, "", "", "Svenska", "Fysik", "Engelska"));
        }
    }
}
