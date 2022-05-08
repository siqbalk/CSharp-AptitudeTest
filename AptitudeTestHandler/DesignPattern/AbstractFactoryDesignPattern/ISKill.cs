using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTestHandler.DesignPattern.AbstractFactoryDesignPattern
{
    public  interface ISKill
    {
        ISKill CreateDancing();

        ISKill CreateCooking();
        string ShowSkill();
    }
}
