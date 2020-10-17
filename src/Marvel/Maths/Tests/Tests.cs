using NUnit.Framework;
using System;
using System.Linq;

namespace Marvel.Maths.UnitTests
{
    [Property("Perimeter", "Core")]
    [TestFixtureSource(nameof(values))]
    public class Tests
    {
        static int[] values = Enumerable.Range(0, 500).ToArray();
        private readonly double duration;
        public Tests(int value)
        {
            duration = Math.Round(Math.Exp(5.0 * value / 1000), 3);
        }
        [Test]
        public void Test()
        {
            Assert.AreEqual("Marvel.Maths.Code", typeof(Code).FullName);
            Console.WriteLine($"Would wait {duration} s");
        }
    }
}
