using FluentAssertions;
using MathNet.Numerics.Random;
using Wcs.Random.Configuration;
using Xunit;

namespace Wcs.Random.Test.Configuration;

public class RandomizerOptionsTests
{
    [Fact]
    public void DefaultOptionsUseSystemRandom()
    {
        new RandomizerOptions().RandomSource.Should().BeOfType<System.Random>();
    }

    [Fact]
    public void RandomSourceIsConfigurable()
    {
        new RandomizerOptions(MersenneTwister.Default).RandomSource.Should().BeOfType<MersenneTwister>();
    }
}
