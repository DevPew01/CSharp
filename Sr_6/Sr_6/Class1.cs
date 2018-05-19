using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_6_2
{
    class Money
    {
        private int Hrivnu { get; set; }
        private int kopeyki { get; set; }

        public Money(int uah, int kop)
        {
            Hrivnu = uah;
            kopeyki = kop;
        }

        public static Money operator +(Money uah, Money uah1)
        {
            return new Money(uah.Hrivnu + uah.kopeyki, uah1.Hrivnu + uah1.kopeyki);
        }

        public static Money operator -(Money uah, Money uah1)
        {
            return new Money(uah.Hrivnu - uah.kopeyki, uah1.Hrivnu - uah1.kopeyki);
        }

        public static Money operator *(Money uah, int nm)
        {
            return new Money(uah.Hrivnu + uah.kopeyki,  nm);
        }

        public static Money operator /(Money uah, int nm)
        {
            return new Money(uah.Hrivnu + uah.kopeyki, nm);
        }


    }
}
