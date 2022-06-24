using MathNet.Numerics.Random;

namespace Wcs.Random.Configuration
{
    public class RandomizerOptions
    {
        public RandomizerOptions()
        {
        }

        public RandomizerOptions(RandomSource randomSource)
        {
            RandomSource = randomSource;
        }

        public RandomSource RandomSource { get; } = MersenneTwister.Default;
    }
}
