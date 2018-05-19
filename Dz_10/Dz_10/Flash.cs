using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dz_10
{
    public class Flash : Storage
    {
        public Flash(string name, string model, double capacity, float speed) : base(name, model)
        {
            this.name = name;
            this.model = model;
            this.capacity = capacity;
            this.speed = speed;
        }
        public override double GetCapacity()
        {
            return capacity;
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
        public override double GetFreeMemory()
        {
            return capacity - occupiedSpace;
        }
        public override Storage Info()
        {
            return this;
        }
        private double capacity;
        private float speed;
        private double occupiedSpace;
        public override string ToString()
        {
            return $"Flash\nName:{name}\nModel: {model}\nCapacity: {capacity}(Gb)\nSpeed: {speed}(mb/s)";
        }
    }
}