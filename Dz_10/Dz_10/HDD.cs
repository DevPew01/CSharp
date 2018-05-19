using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dz_10
{ 
    class HDD : Storage
    {
        public HDD(string name, string model, double capacity, int PartsCount, double PartsCap, double speed) : base(name, model)
        {
            this.name = name;
            this.model = model;
            this.capacity = capacity;
            this.PartsCount = PartsCount;
            this.PartsCap = PartsCap;
            this.speed = speed;
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
            return capacity;
        }

        public override double GetFreeMemory()
        {
            return capacity - occupiedSpace;
        }

        public override Storage Info()
        {
            return this;
        }

        public override string ToString()
        {
            return $"HDD\nName: {name}\nModel: {model}\nCapacity: {capacity}(Gb)\nSpeed: {speed}(Mb/s)\nNumber of parts: {PartsCount}\nPart capacity: {PartsCap}(mb)";
        }

        private double capacity;
        private double speed;
        private int PartsCount;
        private double PartsCap;
        private double occupiedSpace;
    }
}
