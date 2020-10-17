using NUnit.Framework;
using System;

namespace Marvel.Maths.UnitTests
{
    [TestFixture, Property("Perimeter", "Core")]
    public class Tests
    {
        [Test] public void Test()
        {
            Assert.AreEqual("Marvel.Maths.Code", typeof(Code).FullName);
        }
    }
}
