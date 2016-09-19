using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class ScoreBoard
    {
        //fields
        private string bumbleBeeHunger;
        private string bumbleBeeThirst;
        private string bumbleBeeWaste;
        private string bumbleBeeEnergy;
  
        public string bumbleBeeScoreBoardUpDate;

        //properties
        public string Feed
        {
            get { return this.bumbleBeeHunger; }
            set { this.bumbleBeeHunger = Feed; }
        }
        public string Water
        {
            get { return this.bumbleBeeThirst; }
            set { this.bumbleBeeThirst = Water; }
        }
        public string GoPotty
        {
            get { return this.bumbleBeeWaste; }
            set { this.bumbleBeeWaste = GoPotty; }
        }
        public string Play
        {
            get { return this.bumbleBeeEnergy; }
            set { this.bumbleBeeEnergy = Play; }
        }
        public string UpDate
        {
            get { return this.bumbleBeeScoreBoardUpDate; }
            set { this.bumbleBeeScoreBoardUpDate = value; }
        }

        //constructors
        public ScoreBoard()
        {
            bumbleBeeHunger = Feed;
            bumbleBeeThirst = Water;
            bumbleBeeWaste = GoPotty;
            bumbleBeeEnergy = Play;
        }

        public ScoreBoard(string bumbleBeeHunger, string bumbleBeeThirst, string bumbleBeeEnergy, string bumbleBeeWaste)
        {
            bumbleBeeHunger = Console.ReadLine();
            bumbleBeeThirst = Console.ReadLine();
            bumbleBeeEnergy = Console.ReadLine();
            bumbleBeeWaste = Console.ReadLine();
        }

       

        //methods
        public void Display(string bumbleBeeHunger)
        {
          Console.WriteLine("Hunger =" + Feed);
            return;
            

        }

    }
}
