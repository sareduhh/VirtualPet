using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        public static string Name { get; private set; }

        static void Main(string[] args)
        {
          Console.WriteLine("Welcome to VirtualPet!");
          Console.WriteLine("Here is an adorable little bumble bee for you to take care of and play with.");
          Console.WriteLine("Please name your bumble bee.");


            //Name Pet
            VirtualPet thisVirtualPet = new VirtualPet();
            thisVirtualPet.Greet(Name);


            //Display score board
            ScoreBoard thisScoreBoard = new ScoreBoard();
            thisScoreBoard.Display(Feed);

            //Set starting scores to 5. User must keep total above 10 or Bumble Bee will be swatted.
            //The scores in my PetClass are set to 5, so they present as 5 even though I have 0s here.

            /*  int hungerScore = userBumbleBee.Hunger;
              userBumbleBee.Hunger = 0;

              int energyScore = userBumbleBee.Energy;
              userBumbleBee.Energy = 0;

              int hungerWaste = userBumbleBee.Waste;
              userBumbleBee.Waste = 0;

              Console.WriteLine("Hunger: " + userBumbleBee.Feed());
              Console.WriteLine("Energy: " + userBumbleBee.Play());
              Console.WriteLine("Waste: " + userBumbleBee.GoPotty());
              */
            
        }
}
}
