using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum Colors {Black, White, Green, Yellow, Red, Gray, Orange, Blue};

    [Serializable]
    public class Car
    {
        public Car()
        {

        }

        public string Mark {set; get; }
        public DateTime CreationDate { set; get; }
        public string EngineVin { set; get; }
        public string BodyVin { set; get; }
        public string Color { set; get; }
        public string Number { set; get; }
        public string DriverFIO { set; get; }

        public override string ToString()
        {
            return $"Марка: {Mark} Год: {CreationDate.ToShortDateString()} " +
                $"номер двигателя: {EngineVin} номер кузова: {BodyVin} Цвет: {Color} Номер: {Number} ФИО владельца: {DriverFIO}";
        }
    }
}
