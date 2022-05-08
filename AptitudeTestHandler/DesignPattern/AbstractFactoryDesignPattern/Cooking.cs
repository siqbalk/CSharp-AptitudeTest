using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTestHandler.DesignPattern.AbstractFactoryDesignPattern
{
    public  class Cooking : ISKill
    {
        public ISKill CreateDancing()
        {
            return null;
        }

        public ISKill CreateCooking()
        {
            return new Cooking();
        }
        public string ShowSkill()
        {
            return "cooking";
        }
    }
}
