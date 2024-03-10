
/// <summary>
/// Filename: BMRCalculator.cs
/// Created on: 2024-02-26 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using Assignment3.Enumerators;
using Assignment3.Utils;
using static Assignment3.Enumerators.Activity;

namespace Assignment3.Calculators
{
    /// <summary>
    /// This class handles BMR calculations. The class inherits from BMICalculator. Private fields are accesible via Properties.
    /// </summary>
    internal class BMRCalculator : BMICalculator
    {
        #region Fields
        private int _age;
        private double _bmr;
        private double _caloriesToMaintainWeight;
        private Gender _gender;
        private ActivityLevel _activityLevel;
        private readonly int femaleOffset = -161;
        private readonly int maleOffset = 5;
        #endregion
        #region Properties
        public int Age { get { return _age; } set { _age = value; } }
        public double Bmr { get { return _bmr; } set { _bmr = value; } }
        public double CaloriesToMaintainWeight { get { return _caloriesToMaintainWeight; } set { _caloriesToMaintainWeight = value; } }
        public Gender Gender { get { return _gender; } set { _gender = value; } }
        public ActivityLevel ActivityLevel { get { return _activityLevel; } set { _activityLevel = value; } }

        #endregion
        #region Constructors
        public BMRCalculator() { }
        #endregion
        #region Methods
        /// <summary>
        /// Calculate BMR for current user
        /// </summary>
        public void CalculateBmr()
        {
            double weight = GetWeight();
            double height = GetHeight();
            if (GetUnit() == UnitTypes.Imperial)
            {
                weight = UnitConversion.PoundsToKilograms(weight);
                height = UnitConversion.FeetToCentimeters(height);
            }
            Bmr = 10 * weight + 6.25 * height - 5 * Age + (Gender == Gender.Female ? femaleOffset : maleOffset);
        }
        /// <summary>
        /// Calculate Calories to maintain weight based on current users activitylevel
        /// </summary>
        public void CalculateCaloriesToMaintainWeight()
        {
            CaloriesToMaintainWeight = Bmr * GetActivityFactor(ActivityLevel);
        }

        /// <summary>
        /// Calculate Calories to change weight based on current users activitylevel
        /// </summary>
        public double CalculateCaloriesToChangeWeight(double weightChangePerWeek)
        {
            return CaloriesToMaintainWeight + weightChangePerWeek;
        }
        #endregion
    }
}
