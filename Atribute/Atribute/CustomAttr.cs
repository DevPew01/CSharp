using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Atribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ParamsAttribute: Attribute
    {
        public string Prop { set; get; }
        public ParamsAttribute()
        {

        }
        public ParamsAttribute(string fileName)
        {
            file = new FileStream(fileName, FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                Prop = reader.ReadToEnd();
            }
        }
        private FileStream file;
    }
}