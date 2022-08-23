namespace Shapes
{

    internal class Program
    {
        static void PaintPrice(AbstractShape shape)
        {
            var priceForLiter = 1337.0;
            //var surface = shape.Area();
            //var vol = surface * 1e-4;
            //var price = vol * priceForLiter;
            //Console.WriteLine($"paint {shape.Name} will cost {price}");

            Console.WriteLine($"paint {shape.Name} will cost {shape.PaintVolume(0.01) * priceForLiter}");
        }

        static void Blow(List<AbstractShape> list_of_Shapes, double factor)
        {
            //write a function that gets a list of shapes and will change each one to be bigger by a factor
            // Blow(lst, 2.5)   will make each shape in the list bigger by 2.5

            foreach (var shape in list_of_Shapes)
            {
                shape.Scale(factor);
            }
        }

        static Dictionary<string, List<AbstractShape>> CreateShapeDict(List<AbstractShape> list_of_Shapes)
        {
            // write a function that gets a list of Shapes and will return a dictionary of categories.
            // assume it gets a list of c1, s2, c3, c4, s5   -  3 circles and 2 squares.

            Dictionary<string, List<AbstractShape>> dict = new();

            List<AbstractShape> lst;
            foreach (var shape in list_of_Shapes)
            {
                string n = shape.Name;

                if (dict.ContainsKey(n))
                {
                    dict[n].Add(shape);
                }
                else
                {
                    dict.Add(n, new List<AbstractShape>() { shape });
                }
            }
            return dict;
        }

        static void Paint(List<AbstractShape> lst)
        {
            foreach (var shape in lst)
            {
                PaintPrice(shape);
            }
        }

        static void TestDictionary(Dictionary<string, List<AbstractShape>> dict)
        {
            Console.WriteLine("----------------testing the created Dictinary---------------");
            foreach (var item in dict)
            {
                Console.WriteLine($"the {item.Key} has {item.Value.Count} items");
                foreach (var ob in item.Value)
                {
                    Console.WriteLine($"a {ob.Name} with an area {ob.Area()} an the Diminsions {ob.Dimentions()}");
                }
            }
        }
        static void Main(string[] args)
        {
            var s = new Square(4);
            PaintPrice(s);

            var c = new Circle(4);
            PaintPrice(c);

            Console.WriteLine("-------------------------");
            var shapes = new List<AbstractShape>() { new Circle(3), new Square(4), new Circle(5), new Ring(4, 5), new Sphere(2.5), new Square(1) };
            Paint(shapes);
            Console.WriteLine("----------after scaling---------------");
            Blow(shapes, 2);
            Paint(shapes);

            Dictionary<string, List<AbstractShape>> dict = CreateShapeDict(shapes);

            TestDictionary(dict);

        }
    }
}