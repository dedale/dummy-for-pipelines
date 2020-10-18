using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Highway.UnitTests
{
    [Property("Perimeter", "Highway")]
    [TestFixtureSource(nameof(values))]
    public class Tests
    {
        static int[] values = Enumerable.Range(0, 500).ToArray();
        private readonly double duration;
        public Tests(int value)
        {
            duration = Math.Round(Math.Exp(5.0 * value / 1000), 3);
        }
        [Test] public void Test()
        {
            Assert.AreEqual("Highway.Code", typeof(Code).FullName);
            Console.WriteLine($"Would wait {duration} s");
        }
    }

    [TestFixture]
    public class Sandbox
    {
        [Test, Explicit, ExcludeFromCodeCoverage] public void Test()
        {
            var fixtures = 1000;
            var xMin = 0.0;
            var xMax = 6.0;
            var duration = Enumerable.Range(0, 1000)
                .Select(i => Math.Exp(xMin + (xMax - xMin) * i / fixtures))
                .Sum();
            Console.WriteLine(duration);
        }
    }
}
