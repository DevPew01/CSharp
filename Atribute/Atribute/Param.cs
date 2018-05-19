using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Atribute
{
    public class Param
    {


        private string myProperty;
        [Params("params.ini")]
        public string MyProperty {
            get
            {
                return myProperty;
            }
            set
            {
                myProperty = value;
                MemberInfo[] members = typeof(Param).GetMember("MyProperty");
                object[] attrs = members[0].GetCustomAttributes(true);
                foreach (var at in attrs)
                {
                    if (((Attribute)at).ToString().Contains("ParamsAttribute"))
                    { 
                            Console.WriteLine(at.GetType().GetProperty("prop").GetValue(at, new object[] {}));
                    }
                    Console.WriteLine(at);
                }
            }
        }
    }
}
