﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Car : IShape
    {
        public void Draw()
        {
           Console.WriteLine(@"car model bmw --------------/\-------------");
        }
    }
}
