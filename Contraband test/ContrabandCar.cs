using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband_test
{
    class ContrabandCar : Car // Visar att contrabandcar ärver från car 
    {
        public ContrabandCar()
        {
            passengers = generator.Next(1, 4); // Passagerarna för denna generera mellan 1- 4 

            contrabandAmount = generator.Next(1, 4); // Så görs även för contrabandet 

        }
        
    }
}
