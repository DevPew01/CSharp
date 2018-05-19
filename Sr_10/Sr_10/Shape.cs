using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_10
{
    public abstract class Shape
    {
        public Shape(double R)
        {
            this.R = R;
        }

        public abstract double Area();

        public abstract double Perimetr();

        protected double R;
    }

    public class Circle : Shape
    {
        public Circle(double R): base(R)
        {
            this.R = R;
        }

        public override double Area()
        {
            const double Pi = 3.1415;
            double S = Pi * Math.Pow(R, 2);
            return S;
        }

        public override double Perimetr()
        {
            const double Pi = 3.1415;
            double P = 2 * (Pi * R);
            return P;
        }

        public override string ToString()
        {
            return $"Площадь: {Area()}(cm2)\nПериметр: {Perimetr()}(cm2)\n";
        }
    }

    public class Square : Shape
    {
        public Square(double R): base(R)
        {
            this.R = R;
        }

        public override double Area()
        {
            double S = Math.Pow(R, 4);
            return S;
        }

        public override double Perimetr()
        {
            double P = 4 * R;
            return P;
        }

        public override string ToString()
        {
            return $"Площадь: {Area()}(cm2)\nПериметр: {Perimetr()}(cm2)\n";
        }
    }

    public class Rectangle: Shape
    {
        public Rectangle(double R, double st2) : base(R)
        {
            this.R = R;
            this.st2 = st2;
        }
        private double st2;

        public override string ToString()
        {
            return $"Площадь: {Area()}(cm2)\nПериметр: {Perimetr()}(cm2)\n";
        }

        public override double Area()
        {
            double S = Math.Pow(R * st2, 2);
            return S;
        }

        public override double Perimetr()
        {
            double P = R + R + st2 + st2;
            return P;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double R, double st2, double st3): base(R)
        {
            this.R = R;
            this.st2 = st2;
            this.st3 = st3;
        }
        private double st2, st3;

        public override string ToString()
        {
            return $"Площадь: {Area()}(cm2)\nПериметр: {Perimetr()}(cm2)\n";
        }

        public override double Area()
        {
            double S = R * st2 * st3;
            return S;
        }

        public override double Perimetr()
        {
            double P = R + st2 + st3;
            return P;
        }
    }

}
