using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int convZahl = 0;
            string inPutValue = "";

            // do while example 
            do
            {
                Console.Write("Bitte geben Sie eine Zahl ein ");
                inPutValue = Console.ReadLine();
            } while (!int.TryParse(inPutValue, out convZahl));

            // this is line is new 
            // call 
            MyParamFunc(inPutValue);
            // cw output with  $ symbol
            Console.WriteLine($"Sie haben die Zahl {convZahl} eingetragen");
            // alternatively cw output with {}
            Console.WriteLine("Sie haben die Zahl {0} eingetragen", convZahl);

            Console.Write("Bitte geben Sie einen Text ein ");
            inPutValue = Console.ReadLine();

            for (int i = 0; i < inPutValue.Length; i++)
            {
                Console.WriteLine($"An der Stelle {i} steht der Wert (Inhalt) {inPutValue[i]}");
            }
        }

        static int MyParamFunc(string value)
        {
            int convValue = Convert.ToInt32(value);
            if (convValue == 0)
            {
                Console.WriteLine("");
            }
            else if(convValue > 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }

            return 66;
        }
        static void MyEmptyFunc()
        {

        }
    }
}
