
/// <summary>
/// Filename: UintTypes.cs
/// Created on: 2024-02-18 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using System.ComponentModel;

namespace Assignment3.Enumerators
{
    #region Enums
    /// <summary>
    /// Unit types
    /// </summary>
    internal enum UnitTypes
    {
        Metric,
        Imperial
    }
    #endregion
    #region Classes
    internal static class Metric
    {
        /// <summary>
        /// Metric length units
        /// </summary>
        internal enum Length
        {
            [Description("m")]
            Meters,
            [Description("cm")]
            Centimeters,
            [Description("mm")]
            Millimeters
        }

        /// <summary>
        /// Metric weight units
        /// </summary>
        internal enum Weight
        {
            [Description("kg")]
            Kilograms,
            [Description("g")]
            Grams
        }
    }

    internal static class Imperial
    {
        /// <summary>
        /// US length units
        /// </summary>
        internal enum Length
        {
            [Description("ft")]
            Feet,
            [Description("in")]
            Inches
        }

        /// <summary>
        /// US weight units
        /// </summary>
        internal enum Weight
        {
            [Description("lbs")]
            Pounds
        }
    }
    #endregion
}
