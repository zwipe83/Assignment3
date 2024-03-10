
/// <summary>
/// Filename: UserInput.cs
/// Created on: 2024-02-18 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace Assignment3.Utils
{
    /// <summary>
    /// This class handles user input and throws exceptions if input is not as expected.
    /// </summary>
    internal class UserInput
    {
        #region Methods
        /// <summary>
        /// Read a text input and return it as a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Returns the input text as a string</returns>
        public string ReadTextAsString(string text)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Input cannot be null or empty.");
                }

                return text.Trim();
            }
            catch (ArgumentException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Read a text input and return it as a double
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Returns the input text as a double</returns>
        public double ReadTextAsDouble(string text)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Input cannot be null or empty.");
                }

                return double.TryParse(text.Trim(), out double dbl) ? dbl : throw new FormatException("Input is not in a valid format for converting to double.");
            }
            catch (ArgumentException) { throw; }
            catch (FormatException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Read a text input and return it as a decimal
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Returns the input text as a decimal</returns>
        public decimal ReadTextAsDecimal(string text)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Input cannot be null or empty.");
                }

                return decimal.TryParse(text.Trim(), out decimal dec) ? dec : throw new FormatException("Input is not in a valid format for converting to decimal.");
            }
            catch (ArgumentException) { throw; }
            catch (FormatException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Read a text input and return it as an int
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Returns the input text as an integer</returns>
        public int ReadTextAsInt(string text)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Input cannot be null or empty.");
                }

                return int.TryParse(text.Trim(), out int _int) ? _int : throw new FormatException("Input is not in a valid format for converting to decimal.");
            }
            catch (ArgumentException) { throw; }
            catch (FormatException) { throw; }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
