using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTestHandler.DesignPattern.AbstractFactoryDesignPattern
{
    public class Humanoid
    {
        ISKill dancing;
        ISKill cooking;
        public Humanoid()
        {

        }
        public Humanoid(ISKill factory)
        {
             dancing = factory.CreateDancing();
             cooking = factory.CreateCooking();

            if (dancing != null)
            {
                Console.WriteLine(dancing.ShowSkill());
            }
            if (cooking != null)
            {
                Console.WriteLine(cooking.ShowSkill());
            }


        }

    }
}
