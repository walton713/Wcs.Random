namespace Wcs.Random.Configuration
{
    public class RandomizerOptions
    {
        public RandomizerOptions()
        {
        }

        public RandomizerOptions(System.Random randomSource)
        {
            RandomSource = randomSource;
        }

        public System.Random RandomSource { get; set; } = new System.Random();
    }
}
