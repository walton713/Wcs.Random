using MathNet.Numerics.Random;
using Wcs.Random.Types;

namespace Wcs.Random
{
    public class Randomizer
    {
        private System.Random _rng;

        public Randomizer()
        {
            _rng = new MersenneTwister(true);

            Dice = new Dice(_rng);
        }

        public Dice Dice { get; }
    }
}
