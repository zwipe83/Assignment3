namespace Assignment3
{
    internal class UserInput
    {
        /// <summary>
        /// Read a text input and return it as a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReadTextAsString(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Input cannot be null or empty.");
                return null; // TODO: Should this really return null?
            }

            return text.Trim();
        }

        /// <summary>
        /// Read a text input and return it as a double
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public double ReadTextAsDouble(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Input cannot be null or empty.");
                return 0.0;
            }

            return double.TryParse(text.Trim(), out double dbl) ? dbl : 0.0;
        }

        /// <summary>
        /// Read a text input and return it as a double
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public decimal ReadTextAsDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Input cannot be null or empty.");
                return 0.0M;
            }

            return decimal.TryParse(text.Trim(), out decimal dec) ? dec : 0.0M;
        }

        /// <summary>
        /// Read a text input and return it as an int
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int ReadTextAsInt(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Input cannot be null or empty.");
                return 0;
            }

            return int.TryParse(text.Trim(), out int i) ? i : 0;
        }
    }
}
