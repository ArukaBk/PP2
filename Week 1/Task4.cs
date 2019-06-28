using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    public class Task4
    {

        private static string output = "";

        private static void print(string s)
        {
            output += s;
        }
        private static void println()
        {
            output += "\n";
        }

        public static string DrawStarTriangle(int n)
        {
            string s = "";
            for(int i = 0; i < n; i++)
            {
                s += "[*]";
                print(s);
                println();
            }
            return output;
        }
    }
}
