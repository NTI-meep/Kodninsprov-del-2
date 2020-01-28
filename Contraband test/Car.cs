using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband_test
{
    class Car
    {
        public int passengers; // Olika variabler som används 
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();
        

        public Car()
        {
          
            

        }



        public bool Examine()
        {

            if (contrabandAmount >= 0) // OM contrabandamountet finns så returneras det true annars falskt och alltid så returnera alreadychecked som true 
            {
                alreadyChecked = true;
                return true;


            }

            else
                alreadyChecked = true;
            return false;

        }




    }
}
