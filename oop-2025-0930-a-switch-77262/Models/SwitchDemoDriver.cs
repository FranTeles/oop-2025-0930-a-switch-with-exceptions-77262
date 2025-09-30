using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_0930_a_switch_77262.Models
{
    internal class SwitchDemoDriver
    {
        public static void Run()
        {
            Console.WriteLine("Switch Demo");
            NestedIfDemo();
            SequentialIfDemo();
            SwitchDemo();


        }

        public static void NestedIfDemo()
        {
            Console.WriteLine("Nested If Demo");
            int number = 3;
            if (number == 1)
            {
                Console.WriteLine("One");
            }
            else if (number == 2)
            {
                Console.WriteLine("Two");
            }
            else if (number == 3)
            {
                Console.WriteLine("Three");
            }
            else
            {
                Console.WriteLine("Other");
            }
        }

        public static void SequentialIfDemo()
        {
            Console.WriteLine("SequentialIfDemo");
            int number = 3;
            if (number == 1)
            {
                Console.WriteLine("One");
            }
            if (number == 2)
            {
                Console.WriteLine("Two");
            }
            if (number == 3)
            {
                Console.WriteLine("Three");
            }

        }

        public static void SwitchDemo()
        {
            Console.WriteLine("Switch Demo");
            int number = 3;
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

        }

        public static void SwithExpressionDemo()
        {
            Console.WriteLine("Switch Expression Demo");
            int number = 3;
            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other",
            };
            Console.WriteLine(result);
        }

        public static void DayOfWeek()
        { 
            Console.WriteLine("DayOfWeek Demo");
            int dayNumber = 3; //Example: 3 means Wednesday

            string dayName = dayNumber switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Invalid day", // default case
            };
            Console.WriteLine(dayName);
        }

    }
}
