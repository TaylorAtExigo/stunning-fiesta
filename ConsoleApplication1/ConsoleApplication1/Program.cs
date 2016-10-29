using ConsoleApplication1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputColor = "";
            string inputSize = "";
            int inputPsi = 0;
            
            while ( inputColor != "pop it")
            {
                try
                {
                    Console.WriteLine("Enter a color.");
                    inputColor = Console.ReadLine();

                    Console.WriteLine("Pick a size: Large, Medium, or Small?");
                    inputSize = Console.ReadLine();

                    Console.WriteLine("How much air does the balloon need? Enter a psi.");
                    inputPsi = int.Parse(Console.ReadLine());

                    Balloon inputBalloon = new Balloon(inputColor, inputSize, inputPsi);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
                
            }
        }
    }
}
