﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modulea
{
    public class Animal
    {
        public Guid AnimalId {  get; set; }
        public string Name { get; set; } = string.Empty;
    };
}
