using MathNet.Numerics.Random;
using Wcs.Random.Types;

namespace Wcs.Random
{
    /// <summary>
    /// The main <c>Randomizer</c> class.
    /// This class holds all of the different types of randomizers.
    /// </summary>
    public class Randomizer
    {
        /// <summary>
        /// Creates a new <c>Randomizer</c> based on the Mersenne Twister.
        /// </summary>
        public Randomizer()
        {
            System.Random rng = new MersenneTwister(true);
            Dice = new Dice(rng);
        }

        /// <summary>
        /// Access to all of the <c>Dice</c> randomizer methods.
        /// </summary>
        /// <seealso cref="Wcs.Random.Types.Dice" />
        public Dice Dice { get; }
    }
}
