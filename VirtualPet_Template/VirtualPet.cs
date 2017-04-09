using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //We're setting our fields to private here so only the VirtualPet class can modify them directly
        private string hiMyNameIs;
        private int imHungry;
        //Some ideas for things that a virtual pet should have (along with some ideas for activities that might address them):

        //*IDEAS for things virtual pet should have* 
        //Hunger(Feed it)
        //Thirst(Water it)
        //Waste(Let it out to the bathroom)
        //Boredom(Play with it)
        //Sickness(Take it to the doctor)
                //*I will continue to use the private string for now as instructed and learn why I'm doing this later*
        private int imBored;
        private int imSick;
        private int soThirsty;
        private int gottaGo;
        
        //TODO fill in more fields 
             //*MVP* hopefully I can add more categories later, for now, this works

        //this defaut constructor sets options without giving us any options
        public VirtualPet()
        {
            this.hiMyNameIs = "Glitch\n";
            this.imHungry = 10;
            this.imBored = 10;
            this.imSick = 10;
            this.soThirsty = 10;
            this.gottaGo = 10;

                //I am setting the values for everything to be the same. I plan on increasing 
                //the values by 1 as the user interacts with the pet and makes decisions. As a new
                //programmer, 1 seems easier (++)

            //TODO account for more fields
        }

        //TODO how can we set things with our construtor
        public VirtualPet(string hiMyNameIs, int imHungry, int imSick, int imBored, int soThirsty, int gottaGo)
        {
            this.hiMyNameIs = hiMyNameIs;
        }

        
        //this method can be called to increase the hunger
        public void HungerIncrease()
        {
            //TODO modify these values to anything you see fit
            this.imHungry = imHungry + 1; //my logic is to increase by 1 and decrease by 2. 
                                            //we wouldn't want the user to have to perform tasks all day
                                            //I wonder if I can use ++ here since I am increasing by 1
                                            //Note to self: If possible, try ++ vs +1 once runs successfully
        }

        //I will need a method for every behavior that I chose...

            //For now I am going to keep all the increase methods together... If need be, I will rearrange later
            //From what I have learned about methods, it actually shouldn't matter where they are located, they just
            //need to be correct and able to be called on later. Contemplating keeping each behavior grouped together vs
            //each manipulation together, but that's more of a mental note to self to try later...
            //TODO we need to add more methods to modify the other fields
       
       //*****INCREASES*****
        //imBored increases with MoreBored 
        public void MoreBored()
        {
            this.imBored = imBored + 1; //consider ++ vs +1
        }
       
        //imSick increases with MoreBored decreases with LessBored
        public void MoreSick()
        {
            this.imSick = imSick + 1;
        }

        //soThirsty increases with MoreThirsty decreases with LessThirsty
        public void MoreThirsty()
        {
            this.soThirsty = soThirsty + 1;
        }

        //gottaGo increases with GottaGoNow decreases with GottaGoLater
        public void GottaGoNow()
        {
            this.gottaGo = gottaGo + 1;
        }

        //*****DECREASES*****

        //this method can be called to decrease the hunger
        public void HungerDecrease()
        {   
            //TODO modify these values to anything you see fit
            this.imHungry = imHungry - 2;
        }

        //now time to add my other decrease methods

        //method for decreasing boredem
        public void LessBored()
        {
            this.imBored = imBored - 2;
        }

        //method for decreasing sickness
        public void LessSick()
        {
            this.imSick = imSick - 2;
        }

        //method for decreasing thirstiness(spelling?)
        public void LessThirsty()
        {
            this.soThirsty = soThirsty - 2;
        }

        //method for taking to the bathroom
        public void GottaGoLater()
        {
            this.gottaGo = gottaGo - 2;
        }
               
       
        //method for stats of virtual pet
        //For the sake of not confusing myself, I will keep the status simple for now.
        //Note to self: MVP-once working add some more stats
        public void MyPetStatus()
        {
            Console.WriteLine(hiMyNameIs);
            Console.WriteLine("\n");
            Console.WriteLine("Hunger:  " + imHungry);
            Console.WriteLine("Boredem:  " + imBored);
            Console.WriteLine("Health:  " + imSick);
            Console.WriteLine("Water:  " + soThirsty);
            Console.WriteLine("Bathroom Need:  " + gottaGo); //hopefully I can find something a little more user friendly
                                                        //for Cleanliness...Hmmmm???
            //TODO account for more fields
        }
    }
}
