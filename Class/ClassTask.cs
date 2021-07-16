using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    class Rectangle
    {
        double sideA;
        double sideB;
        public Rectangle(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;
        }
        public Rectangle(double a)
        {
            this.sideA = a;
            this.sideB = 5;
        }
        public Rectangle()
        {
            this.sideA = 4;
            this.sideB = 3;
        }
        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        {
            return sideB;
        }
        public double Area()
        {
            return this.sideA * this.sideB;
        }
        public double Perimeter()
        {
            return 2 * (this.sideA + this.sideB);
        }
        public bool IsSquare()
        {
            if (this.sideA == this.sideB)
            {
                return true;
            }
            else return false;
        }
        public void ReplaceSides()
        {
            double bufer;
            bufer = this.sideA;
            this.sideA = this.sideB;
            this.sideB = bufer;
        }
    }
    class ArrayRectangles
    {
        private Rectangle[] rectangle_array;
        private IEnumerable<Rectangle> rectangles;
        public ArrayRectangles(IEnumerable<Rectangle> rectangles)
        {
            this.rectangles = rectangles;
        }
        public ArrayRectangles(int n)
        {
            this.rectangle_array = new Rectangle[n];
        }
        public ArrayRectangles(params Rectangle[] array)
        {
            this.rectangle_array = array;
        }
        public bool AddRectangle(Rectangle item)
        {
            if (item == null)
            {
                return false;
            }
            for (int i = 0; i < this.rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = item;
                    return true;
                }
            }
            return false;
        }
        public int NumberMaxArea()
        {
            int MaxAreaNumber = 0;
            double MaxArea = 0;
            for (int i = 0; i < this.rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Area() > MaxArea)
                {
                    MaxArea = rectangle_array[i].Area();
                    MaxAreaNumber = i;
                }
            }
            return MaxAreaNumber;
        }
        public int NumberMinPerimeter()
        {
            int MinPerimetrNumber = 0;
            double MinPerimetr = double.MaxValue;
            for (int i = 0; i < this.rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Perimeter() < MinPerimetr)
                {
                    MinPerimetr = rectangle_array[i].Perimeter();
                    MinPerimetrNumber = i;
                }
            }
            return MinPerimetrNumber;
        }
        public int NumberSquare()
        {
            try
            {
                var count = this.rectangle_array.Where(item => item.IsSquare() == true);
                return count.Count();
            }
            catch (ArgumentOutOfRangeException)
            {
                return 0;
                throw;
            }
        }
    }
}
    
