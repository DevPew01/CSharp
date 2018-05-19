using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace PC_Store
{
    [Serializable]
    public abstract class Pc_part
    {
        public Pc_part()
        {

        }

        public Pc_part(string name)
        {
            this.Name = name;
        }
        public virtual string Name { set; get; }
        public virtual string Characteristic { set; get; }
        public virtual string Description { set; get; }
        public virtual string Price { set; get; }

        public override string ToString()
        {
            return $"Наименование: {Name} Характеристика: {Characteristic} Описание: {Description} Цена: {Price}";
        }
    }
    [Serializable]
    public class CPU : Pc_part
    {
        public CPU()
        {
            this.Name = "";
        }
        public CPU(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class GPU : Pc_part
    {
        public GPU()
        {
            this.Name = "";
        }
        public GPU(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class MotherBoard: Pc_part
    {
        public MotherBoard()
        {
            this.Name  = "";
        }
        public MotherBoard(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class RAM: Pc_part
    {
        public RAM()
        {
            this.Name = "";
        }
        public RAM(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class HDD: Pc_part
    {
        public HDD()
        {
            this.Name = "";
        }
        public HDD(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class Body: Pc_part
    {
        public Body()
        {
            this.Name = "";
        }
        public Body(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class PowerAdapter: Pc_part
    {
        public PowerAdapter()
        {
            this.Name = "";
        }
        public PowerAdapter(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class AudioCard: Pc_part
    {
        public AudioCard()
        {
            this.Name = "";
        }
        public AudioCard(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class OpticalDrive: Pc_part
    {
        public OpticalDrive()
        {
            this.Name = "";
        }
        public OpticalDrive(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class CoolingSystem: Pc_part
    {
        public CoolingSystem()
        {
            this.Name = "";
        }
        public CoolingSystem(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
    [Serializable]
    public class NIC: Pc_part
    {
        public NIC() => Name = "";
        public NIC(string name)
        {
            this.Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Characteristic { get => base.Characteristic; set => base.Characteristic = value; }
        public override string Description { get => base.Description; set => base.Description = value; }
        public override string Price { get => base.Price; set => base.Price = value; }
    }
}
