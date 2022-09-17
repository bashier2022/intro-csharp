namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            Data.Algebra alg = new Data.Algebra();
            var r = alg.Add(5, 6);
            Assert.AreEqual(r, 5+6);
        }
        [Test]
        public void TestMultPostives()
        {
            int a, b , r;
            Data.Algebra alg = new Data.Algebra();
            (a, b)=(0, 0);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

            (a, b)=(0, 5);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

            (a, b)=(7, 0);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

            (a, b)=(7, 5);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

        }

        [Test]
        public void TestMultNegatives()
        {
            int a, b, r;
            Data.Algebra alg = new Data.Algebra();
            
            (a, b)=(0, -5);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

            (a, b)=(-7, 0);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

            (a, b)=(7, -5);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

            (a, b)=(-7, 5);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

            (a, b)=(-7, -5);
            r = alg.Mult(a, b);
            Assert.IsTrue(r == a*b);

        }
    }
}