using Wcs.Random.Configuration;
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
        /// Creates a new <c>Randomizer</c> with the default options.
        /// </summary>
        public Randomizer() : this(new RandomizerOptions())
        {
        }

        /// <summary>
        /// Creates a new <c>Randomizer</c> with the supplied options.
        /// </summary>
        public Randomizer(RandomizerOptions randomizerOptions)
        {
            Dice = new Dice(randomizerOptions.RandomSource);
        }

        /// <summary>
        /// Access to all of the <c>Dice</c> randomizer methods.
        /// </summary>
        /// <seealso cref="Wcs.Random.Types.Dice" />
        public Dice Dice { get; }
    }
}
