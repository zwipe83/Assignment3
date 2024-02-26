﻿namespace Assignment3
{
    internal static class UnitConversion
    {
        #region Delegates
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
        public static Func<double, double> FeetToInches
        {
            get { return _feetToInches; }
        }
        public static Func<double, double> InchesToFeet
        {
            get { return _inchesToFeet; }
        }
        public static Func<double, double> InchesToCentimeters
        {
            get { return _inchesToCentimeters; }
        }
        public static Func<double, double> CentimetersToMeters
        {
            get { return _centimetersToMeters; }
        }
        public static Func<double, double> MetersToCentimeters
        {
            get { return _metersToCentimeters; }
        }
        public static Func<double, double> CentimetersToFeet
        {
            get { return _centimetersToFeet; }
        }
        public static Func<double, double> KilogramsToPounds
        {
            get { return _kilogramsToPounds; }
        }
        public static Func<double, double> FeetToCentimeters
        {
            get { return _feetToCentimeters; }
        }
        public static Func<double, double> PoundsToKilograms
        {
            get { return _poundsToKilograms; }
        }
        #endregion
    }
}
