using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment2
{
        public class Conversion
    {
        private int ConversionNumber;
        private double GetConvertedResult;

        public Conversion()
        {
            this.ConversionNumber = 1;
        }

        public Conversion(int ConversionNumber)
        {
            this.ConversionNumber = ConversionNumber;
        }

        public double ConvertCelciusToFahrenheit()
        {

            GetConvertedResult = ((ConversionNumber * 9) / 5) + 32;
            return GetConvertedResult;
        }

        public double ConvertCelciusToKelvin()
        {

            GetConvertedResult = (ConversionNumber + 273.15);
            return GetConvertedResult;
        }


        public double ConvertKelvinToFahrenheit()
        {
            GetConvertedResult = ((ConversionNumber - 273.15) * 1.8 + 32);
            return GetConvertedResult;
        }

        public double ConvertKelvinToCelcuis()
        {

            GetConvertedResult = (ConversionNumber - 273.15);
            return GetConvertedResult;
        }


        public double ConvertFahrenheitToKelvin()
        {

            GetConvertedResult = ((ConversionNumber - 32) / 1.8) + 273.15;
            return GetConvertedResult;
        }

        public double ConvertFahrenheitToCelcius()
        {

            GetConvertedResult = ((ConversionNumber - 32) / 9) * 5;
            return GetConvertedResult;
        }

    }

}
