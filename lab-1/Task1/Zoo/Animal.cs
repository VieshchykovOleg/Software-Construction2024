﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Diet { get; set; }
    }
}
