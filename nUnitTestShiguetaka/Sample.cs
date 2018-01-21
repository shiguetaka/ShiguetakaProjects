using NUnit.Framework;

namespace nUnitTestShiguetaka
{
    public class Sample
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool IsTestingFun()
        {
            return true;
        }

        [TestFixture]
        public class SampleTests
        {
            private Sample s;

            [SetUp]
            public void SetUp()
            {
                s = new Sample();
            }

            [TestCase(1, 1)]
            [TestCase(-1, -1)]
            [TestCase(-1, 1)]
            [TestCase(1, -1)]
            public void AddReturnsSumOfBothParams(int a, int b)
            {
                int result = s.Add(a, b);

                int expected = a + b;
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void IsTestingFunReturnsTrue()
            {
                bool result = s.IsTestingFun();

                Assert.IsTrue(result);
            }
        }        
    }
}
