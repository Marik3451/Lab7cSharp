using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6cSharp
{
    public class Wolf : Animal
    {
        private string breed;
        private string location;
        public override string Name => "Wolf";

        public string Breed { get => breed; set => breed = value; }
        public string Location { get => location; set => location = value; }

        public Wolf(string breed, string location, double weight, int age, double cost)
            : base("Wolf", weight, age, cost)
        {
            {
                this.breed = breed;
                this.location = location;
            }
        }
       
        public override string ToString()
        {
            return $"{Name} (Species: {Species}, Breed: {Breed}, Weight: {Weight}, Age: {Age}, Cost: {Cost}, Location: {Location})";
        }
    }
}


