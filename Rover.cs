using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    internal class Rover
    {
        public string Alias { get; private set; }

        public int YearLanded { get; private set; }

        public Rover(string alias, int yearLanded)
        {
            Alias = alias;
            YearLanded = yearLanded;
        }

        public string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLanded}.";
        }

        public virtual string Explore()
        {
            return "Rover is exploring the surface!";
        }

        public virtual string Collect()
        {
            return "Rover is collecting rocks!";
        }
    }
}
