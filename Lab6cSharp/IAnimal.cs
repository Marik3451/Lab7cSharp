using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6cSharp
{
     public interface IAnimal : ICloneable, IComparable <IAnimal>
    {
        string Name { get; }
        double Weight { get; }
    }
}
