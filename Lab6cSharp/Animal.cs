using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6cSharp
{
    public abstract class Animal : IAnimal
    {
        private string species;
        private double weight;
        private int age;
        private double cost;
        public virtual string Name =>"Animal";

        public string Species { get => species; set => species = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Age { get => age; set => age = value; }
        public double Cost { get => cost; set => cost = value; }

        public Animal(string species, double weight, int age, double cost)
        {
            this.species = species;
            this.weight = weight;
            this.age = age;
            this.cost = cost;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        /*public int CompareTo(IAnimal other)
        {
            return Name.CompareTo(other.Name);
        }*/
        public int CompareTo(IAnimal other)
        {
            return Weight.CompareTo(other.Weight);
        }


    }
}



