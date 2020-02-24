using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("5,1:hello", Prefix("hello"));
            Assert.AreEqual("0,0:", Prefix(""));
            Assert.AreEqual("27777,5:what ... did you say?? ", Prefix("what ... did you say?? "));
        }
    }
}