using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highway.UnitTests
{
    [TestFixture, Property("Perimeter", "Highway")]
    public class Tests
    {
        [Test] public void Test()
        {
            Assert.AreEqual("Highway.Code", typeof(Code).FullName);
        }
    }
}
