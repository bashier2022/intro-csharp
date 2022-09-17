namespace Tests
{
    public class Tests
    {
        Data.Algebra alg; 
        [SetUp]
        public void Setup()
        {
             alg = new Data.Algebra();
            Console.WriteLine("OK");
        }

        [Test]
        public void TestAdd()
        {            
            var r = alg.Add(5, 6);
            Assert.AreEqual(r, 5+6);
        }
        [Test]
        public void TestMultPostives()
        {
            int[] a = { 0, 7, 7, 1, 7, 1 };
            int[] b = { 5, 0, 5, 5, 1, 1 };
            int r;
            for (int i = 0; i< a.Length; i++)
            {
                r = alg.Mult(a[i], b[i]);
                Assert.AreEqual(r, a[i]*b[i]);
                Console.WriteLine($"{a[i]} * {b[i]} = {r}");
            }

        }

        [Test]
        public void TestMultNegatives()
        {
            int[] a = { 0, -7, 7, -7, -7, -1 };
            int[] b = { -5, 0, -5, 5, -5, -1 };
            int r;
            for(int i = 0; i< a.Length; i++)
            {
                r = alg.Mult(a[i], b[i]);
                Assert.AreEqual(r , a[i]*b[i]);
            }
            
        }
    }
}