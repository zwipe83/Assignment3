using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
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
