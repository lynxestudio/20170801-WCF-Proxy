using System;
using Examples.WCFGradeConverter.Service;

namespace Examples.WCFGradeConverter.Service
{
    public class GradeConverterImplementation : IGradeConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return 1.8 * (celsius) + 32;
        }

        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 0.555;
        }

        public double FahrenheitToKelvin(double fahrenheit)
        {
            return (fahrenheit - 32) * (5/9) + 273.15;
        }

        public double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        public double KelvinToFahrenheit(double kelvin)
        {
            return (kelvin - 273.15) * (9/5) + 32;
        }
    }
}