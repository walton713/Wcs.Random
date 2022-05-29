using System.Collections.Generic;
using FluentAssertions;
using Wcs.Random.Types;
using Xunit;

namespace Wcs.Random.Test.Types;

public class DiceTests : RandomizerTests
{
    private readonly Dice _sut;

    public DiceTests()
    {
        _sut = Randomizer.Dice;
    }

    [Theory]
    [Repeat(10)]
    public void D2ReturnsCorrectValues()
    {
        var results = InitialResults(2);

        for (var i = 0; i < 2000; i++)
        {
            results[_sut.D2()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [Repeat(10)]
    public void D4ReturnsCorrectValues()
    {
        var results = InitialResults(4);

        for (var i = 0; i < 4000; i++)
        {
            results[_sut.D4()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [Repeat(10)]
    public void D6ReturnsCorrectValues()
    {
        var results = InitialResults(6);

        for (var i = 0; i < 6000; i++)
        {
            results[_sut.D6()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [Repeat(10)]
    public void D8ReturnsCorrectValues()
    {
        var results = InitialResults(8);

        for (var i = 0; i < 8000; i++)
        {
            results[_sut.D8()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [Repeat(10)]
    public void D10ReturnsCorrectValues()
    {
        var results = InitialResults(10);

        for (var i = 0; i < 10000; i++)
        {
            results[_sut.D10()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [Repeat(10)]
    public void D12ReturnsCorrectValues()
    {
        var results = InitialResults(12);

        for (var i = 0; i < 12000; i++)
        {
            results[_sut.D12()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [Repeat(10)]
    public void D20ReturnsCorrectValues()
    {
        var results = InitialResults(20);

        for (var i = 0; i < 20000; i++)
        {
            results[_sut.D20()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [Repeat(10)]
    public void D100ReturnsCorrectValues()
    {
        var results = InitialResults(100);

        for (var i = 0; i < 100000; i++)
        {
            results[_sut.D100()]++;
        }

        CheckResults(results);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(25)]
    [InlineData(50)]
    public void DSidesReturnsCorrectValues(int sides)
    {
        var results = InitialResults(sides);

        for (var i = 0; i <= sides * 1000; i++)
        {
            results[_sut.DSides(sides)]++;
        }

        CheckResults(results);
    }

    private static Dictionary<int, int> InitialResults(int sides)
    {
        var results = new Dictionary<int, int>();

        for (var i = 1; i <= sides; i++)
        {
            results.Add(i, 0);
        }

        return results;
    }

    private static void CheckResults(Dictionary<int, int> results)
    {
        foreach (var result in results)
        {
            result.Value.Should().BeInRange(850, 1150, $"{result.Key} was out of range");
        }
    }
}
