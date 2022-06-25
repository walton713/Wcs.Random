using System;
using MathNet.Numerics.Random;

namespace Wcs.Random.Configuration
{
    /// <summary>
    /// The <c>RandomizerOptions</c> class.
    /// Contains configuration for the <see cref="Randomizer" /> class.
    /// </summary>
    public class RandomizerOptions
    {
        /// <summary>
        /// Creates a new <c>RandomizerOptions</c> with the default configuration.
        /// </summary>
        public RandomizerOptions()
        {
        }

        /// <summary>
        /// Creates a new <c>RandomizerOptions</c> with the supplied RandomSource.
        /// Any RandomSource from MathNet.Numerics.Random is usable.
        /// </summary>
        /// <param name="randomSource"></param>
        public RandomizerOptions(RandomSource randomSource)
        {
            RandomSource = randomSource ?? throw new ArgumentNullException(nameof(randomSource));
        }

        /// <summary>
        /// The RandomSource to be used by the Randomizer.
        /// </summary>
        public RandomSource RandomSource { get; } = MersenneTwister.Default;
    }
}
