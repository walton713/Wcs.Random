using MathNet.Numerics.Random;
using Wcs.Random.Types;

namespace Wcs.Random
{
    public class Randomizer
    {
        public Randomizer()
        {
            System.Random rng = new MersenneTwister(true);
            Dice = new Dice(rng);
        }

        public Dice Dice { get; }
    }
}
