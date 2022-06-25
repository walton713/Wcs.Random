using System;
using FluentAssertions;
using MathNet.Numerics.Random;
using Wcs.Random.Configuration;
using Xunit;

namespace Wcs.Random.Test.Configuration;

public class RandomizerOptionsTests
{
    [Fact]
    public void DefaultOptionsUseMersenneTwister()
    {
        new RandomizerOptions().RandomSource.Should().BeOfType<MersenneTwister>();
    }

    [Fact]
    public void RandomSourceIsConfigurable()
    {
        new RandomizerOptions(new CryptoRandomSource()).RandomSource.Should().BeOfType<CryptoRandomSource>();
    }

    [Fact]
    public void RandomSourceCannotBeNull()
    {
        var act = () => new RandomizerOptions(null);

        act.Should()
            .Throw<ArgumentNullException>()
            .WithMessage("Value cannot be null. (Parameter 'randomSource')");
    }
}
