using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_8_
{
    class Fraction
    {
        public int Num { set; get; }
        public int Znam { set; get; }

        public Fraction()
        {
            this.Num = 0;
            this.Znam = 0;
        }

        public Fraction(int num, int znam)
        {
            this.Num = num;
            this.Znam = znam;
        }

        public override string ToString()
        {
            return $"{Num} / {Znam}";
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public static Fraction operator +(Fraction fract1, Fraction fract2)
        {
            if (fract1.Znam > 0 && fract2.Znam > 0)
            {
                return new Fraction(fract1.Num * fract2.Znam + fract1.Znam * fract2.Num, fract1.Znam * fract2.Znam);
            }
            else throw new MyException(1, 1);
        }

        public static Fraction operator -(Fraction fract1, Fraction fract2)
        {
            if (fract1.Znam > 0 && fract2.Znam > 0)
            {
                return new Fraction(fract1.Num * fract2.Znam - fract1.Znam * fract2.Num, fract1.Znam * fract2.Znam);
            }
            else throw new MyException(1, 1);
        }

        public static Fraction operator *(Fraction fract1, Fraction fract2)
        {
            if (fract1.Znam > 0 && fract2.Znam > 0)
            {
                return new Fraction(fract1.Num * fract2.Znam * fract1.Znam * fract2.Num, fract1.Znam * fract2.Znam);
            }
            else throw new MyException(1, 1);
            }

        public static Fraction operator /(Fraction fract1, Fraction fract2)
        {
            if (fract1.Znam > 0 && fract2.Znam > 0)
            {
                return new Fraction(fract1.Num * fract2.Znam / fract1.Znam * fract2.Num, fract1.Znam * fract2.Znam);
            }
            else throw new MyException(1, 1);
        }

        public static bool operator ==(Fraction fract1, Fraction fract2)
        {
            if (fract1.Znam > 0 && fract2.Znam > 0)
            {
                return ((double)fract1 == (double)fract2) ? true : false;
            }
            else throw new MyException(1, 1);
        }

        public static bool operator !=(Fraction fract1, Fraction fract2)
        {
            if (fract1.Znam > 0 && fract2.Znam > 0)
            {
                return ((double)fract1 != (double)fract2) ? true : false;
            }
            else throw new MyException(1, 1);
        }

        public static bool operator <(Fraction fract1, Fraction fract2)
        {
            return ((double)fract1 < (double)fract2) ? true : false;
        }

        public static bool operator >(Fraction fract1, Fraction fract2)
        {
            return ((double)fract1 > (double)fract2) ? true : false;
        }

        public static bool operator false(Fraction fract1)
        {
            return (fract1.Num > fract1.Znam) ? true : false;
        }

        public static bool operator true(Fraction fract1)
        {
            return (fract1.Num < fract1.Znam) ? true : false;
        }

        public static implicit operator int(Fraction fract)
        {
            fract.Znam = 1;
            return (int)fract.Num;
        }

        public static explicit operator Fraction(int num)
        {
            return (Fraction)num;
        }

        public static implicit operator double(Fraction fract)
        {
            return (double)fract;
        }

        public static implicit operator Fraction(double num)
        {
            return new Fraction();
        }
    }
}