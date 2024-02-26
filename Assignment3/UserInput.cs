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
    }
}
