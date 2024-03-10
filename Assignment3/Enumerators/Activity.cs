
/// <summary>
/// Filename: Activity.cs
/// Created on: 2024-03-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using System.ComponentModel;

namespace Assignment3.Enumerators
{
    /// <summary>
    /// This class handles Activity level and activity factor.
    /// </summary>
    internal static class Activity
    {
        #region Fields
        private static readonly Dictionary<ActivityLevel, double> _activityFactors = new Dictionary<ActivityLevel, double>
        {
            { ActivityLevel.Sedentary, 1.2 },
            { ActivityLevel.LightlyActive, 1.375 },
            { ActivityLevel.ModeratelyActive, 1.550 },
            { ActivityLevel.VeryActive, 1.725 },
            { ActivityLevel.ExtraActive, 1.9 }
        };
        #endregion
        #region Properties
        /// <summary>
        /// Dictionary containing activity factors based on activity level
        /// </summary>
        public static Dictionary<ActivityLevel, double> ActivityFactors { get { return _activityFactors; } }
        #endregion
        #region Enums
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
        #endregion
        #region Methods
        /// <summary>
        /// Get activity factor based on provided activity level
        /// </summary>
        /// <param name="activityLevel"></param>
        /// <returns>Activity factor as a double</returns>
        public static double GetActivityFactor(ActivityLevel activityLevel)
        {
            return ActivityFactors[activityLevel];
        }
        #endregion
    }
}
