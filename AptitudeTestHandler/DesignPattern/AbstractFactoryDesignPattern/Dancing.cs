using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTestHandler.DesignPattern.AbstractFactoryDesignPattern
{
    public class Dancing : ISKill
    {

        public ISKill CreateDancing()
        {
            return new Dancing();
        }

        public ISKill CreateCooking()
        {
           return null;
        }
        public string ShowSkill()
        {
            return "dancing";
        }
    }
}
