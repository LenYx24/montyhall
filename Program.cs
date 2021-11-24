using System;
using System.Collections.Generic;
using System.Linq;

namespace montyhallpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int wins = 0;
            int range = 10000000;
            for (int i = 0; i < range; i++)
            {
                string[] doors = {"kecske","kecske","kecske"};
                switch (rnd.Next(1,4)){
                    case 1:{doors[0] = "auto"; break;}
                    case 2:{doors[1] = "auto"; break;}
                    case 3:{doors[2] = "auto"; break;}
                }
                int valasztas = rnd.Next(1,4);
                for (int j = 1; j <= 3; j++)
                    if(valasztas != j && doors[j-1] == "kecske") doors[j-1] = "null"; // A megmutatott ajtó kiesik
                for (int j = 1; j <= 3; j++)
                    if(valasztas != j && doors[j-1] != "null") valasztas = j;
                if(doors[valasztas-1] == "auto") wins++;
            }
            Console.WriteLine($"wins: {wins}, percent: {float.Parse(wins.ToString()) / range}");
        }
    }
}