using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    public abstract class Animal
    {
        private string _name;
        private string _species;

        public string Name
        {
            get { return _name; }
            set { _name = value; 
            if (string.IsNullOrEmpty(value))
            {
                    throw new ArgumentNullException("Error, Please Input a Name.");
            }
            }
        }

        public string Species
        {  
            get { return _species; } 
            set { _species = value; 
            if (string.IsNullOrEmpty(value))
            {
                    throw new ArgumentNullException("Error, Please Enter a Species");
            }
            } 
        }

        /// <summary>
        /// To contruct animals
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Species"></param>
        public Animal(string Name, string Species)
        {
            _name = Name;
            _species = Species;
        }

        public abstract void MakeSound();
        
    }
}
