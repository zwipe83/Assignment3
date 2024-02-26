using System.ComponentModel;

namespace Assignment3
{
    /// <summary>
    /// Enumerate weight categories
    /// </summary>
    internal enum WeightCategories
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
}
