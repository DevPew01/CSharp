using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_8_
{

    [Serializable]
    public class MyException : ApplicationException
    {
        public string Exept{ get; private set; }
        public MyException() { Exept = "Вы банкрот"; }
        public MyException(int i) { Exept = "Вы слишком богаты!"; }
        public MyException(int i, int j) { Exept = "Знаменатель равен нулю"; }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
