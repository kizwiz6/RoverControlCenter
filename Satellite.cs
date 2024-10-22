﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    internal class Satellite
    {
        public string Alias { get; private set; }

        public int YearLaunched { get; private set; }

        public Satellite(string alias, int yearLaunched)
        {
            Alias = alias;
            YearLaunched = yearLaunched;
        }

        public string GetInfo()
        {
            return $"Alias: {Alias}, YearLaunched: {YearLaunched},";
        }

        public virtual string Explore()
        {
            return "Satellite is exploring the far reaches of space!";
        }

        public virtual string Collect()
        {
            return "Satellite is collecting photographic evidence!";
        }
    }
}
