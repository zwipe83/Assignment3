
/// <summary>
/// Filename: EnumUtils.cs
/// Created on: 2024-02-24 00:00:00
/// Author: Samuel Jeffman
/// </summary>

using System.ComponentModel;
using System.Reflection;

namespace Assignment3.Utils
{
    /// <summary>
    /// Class for doing operations on Enums. For example getting an enum description.
    /// </summary>
    internal class EnumUtils
    {
        #region Methods
        /// <summary>
        /// Get description from provided enum value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(Enum value)
        {
            FieldInfo? fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute? attribute = fi?.GetCustomAttribute<DescriptionAttribute>();

            return attribute?.Description ?? value.ToString(); //Null check, return input value
        }
        #endregion
    }
}
