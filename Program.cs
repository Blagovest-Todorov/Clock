using System;

namespace _1.hourMinutesClock
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hour = 0;   //0:0  --- > 23 
            //int minutes = 0; till 59 min -> change of hour

            for (int hour = 0; hour < 24; hour++)
            {
                //hour ++;
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    Console.WriteLine($"{hour}:{minutes}");
                }


            }
        }
    }
}
