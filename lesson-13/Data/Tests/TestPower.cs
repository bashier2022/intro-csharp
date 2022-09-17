
namespace Tests
{
    internal class TestPower
    {
        Data.Algebra alg;

        [SetUp]
        public void Setup()
        {
            alg = new Data.Algebra();
            Console.WriteLine("OK");
        }

        [Test]
        public void TestPow()
        {
            int[] a = { 2, 7, 0, -1, 7, -5, -2, 4, 0 };
            int[] b = { 3, 0, 5, 2, -1,  2, -4, 2, 0 };
            double r;
            for (int i = 0; i< a.Length; i++)
            {
                r = alg.Power(a[i], b[i]);
                Console.WriteLine($"Testing if : {a[i]} ^ {b[i]} = {r}");
                Assert.AreEqual(r, Math.Pow(a[i],b[i]));                
            }
        } 
    }
}
