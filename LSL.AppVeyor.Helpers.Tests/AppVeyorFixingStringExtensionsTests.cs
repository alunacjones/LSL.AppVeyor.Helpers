using FluentAssertions;
using NUnit.Framework;

namespace LSL.AppVeyor.Helpers.Tests;

public class AppVeyorFixingStringExtensionsTests
{
    [TestCase("a test", "a test")]
    [TestCase("a test\r\nand another line", "a test\r\nand another line")]
    [TestCase("a test\nand another line", "a test\r\nand another line")]
    public void GivenAStringToFix_ThenItShouldProduceTheExpectedResult(string input, string expectedOutput)
    {
        input.FixStringConstantNewLines().Should().Be(expectedOutput);
    }
}