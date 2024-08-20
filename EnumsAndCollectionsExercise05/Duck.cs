﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise05
{
    class Duck : Bird
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }
        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }
}
