using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dz_10
{
    class DVD : Storage
    {
        public DVD(string name, string model, float ReadSpeed, float WriteSpeed) : base(name, model)
        {
            this.name = name;
            this.model = model;
            this.ReadSpeed = ReadSpeed;
            this.WriteSpeed = WriteSpeed;
            if (SideType)
            {
                Capacity = 9;
            }
            else Capacity = 4.7;
        }

        public override bool Copy(double fileSize)
        {
            if (fileSize > GetFreeMemory())
                return false;
            else
            {
                occupiedSpace += fileSize;
                return true;
            }
        }

        public override double GetCapacity()
        {
            return this.Capacity;
        }

        public override double GetFreeMemory()
        {
            return this.Capacity - occupiedSpace;
        }

        public override Storage Info()
        {
            return this;
        }

        public override string ToString()
        {
            return $"DVD\nName: {name}\nModel: {model}\nRead speed: {ReadSpeed}(mb/s)\nCapacity: {Capacity}(Gb)\nWrite speed: {WriteSpeed}(mb/s)";
        }

        private float ReadSpeed;
        private float WriteSpeed;
        private double Capacity;
        private double occupiedSpace;
        public bool SideType { set; get; }
    }
}
