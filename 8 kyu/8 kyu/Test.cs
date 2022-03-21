namespace Solution
{
    using NUnit.Framework;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Sample()
        {
            Assert.AreEqual(new int[] { 1, 2, 2, 3 }, Kata.Flip('R', new int[] { 3, 2, 1, 2 }));
            Assert.AreEqual(new int[] { 5, 5, 4, 3, 1 }, Kata.Flip('L', new int[] { 1, 4, 5, 3, 5 }));
        }
    }
}