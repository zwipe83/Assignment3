using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class UserInput
    {
        public string ReadTextAsString(string text)
        {
            try
            {
                if (!string.IsNullOrEmpty(text))
                {
                    text = text.Trim();
                }
                else
                {
                    if (text == null)
                    {
                        throw new ArgumentNullException(nameof(text), "Name cannot be Null");
                    }
                    if (text == string.Empty)
                    {
                        throw new ArgumentException("Name can not be empty.", nameof(text));
                    }
                }
                return text;
            }
            catch (ArgumentNullException argumentNullException)
            {
                MessageBox.Show(argumentNullException.Message);
                return null;
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public double ReadTextAsDouble(string text)
        {
            try
            {
                if (!string.IsNullOrEmpty(text))
                {
                    text = text.Trim();
                }
                else
                {
                    if (text == null)
                    {
                        throw new ArgumentNullException(nameof(text), "Name cannot be Null");
                    }
                    if (text == string.Empty)
                    {
                        throw new ArgumentException("Value can not be empty.", nameof(text));
                    }
                }

                if(Double.TryParse(text, out double dbl))
                {
                    return dbl;
                }
                else
                {
                    throw new Exception("Double.TryParse() failed.");
                }
            }
            catch (ArgumentNullException argumentNullException)
            {
                MessageBox.Show(argumentNullException.Message);
                return 0.0;
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
                return 0.0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0.0;
            }
        }

        public void SaveName(BMICalculator bmi, string name)
        {
            bmi.Name = name;
        }
        public void SaveHeight(BMICalculator bmi, double height)
        {
            bmi.Height = height;
        }
        public void SaveWeight(BMICalculator bmi, double weight)
        {
            bmi.Weight = weight;
        }
        public void SaveUnit(BMICalculator bmi, UnitTypes unit)
        {
            bmi.Unit = unit;
        }
    }
}
