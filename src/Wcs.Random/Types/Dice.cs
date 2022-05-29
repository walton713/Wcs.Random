namespace Wcs.Random.Types
{
    public class Dice
    {
        private readonly System.Random _rng;

        public Dice(System.Random rng)
        {
            _rng = rng;
        }

        public int D2() => DSides(Constants.Two);

        public int D4() => DSides(Constants.Four);

        public int D6() => DSides(Constants.Six);

        public int D8() => DSides(Constants.Eight);

        public int D10() => DSides(Constants.Ten);

        public int D12() => DSides(Constants.Twelve);

        public int D20() => DSides(Constants.Twenty);

        public int D100() => DSides(Constants.Hundred);

        public int DSides(int sides) => _rng.Next(Constants.One, sides + 1);
    }
}
