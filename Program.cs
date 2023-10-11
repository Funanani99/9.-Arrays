using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneWayAttribute way of creating a array
            int[] luckyNumbers = { 4, 5, 8, 9, };
            Console.WriteLine(luckyNumbers[0]);
            //if you wanna populate it later, the 5 its the size
            string[] friends = new string[5];
             friends[0] = "Funi";
            friends[1] = "John";
            friends[2] = "Peter";

            Console.WriteLine(friends[0]);
        }
    }
}
