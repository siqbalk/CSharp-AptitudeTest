using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AptitudeTestHandler
{
    public  class Alexa
    {
        public Alexa()
        {
            GreetingMessage = "hello, i am Alexa";
        }
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }
        public string Talk()
        {
            return $"{GreetingMessage}";
        }
    }
}
