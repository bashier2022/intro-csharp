namespace lesson_03
{
    public class Program
    {
        static int[,] Create_Matrix()
        {
            int[,] A =
            {               
                { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0},
                { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1},
                { 0, 0, 0, 1, 0, 0, 0, 0, 1, 1},
                { 1, 0, 1, 0, 1, 1, 0, 0, 0, 1},
                { 0, 1, 0, 1, 0, 0, 1, 1, 0, 0},
                { 0, 1, 0, 0, 0, 1, 0, 1, 0, 0}                
            };
            return A;
        }
        static void Main(string[] args)
        {

            Game game = new Game(10,10);
            int[,] matrix = Create_Matrix();

            game.Fill_Board(matrix);
            for(int i = 0; i < 10; i++)
            {
                game.print();
                game.next_generation();
                Console.Write("Go  : [enter]");
                Console.ReadLine();
            }

        }
    }
}