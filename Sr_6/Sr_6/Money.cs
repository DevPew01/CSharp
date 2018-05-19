using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_6_2
{
    class Money
    {

        public override string ToString()
        {
            return $"Summa = {grn} grn, {kop} kop";
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public int grn { set; get; }
        public int kop { set; get; }

        public Money()
        {

        }

        public Money(int grn, int kop)
        {
            grn = 0;
            kop = 0;
        }

        public static Money operator+(Money sum, Money sum2)
        {
            return new Money(sum.grn + sum2.grn, sum.kop + sum2.kop);
        }

        public static Money operator -(Money sum, Money sum2)
        {
            return new Money(sum.grn - sum2.grn, sum.kop - sum2.kop);
        }

        public static Money operator *(Money sum, int num)
        {
            return new Money(sum.grn*num, sum.kop * num);
        }

        public static Money operator /(Money sum, int num)
        {
            return new Money(sum.grn / num, sum.kop / num);
        }

        public static Money operator++(Money sum)
        {
            return new Money(sum.grn, sum.kop += 1);
        }

        public static Money operator --(Money sum)
        {
            return new Money(sum.grn, sum.kop -= 1);
        }

        public static bool operator==(Money sum, Money sum2)
        {
            return (sum.grn == sum2.grn && sum.kop == sum2.kop) ? true : false;
        }

        public static bool operator !=(Money sum, Money sum2)
        {
            return (sum.grn == sum2.grn && sum.kop == sum2.kop) ? true : false;
        }
    }
}
