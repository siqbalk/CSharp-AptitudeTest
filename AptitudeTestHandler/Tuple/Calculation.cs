using System.Threading.Tasks;

namespace AptitudeTestHandler.Tuple
{
    public static   class Calculation
    {
        public static (long, int) SomeCalculation(long v1, int v2, bool v3)
        {
            // TODO: here the implementation of calculation will be written
            if(!v3) return (0, 0);

            return (4000, 4);

        }
    }
}
