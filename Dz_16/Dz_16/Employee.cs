using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_16
{
    [Serializable]
    public sealed class Employee
    {
        public Employee()
        {

        }

        public Employee(Image photo, string FIO)
        {
            this.Photo = photo;
            this.FIO = FIO;
        }

        public Image Photo { set; get; }
        public string FIO { set; get; }
        public string Position { set; get; }
        public double Salary { set; get; }
        public DateTime BirthDay { set; get; }

        public override string ToString()
        {
            return $"Name: {FIO} Birthday: {BirthDay} Position: {Position} Salary: {Salary}";
        }
    }
}
