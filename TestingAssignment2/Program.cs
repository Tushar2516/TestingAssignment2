using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program tp = new Program();
            tp.TestingAssignment();
            Console.ReadKey();
        }

        public void TestingAssignment()
        {
            string enterValue;
            int convertValue;
            do
            {
                Console.WriteLine("-----------------Start Conversion Testing-----------------------");
                Console.WriteLine("Enter Number Which You Want To Convert:");
                enterValue = Console.ReadLine();
            } while (!int.TryParse(enterValue, out convertValue) || (convertValue < 1));

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Choose Conversion Which You Want:");
            Console.WriteLine("1. Celcius to Fahrenheit.");
            Console.WriteLine("2. Celcius to Kelvin.");
            Console.WriteLine("3. Kelvin to Fahrenheit.");
            Console.WriteLine("4. Kelvin to Celcius.");
            Console.WriteLine("5. Fahrenheit to Kelvin.");
            Console.WriteLine("6. Fahrenheit to Celcius.");
            Console.WriteLine("7. Exit.");

            Console.WriteLine("-------------------------------------------------------------");

            int chooseOption;
            string userChoose = string.Empty;
            do
            {
                Console.WriteLine("Choose Between 1 To 7:");
                userChoose = Console.ReadLine();

            } while (!int.TryParse(userChoose, out chooseOption) || (chooseOption < 1) || (chooseOption > 7));

            Conversion conversion = new Conversion(convertValue);
            double result;
            switch (chooseOption)
            {
                case 1:

                    result = conversion.ConvertCelciusToFahrenheit();
                    Console.WriteLine(result);
                    break;

                case 2:
                    result = conversion.ConvertCelciusToKelvin();
                    Console.WriteLine(result);
                    break;

                case 3:
                    result = conversion.ConvertKelvinToFahrenheit();
                    Console.WriteLine(result);
                    break;
                case 4:

                    result = conversion.ConvertKelvinToCelcuis();
                    Console.WriteLine(result);
                    break;

                case 5:
                    result = conversion.ConvertFahrenheitToKelvin();
                    Console.WriteLine(result);
                    break;
                case 6:
                    result = conversion.ConvertFahrenheitToCelcius();
                    Console.WriteLine(result);
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Please Select Right Option. ");
                    break;
            }

        }
    }

}
