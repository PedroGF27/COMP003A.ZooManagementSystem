﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    class Parrot : Animal
    {
        public Parrot (string Name, string Species) : base (Name, Species) { }
        
        public override void MakeSound()
        {
            Console.WriteLine("The Parrot Squaks!");
        }
    }
}
