using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6cSharp
{
    public class Lion : Animal
    {
        private string breed;
        private string location;
        public override string Name => "Lion";

        public string Breed { get => breed; set => breed = value; }
        public string Location { get => location; set => location = value; }

        public Lion(string breed, string location, double weight, int age, double cost)
            : base("Lion", weight, age, cost)
        {
            {
                this.breed = breed;
                this.location = location;
            }
        }
        /* public override string ToString()
         {
             return $"Species: {species}, Breed: {breed}, Weight: {weight}, Age: {age}, Cost: {cost}, Location: {location}";
         }*/
        public override string ToString()
        {
            return $"{Name} (Species: {Species}, Breed: {Breed}, Weight: {Weight}, Age: {Age}, Cost: {Cost}, Location: {Location})";
        }
    }
}
