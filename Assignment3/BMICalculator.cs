using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BMICalculator
    {
        #region Fields
        private string? name = "No name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;
        #endregion

        #region Properties
        public string? Name { get { return name; } set { name = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public UnitTypes Unit { get { return unit; } set { unit = value; } }
        #endregion

        #region Methods
        #endregion

    }
}
