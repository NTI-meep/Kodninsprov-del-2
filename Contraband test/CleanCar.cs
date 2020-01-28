using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband_test
{
    class CleanCar : Car
    {
        public CleanCar() // Samma logis som för contraband versionen 
        {
            passengers = generator.Next(1, 3);

            contrabandAmount = 0;

        }
    
    }
}
