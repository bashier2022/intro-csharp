namespace SortedContainers
{
    public class Program
    {
        static void Print(SortedNumbers sna)
        {
            for(int i=0; i<sna.Count(); i++)
            {
                Console.WriteLine($"SortedNumberArray({i}) = {sna.get(i)}");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            var sn = new SorteNumbersList();//SortedNumbersArray(100);

            sn.Add(8);
            sn.Add(10);
            sn.Add(2);
            Print(sn);
            int x = 50;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Print(sn);
            x = 2;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Print(sn);
            x = 10;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Print(sn);
            x = 8;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Print(sn);
            x = 8;
            Console.WriteLine($"after deleting {x}-------------------");
            sn.Remove(x);
            Print(sn);

        }
    }
}