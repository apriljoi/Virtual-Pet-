using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how we instantiate a new instance of our pet
            VirtualPet myPet = new VirtualPet();


            //TODO add a greeting for the user. you can also let the user name the pet if you like
            Console.WriteLine("Hi, my name is, Glitch. Thank you for being my new friend!");

            int selectedOption;

            do
            {
                //TODO fill this out with more options to interact with the pet
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Play with the pet");
                Console.WriteLine("3. Give the pet water");                
                Console.WriteLine("4. Take pet to use bathroom");
                Console.WriteLine("5. Take pet to the vet");
                Console.WriteLine("10. Quit");


                selectedOption = int.Parse(Console.ReadLine());

                myPet.MyPetStatus();

                switch (selectedOption)
                {
                    //when the user selects option one we feed the pet
                    case 1:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding me");
                        break;

                    case 2:

                        myPet.LessBored();
                        Console.WriteLine("Thank you for playing a game with me");
                        break;

                    case 3:

                        myPet.LessSick();
                        Console.WriteLine("Thank you for giving me water");
                        break;

                    case 4:

                        myPet.LessThirsty();
                        Console.WriteLine("Thank you making me feel better");
                        break;

                    case 5:
                        myPet.GottaGoLater();
                        Console.WriteLine("Thank you for taking me to the bathroom");
                        break;

                    //TODO we need to add more cases for the other ways to interact with our pet

                    case 10:

                        Console.WriteLine("Thank you for playing.");
                        break;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here
                myPet.HungerIncrease();

            } while (selectedOption != 10);

        }
    }
}
