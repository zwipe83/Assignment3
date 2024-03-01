﻿using System.ComponentModel;

namespace Assignment3
{

    internal static class Activity
    {
        private static readonly Dictionary<ActivityLevel, double> _activityFactors = new Dictionary<ActivityLevel, double>
        {
            { ActivityLevel.Sedentary, 1.2 },
            { ActivityLevel.LightlyActive, 1.375 },
            { ActivityLevel.ModeratelyActive, 1.550 },
            { ActivityLevel.VeryActive, 1.725 },
            { ActivityLevel.ExtraActive, 1.9 }
        };

        public static Dictionary<ActivityLevel, double> ActivityFactors { get { return _activityFactors; } }

        internal enum ActivityLevel
        {
            [Description("Little or no exercise")]
            Sedentary,
            [Description("Exercise 1 to 3 times per week")]
            LightlyActive,
            [Description("Exercise 4 to 5 times per week")]
            ModeratelyActive,
            [Description("Exercise 6 to 7 times per week")]
            VeryActive,
            [Description("Hard exercise or physical job")]
            ExtraActive
        }

        public static double GetActivityFactor(ActivityLevel activityLevel)
        {
            return ActivityFactors[activityLevel];
        }
    }
}
