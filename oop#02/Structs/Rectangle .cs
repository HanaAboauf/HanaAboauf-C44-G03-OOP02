using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_02.Structs
{
    internal struct Rectangle
    {
        #region attributes
		
        private double width;
        private double height;
        #endregion

        #region Properties

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("The width must be positive"); ;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    Console.WriteLine("The height must be positive");
            }
        }

        public double Area
        {
            get { return width * height; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Width: {width}, Height: {height}, Area: {Area}";
        }
        #endregion

    }
}
