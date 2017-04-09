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

            int selectedOption; //I understand that this variable was defined for use later

            do //A do while loop! It makes so much sense now!
            {
                //TODO fill this out with more options to interact with the pet
                //Note to self MVP- Add more options later. Make it work first!
                
                Console.WriteLine("\nPlease select an option\n");
                Console.WriteLine("1. Feed me"); //Changed these options to sound like user was actually interacting with pet
                Console.WriteLine("2. Play a game with me");
                Console.WriteLine("3. Take me to the vet");
                Console.WriteLine("4. Give me water");
                Console.WriteLine("5. Take me to the bathroom");
                Console.WriteLine("10. Quit");
                Console.WriteLine("\n");

                selectedOption = int.Parse(Console.ReadLine()); //converts user input into a string to be used for interaction
                Console.WriteLine("\n");

                myPet.MyPetStatus(); //Note to self, Is this calling the class myPet? Figure out why this works...

                switch (selectedOption) //I remember switch case and prefer this option when it is a good fit
                {
                    //when the user selects option one we feed the pet
                    case 1:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you, the food was yummy!\n");
                        break;

                    case 2: //when selected, user plays with the pet

                        myPet.LessBored();
                        Console.WriteLine("Thank you, I had so much fun playing!\n");
                        break;

                    case 3: //when selected, user takes Glitch to the vet

                        myPet.LessSick();
                        Console.WriteLine("Thank you, I feel much better!\n");
                        break;

                    case 4: //when selected, user gives pet water

                        myPet.LessThirsty();
                        Console.WriteLine("Thank you, that water was delicious!\n");
                        break;

                    case 5: //when selected, user takes glitch to the bathroom
                        myPet.GottaGoLater();
                        Console.WriteLine("Thank you for taking me to the bathroom.\n");
                        break;

                    //TODO we need to add more cases for the other ways to interact with our pet

                    case 10:

                        Console.WriteLine("Thank you for taking such great care of me.");
                        break;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here
                myPet.HungerIncrease();
                myPet.MoreThirsty();
                myPet.GottaGoNow();
                //Note to self: I understand that these methods are being called and that's why they work
                //figure out why calling the method works vs using an if else statement
                //also figure out if an if else can be used in a loop for more control of what increases and why
                //for example thirst increasing after eating or playing...
                
            } while (selectedOption != 10); //The switch was inside of a loop allowing the magic to happen. 
                                            //it really makes so much sense now!

        }
    }
}
