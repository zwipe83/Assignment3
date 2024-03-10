
/// <summary>
/// Filename: WeightCategory.cs
/// Created on: 2024-03-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using System.ComponentModel;

namespace Assignment3.Enumerators
{
    #region Enums
    /// <summary>
    /// Enumerate weight categories
    /// </summary>
    internal enum WeightCategory
    {
        [Description("Underweight")]
        UnderWeight,
        [Description("Normal weight")]
        NormalWeight,
        [Description("Overweight (Pre-obesity)")]
        OverWeight,
        [Description("Overweight (Obesity class I)")]
        ObesityClassI,
        [Description("Overweight (Obesity class II)")]
        ObesityClassII,
        [Description("Overweight (Obesity class III)")]
        ObesityClassIII
    }
    #endregion
}
