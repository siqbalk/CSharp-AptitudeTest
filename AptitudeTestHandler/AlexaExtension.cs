using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTestHandler
{
    public static   class AlexaExtension
    {
        public static Alexa Configure(this Alexa  alexa, Action<Alexa> action)
        {
            action.Invoke(alexa);
            return alexa;
        }
    }
}
