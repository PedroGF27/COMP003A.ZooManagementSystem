// Author: Pedro Garcia
// Course: COMP-003A
// Faculty: Johnathan Cruz
// Purpose: Zoo management system 
namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display all Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");
                
                int choice;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please choose an Option. (1-5)");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter the Name of the Lion: ");
                            string Name = Console.ReadLine();
                            if (string.IsNullOrEmpty(Name))
                            {
                                throw new ArgumentException("Please Enter a Name.");
                            }

                            Console.WriteLine("Enter the Species of the Lion: ");
                            string Species = Console.ReadLine();
                            if (string.IsNullOrEmpty(Species))
                            {
                                throw new ArgumentException("Please Enter a Species.");
                            }

                            Animal Lion = new Lion(Name, Species);
                            animals.Add(Lion);

                            Console.WriteLine("Successfully added Lion!");

                            break;
                        }

                    case 2:
                        {
                            Console.Write("Enter the Name of the Parrot: ");
                            string Name = Console.ReadLine();
                            if (string.IsNullOrEmpty(Name))
                            {
                                throw new ArgumentException("Please Enter a Name.");
                            }

                            Console.WriteLine("Enter the Species of the Parrot: ");
                            string Species = Console.ReadLine();
                            if (string.IsNullOrEmpty(Species))
                            {
                                throw new ArgumentException("Please Enter a Species.");
                            }

                            Animal Parrot = new Parrot(Name, Species);
                            animals.Add(Parrot);

                            Console.WriteLine("Successfully added Parrot!");

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Displaying all Animals:");
                            ZooUtility.DisplayAllAnimals(animals);
                            break;
                        }

                    case 4:
                        {
                            ZooUtility animalDescription = new ZooUtility();

                            Console.WriteLine("Animal name: ");
                            string Name = Console.ReadLine();
                            animalDescription.DescribeAnimal(Name);
                            //if (string.IsNullOrEmpty(Name)) 
                            //    {
                            //        Console.WriteLine("Please Enter a name.");
                            //    }
                            Console.WriteLine("Enter Species of animal: ");
                            string Species = Console.ReadLine();
                            animalDescription.DescribeAnimal(Name, Species);
                            //if (string.IsNullOrEmpty(Name))
                            //{
                            //    Console.WriteLine("Please Enter An Animal.");
                            //}
                            Console.WriteLine("Enter Age of Animal: ");
                            string animalAge = Console.ReadLine();
                            int age;
                            if (!string.IsNullOrWhiteSpace(animalAge))
                            {
                                age = int.Parse(animalAge);
                                animalDescription.DescribeAnimal(Name, Species, age);
                            }
                            //int animalAge;
                            //try
                            //{
                            //    animalAge = Convert.ToInt32(Console.ReadLine());
                            //}
                            //catch
                            //{
                            //    Console.WriteLine("Please enter valid Number.");
                            //}

                            //animalDescription.DescribeAnimal(Name, Species, Age);
                            //if (animalAge != null)
                            //{
                            //    Console.WriteLine("Please Enter an Age.");
                            //}
                            break;
                        }
                        case 5:
                        {
                            exit = true;
                            Console.WriteLine("Program Ending, Goodbye!");
                            break;
                        }
                        default:
                            Console.WriteLine("Please Try Again.");
                        break ;
                        
                }
            }
        }
    }
}
