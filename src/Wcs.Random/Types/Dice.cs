using System;

namespace Wcs.Random.Types
{
    /// <summary>
    /// The <c>Dice</c> roller class.
    /// Contains methods to simulate rolling different dice.
    /// </summary>
    public class Dice
    {
        private readonly System.Random _rng;

        internal Dice(System.Random rng)
        {
            _rng = rng;
        }

        /// <summary>
        /// Equivalent to flipping a coin.
        /// </summary>
        /// <returns>Either 1 or 2.</returns>
        public int D2() => DSides(Constants.Two);

        /// <summary>
        /// Equivalent of rolling a four-sided die.
        /// </summary>
        /// <returns>An integer between 1 and 4 inclusively.</returns>
        public int D4() => DSides(Constants.Four);

        /// <summary>
        /// Equivalent of rolling a six-sided die.
        /// </summary>
        /// <returns>An integer between 1 and 6 inclusively.</returns>
        public int D6() => DSides(Constants.Six);

        /// <summary>
        /// Equivalent of rolling a eight-sided die.
        /// </summary>
        /// <returns>An integer between 1 and 8 inclusively.</returns>
        public int D8() => DSides(Constants.Eight);

        /// <summary>
        /// Equivalent of rolling a ten-sided die.
        /// </summary>
        /// <returns>An integer between 1 and 10 inclusively.</returns>
        public int D10() => DSides(Constants.Ten);

        /// <summary>
        /// Equivalent of rolling a twelve-sided die.
        /// </summary>
        /// <returns>An integer between 1 and 12 inclusively.</returns>
        public int D12() => DSides(Constants.Twelve);

        /// <summary>
        /// Equivalent of rolling a twenty-sided die.
        /// </summary>
        /// <returns>An integer between 1 and 20 inclusively.</returns>
        public int D20() => DSides(Constants.Twenty);

        /// <summary>
        /// Equivalent of rolling a one hundred-sided die.
        /// </summary>
        /// <returns>An integer between 1 and 100 inclusively.</returns>
        public int D100() => DSides(Constants.Hundred);

        /// <summary>
        /// Equivalent of rolling a die with <paramref name="sides"/> number of sides.
        /// </summary>
        /// <returns>An integer between 1 and <paramref name="sides"/> inclusively.</returns>
        /// <param name="sides">A positive integer.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when <paramref name="sides"/> is less than 1.
        /// </exception>
        public int DSides(int sides) => sides > 0
            ? _rng.Next(Constants.One, sides + 1)
            : throw new ArgumentOutOfRangeException(nameof(sides), $"{nameof(sides)} must be positive");
    }
}
