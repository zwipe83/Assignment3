using System.ComponentModel;
using System.Reflection;

namespace Assignment3
{
    internal class EnumUtils
    {
        #region Methods
        /// <summary>
        /// TODO: Can this be simplified further?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute? attribute = fi?.GetCustomAttribute<DescriptionAttribute>();

            return attribute?.Description ?? value.ToString(); //Null check, return input value
        }
        #endregion
    }
}
