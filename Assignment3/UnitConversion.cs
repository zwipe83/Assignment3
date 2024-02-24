using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class UnitConversion
    {
        public double Convert(double amount, Func<double, double> conversion)
        {
            return conversion(amount);
        }

        // Example usage:
        //var celsiusToFahrenheit = Converter.Convert(11M, Converter.CelsiusToFahrenheit);
        //var fahrenheitToCelsius = Converter.Convert(11M, Converter.FahrenheitToCelsius);
    }

    public static class Converter
    {
        public static Func<double, double> FeetToInches = x => x * 12;
        public static Func<double, double> InchesToFeet = x => x * 0.0833;
        public static Func<double, double> CentimetersToMeters = x => x / 100;
        public static Func<double, double> MetersToCentimeters = x => x * 100;
    }
}
