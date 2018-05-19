using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_6
{
    class Complex
    {
        public Complex(double real, double imagine)
        {
            this.real = real;
            this.imagine = imagine;
        }

        public double real { get; set; }
        public double imagine { get; set; }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $" Complex: {real} + {imagine}i";
        }

        public static bool operator !=(Complex num, Complex num1)
        {
            return (num.real != num1.real && num.imagine != num1.imagine) ? true : false;
        }

        public static bool operator==(Complex num, Complex num1)
        {
            return (num.real == num1.real && num.imagine == num1.imagine) ? true : false;
        }

        public static Complex operator +(Complex num, Complex num1)
        {
            return new Complex(num.real + num1.real, num.imagine + num1.imagine);
        }

        public static Complex operator -(Complex num, Complex num1)
        {
            return new Complex(num.real - num1.real, num.imagine - num1.imagine);
        }

        public static Complex operator -(int num, Complex num1)
        {
            return new Complex(num - num1.real, num - num1.imagine);
        }

        public static Complex operator -(Complex num1, int num)
        {
            return new Complex(num1.real - num, num1.imagine - num);
        }

        public static Complex operator *(Complex num, Complex num1)
        {
            return new Complex(num.real * num1.real, num.imagine * num1.imagine);
        }

        public static Complex operator *(int num, Complex num1)
        {
            return new Complex(num * num1.real, num * num1.imagine);
        }

        public static Complex operator /(Complex num, Complex num1)
        {
            double Denominator = num1.real * num.real + num1.imagine * num1.imagine;
            return new Complex((num.real * num1.real + num.imagine * num1.imagine) / Denominator,
                (num1.real * num.imagine - num1.imagine * num.real) / Denominator);
        }

        public static Complex operator /(Complex num, double num2)
        {
            return new Complex(num.real / num2, num.imagine / num2);
        }

        public static Complex operator /(double num, Complex num1)
        {
            double Denominator = num1.real * num1.real + num1.imagine * num1.imagine;
            return new Complex((num * num1.real) / Denominator, (-num1.imagine * num) / Denominator);
        }
    }
}
