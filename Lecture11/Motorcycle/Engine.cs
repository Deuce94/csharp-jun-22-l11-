using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    public class Engine
    {
        protected internal int volume;
        protected internal int power;

        public Engine(int myVolume, int myPower)
        {

            if( myVolume >= 125 && myVolume <= 1300 )
            {
                volume = myVolume;

            }
            else
            {
                Console.WriteLine("Such engine isn't exist! Default value is 125");
                volume = 125;
            }

            if (myPower >= 50 && myPower <= 400)
            {
                power = myPower;

            }
            else
            {
                Console.WriteLine("Such power isn't exist! Default value is 50");
                power = 50;
            }
        }


    }

    public class Fuel : Engine
    {
        public Fuel(int myVolume, int myPower) : base(myVolume, myPower)
        {

        }
    }


    public class Electro : Engine
    {
        public Electro(int myVolume, int myPower) : base(myVolume, myPower)
        {

        }
    }
}
