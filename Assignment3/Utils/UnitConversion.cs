
/// <summary>
/// Filename: UnitConversion.cs
/// Created on: 2024-02-24 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace Assignment3.Utils
{
    /// <summary>
    /// Unit conversion class
    /// </summary>
    internal static class UnitConversion
    {
        #region Fields
        /// <summary>
        /// Conversion delegate methods
        /// </summary>
        private static Func<double, double> _feetToInches = x => x * 12;
        private static Func<double, double> _inchesToFeet = x => x * 0.0833;
        private static Func<double, double> _inchesToCentimeters = x => x * 2.54;
        private static Func<double, double> _centimetersToMeters = x => x / 100;
        private static Func<double, double> _metersToCentimeters = x => x * 100;
        private static Func<double, double> _centimetersToFeet = x => x / 30.48;
        private static Func<double, double> _feetToCentimeters = x => x * 30.48;
        private static Func<double, double> _kilogramsToPounds = x => x / 0.45359237;
        private static Func<double, double> _poundsToKilograms = x => x * 0.45359237;
        #endregion
        #region Properties
        /// <summary>
        /// Convert feet to inches
        /// </summary>
        /// <returns>Converted feet(double) in inches as a double</returns>
        public static Func<double, double> FeetToInches
        {
            get { return _feetToInches; }
        }
        /// <summary>
        /// Convert inches to feet
        /// </summary>
        /// <returns>Converted inches(double) in feet as a double</returns>
        public static Func<double, double> InchesToFeet
        {
            get { return _inchesToFeet; }
        }
        /// <summary>
        /// Convert inches to centimeters
        /// </summary>
        /// <returns>Converted inches(double) in centimeters as a double</returns>
        public static Func<double, double> InchesToCentimeters
        {
            get { return _inchesToCentimeters; }
        }
        /// <summary>
        /// Convert centimeters to meters
        /// </summary>
        /// <returns>Converted centimeters(double) in meters as a double</returns>
        public static Func<double, double> CentimetersToMeters
        {
            get { return _centimetersToMeters; }
        }
        /// <summary>
        /// Convert meters to centimeters
        /// </summary>
        /// <returns>Converted meters(double) in centimeters as a double</returns>
        public static Func<double, double> MetersToCentimeters
        {
            get { return _metersToCentimeters; }
        }
        /// <summary>
        /// Convert centimeters to feet
        /// </summary>
        /// <returns>Converted centimeters(double) in feet as a double</returns>
        public static Func<double, double> CentimetersToFeet
        {
            get { return _centimetersToFeet; }
        }
        /// <summary>
        /// Convert kliograms to punds
        /// </summary>
        /// <returns>Converted kilograms(double) in pounds as a double</returns>
        public static Func<double, double> KilogramsToPounds
        {
            get { return _kilogramsToPounds; }
        }
        /// <summary>
        /// Convert feet to centimeters
        /// </summary>
        /// <returns>Converted feet(double) in centimeters as a double</returns>
        public static Func<double, double> FeetToCentimeters
        {
            get { return _feetToCentimeters; }
        }
        /// <summary>
        /// Convert pounds to kilograms
        /// </summary>
        /// <returns>Converted pounds(double) in kilograms as a double</returns>
        public static Func<double, double> PoundsToKilograms
        {
            get { return _poundsToKilograms; }
        }
        #endregion
    }
}
