using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //field
        private string userBumbleBeeName;

        //properties
        public string Name
        {
            get { return this.userBumbleBeeName; }
            set { this.userBumbleBeeName = value; }
        }
       
        //constuctor

        public VirtualPet()
        {
            userBumbleBeeName = Console.ReadLine();
        }
      


        //methods
        public void Greet(string userBumbleBeeName)
        {
            //provide the output for this method
            Console.WriteLine("Hello! You are now taking care of " + Name + " !");
        }
    }
}
