namespace SortedContainers
{
    public class Program 
    {
        static void Print(SortedNumbers sn)
        {
            Console.WriteLine($"Data Type = {sn.GetType()}, Data = {sn}");
        }

        static void FillRandoms(SortedNumbers sn, int n)
        {
            Console.WriteLine($"Filling with {n} Randoms ------in {sn.GetType()}-------------");

            Random rnd = new Random();
            int x;
            for(int i = 0; i < n; i++)
            {
                x = rnd.Next(0, 10);
                sn.Add(x);
            }
            Print(sn);
        }

        public static void TestingHomeWork(SortedNumbers sn)
        {
            sn.Add(10);
            sn.Add(2);
            sn.Add(8);
            Console.WriteLine(sn);
            int x = 50;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Console.WriteLine(sn);
            x = 2;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Console.WriteLine(sn);
            x = 10;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Console.WriteLine(sn);
            x = 8;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Console.WriteLine(sn);
            x = 8;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Console.WriteLine(sn);

            sn.Clear();
            FillRandoms(sn, 20);
            Console.WriteLine(sn);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            var snl = new SorteNumbersList(false);
            var sna = new SortedNumbersArray(100, true);

            Console.WriteLine("------------ Testing the Sorted List ----------------");
            TestingHomeWork(snl);

            Console.WriteLine("------------ Testing the Sorted Array ----------------");
            TestingHomeWork(sna);

           
        }
    }
}