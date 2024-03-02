using static Assignment3.Activity;

namespace Assignment3
{
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
        public BMRCalculator()
        {/*
            SetHeight(194);
            SetWeight(98);
            Age = 40;
            Gender = Gender.Male;
            ActivityLevel = ActivityLevel.LightlyActive;

            Bmr = 10 * GetWeight() + 6.25 * GetHeight() - 5 * Age;*/
            double maintainWeightBMR = Bmr * GetActivityFactor(ActivityLevel);
            double lose500 = maintainWeightBMR - 500;
            double lose1000 = maintainWeightBMR - 1000;
            double add500 = maintainWeightBMR + 500;
            double add1000 = maintainWeightBMR + 1000;
            var dummy = 0;
        }
        #endregion
        #region Methods
        public void CalculateBmr()
        {
            double weight = GetWeight();
            double height = GetHeight();
            if (GetUnit() == UnitTypes.Imperial)
            {
                weight = UnitConversion.PoundsToKilograms(weight);
                height = UnitConversion.FeetToCentimeters(height);
            }
            Bmr = (10 * weight + 6.25 * height - 5 * Age) + ((Gender == Gender.Female) ? femaleOffset : maleOffset);
        }

        public void CalculateCaloriesToMaintainWeight()
        {
            CaloriesToMaintainWeight = Bmr * GetActivityFactor(ActivityLevel);
        }

        public double CalculateCaloriesToChangeWeight(double weightChangePerWeek)
        {
            return CaloriesToMaintainWeight + weightChangePerWeek;
        }
        #endregion
    }
}
