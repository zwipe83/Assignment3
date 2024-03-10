
/// <summary>
/// Filename: BMICalculator.cs
/// Created on: 2024-02-18 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using Assignment3.Enumerators;
using static Assignment3.Utils.UnitConversion;

namespace Assignment3.Calculators
{
    /// <summary>
    /// This class handles BMI calculations. Private fields are accesible via setters and getters.
    /// </summary>
    internal class BMICalculator
    {
        #region Fields
        private string? name = "No name";
        private double height = 0.0; //cm,ft
        private double weight = 0.0; //kg,lbs
        private UnitTypes unit;
        private double bmi = 0.0;
        private readonly double imperialConversionFactor = 703.0;
        private readonly double metricConversionFactor = 1.0;
        private WeightCategory weightCategory;
        private double[] normalWeight = [0.0, 0.0];

        internal enum WeightRange
        {
            lowWeight,
            highWeight
        }
        #endregion
        #region Setters and getters
        public void SetName(string value) { name = value; }
        public void SetHeight(double value) { height = value; }
        public void SetHeight(double value, double inches) { height = value + InchesToFeet(inches); } //Feet
        public void SetWeight(double value) { weight = value; }
        public void SetUnit(UnitTypes value) { unit = value; }
        public void SetCategory(WeightCategory value) { weightCategory = value; }
        public string GetName() { return name ?? ""; }
        public double GetHeight() { return height; }
        public double GetWeight() { return weight; }
        public UnitTypes GetUnit() { return unit; }
        public WeightCategory GetWeightCategory() { return weightCategory; }
        public double GetBmi() { return bmi; }
        public double[] GetNormalWeight() { return normalWeight; }
        #endregion
        #region Properties
        //Not used, implemented as setters and getters instead
        /*public string? Name { get { return name; } set { name = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public UnitTypes Unit { get { return unit; } set { unit = value; } }
        public double Bmi { get { return bmi; } }
        public WeightCategories WeightCategory { get { return weightCategory; } set { weightCategory = value; } }
        public double[] NormalWeight { get { return normalWeight; } set { normalWeight = value; } }*/
        #endregion
        #region Methods
        /// <summary>
        /// Calculates the Bmi for the current user
        /// </summary>
        /// <param name="unit"></param>
        /// <exception cref="NotImplementedException"></exception>
        internal void CalculateBMI(UnitTypes unit)
        {
            switch (unit)
            {
                case UnitTypes.Metric:
                    double heightMeters = CentimetersToMeters(height);
                    bmi = weight / (heightMeters * heightMeters);
                    break;
                case UnitTypes.Imperial:
                    double heightInches = FeetToInches(height);
                    bmi = imperialConversionFactor * weight / (heightInches * heightInches);
                    break;
                default:
                    break;
            }
            weightCategory = GetCategory();
        }

        /// <summary>
        /// Calculates normal weight range for current user
        /// </summary>
        /// <param name="unit"></param>
        internal void CalculateNormalWeight(UnitTypes unit)
        {
            switch (unit)
            {
                case UnitTypes.Metric:
                    normalWeight[(int)WeightRange.lowWeight] = Math.Pow(CentimetersToMeters(height), 2) / metricConversionFactor * 18.50;
                    normalWeight[(int)WeightRange.highWeight] = Math.Pow(CentimetersToMeters(height), 2) / metricConversionFactor * 24.90;
                    break;
                case UnitTypes.Imperial:
                    normalWeight[(int)WeightRange.lowWeight] = Math.Pow(FeetToInches(height), 2) / imperialConversionFactor * 18.50;
                    normalWeight[(int)WeightRange.highWeight] = Math.Pow(FeetToInches(height), 2) / imperialConversionFactor * 24.90;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Figure out which weight category current user falls under
        /// </summary>
        /// <returns></returns>
        private WeightCategory GetCategory()
        {
            if (bmi < 18.5)
            {
                return WeightCategory.UnderWeight;
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return WeightCategory.NormalWeight;
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                return WeightCategory.OverWeight;
            }
            else if (bmi >= 30.0 && bmi <= 34.9)
            {
                return WeightCategory.ObesityClassI;
            }
            else if (bmi >= 35.0 && bmi <= 39.9)
            {
                return WeightCategory.ObesityClassII;
            }
            else
            {
                return WeightCategory.ObesityClassIII;
            }
        }
        #endregion
    }
}
