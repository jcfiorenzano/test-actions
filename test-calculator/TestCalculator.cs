using FluentAssertions;
using NUnit.Framework;
using test_actions;

namespace test_calculator
{
    public class TestCalculator
    {
        [Test]
        public void TestAdd()
        {
            var calculator = new Calculator();
            var result = calculator.sum(1, 2);
            result.Should().Be(3);
        }
    }
}
