using System.Collections.Generic;
using FluentAssertions;
using MathNet.Numerics.Random;
using Wcs.Random.Types;
using Xunit;

namespace Wcs.Random.Test.Types;

public class DiceTests
{
    private readonly Dice _sut;

    public DiceTests()
    {
        _sut = new Dice(new MersenneTwister(true));
    }

    [Theory]
    [Repeat(10)]
    public void D2ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 2; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 2000; i++)
        {
            results[_sut.D2()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [Repeat(10)]
    public void D4ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 4; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 4000; i++)
        {
            results[_sut.D4()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [Repeat(10)]
    public void D6ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 6; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 6000; i++)
        {
            results[_sut.D6()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [Repeat(10)]
    public void D8ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 8; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 8000; i++)
        {
            results[_sut.D8()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [Repeat(10)]
    public void D10ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 10; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 10000; i++)
        {
            results[_sut.D10()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [Repeat(10)]
    public void D12ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 12; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 12000; i++)
        {
            results[_sut.D12()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [Repeat(10)]
    public void D20ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 20; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 20000; i++)
        {
            results[_sut.D20()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [Repeat(10)]
    public void D100ReturnsCorrectValues()
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= 100; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i < 100000; i++)
        {
            results[_sut.D100()]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(25)]
    [InlineData(50)]
    public void DSidesReturnsCorrectValues(int sides)
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= sides; i++)
        {
            results.Add(i, 0);
        }

        for (var i = 0; i <= sides * 1000; i++)
        {
            results[_sut.DSides(sides)]++;
        }

        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }
}
