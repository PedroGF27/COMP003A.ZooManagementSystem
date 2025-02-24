using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class ZooUtility
    {
        public void DescribeAnimal(string Name)
        {
            Console.WriteLine($"Animal Name: {Name}");
        }

        public void DescribeAnimal(string Name, string Species)
        {
            Console.WriteLine($"Animal Name: {Name}, Species: {Species}");
        }

        public void DescribeAnimal(string Name, string Species, int Age)
        {
            Console.WriteLine($"Animal Name: {Name}, Species: {Species}, Age: {Age} years old");
        }
    }
}
