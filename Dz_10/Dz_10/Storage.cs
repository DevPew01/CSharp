namespace Dz_10
{
    public abstract class Storage
    {
        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }
        protected string name;
        protected string model;
        public abstract double GetCapacity();
        public abstract bool Copy(double fileSize);
        public abstract double GetFreeMemory();
        public abstract Storage Info();

        protected double FileSize = 780;
        protected double FullSize = 578560;
    }
}