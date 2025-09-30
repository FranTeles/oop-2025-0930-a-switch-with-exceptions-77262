using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_0930_a_switch_77262.Models
{
    internal class ExceptionDemoDriver
    {
        public static void Run()
        {
            ExceptionDemo();
        }

        public static void ExceptionDemo()
        {
            string filePath = "this-file-does-not-exist.txt";
            try
            {
                string content = File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException\t caught:\t [ {ex.Message} ]");
            }
            finally
            {
                Console.WriteLine("This is the finally block. It always runs.");
            }

            Console.WriteLine("After the try-catch block");



        }
    }
}
