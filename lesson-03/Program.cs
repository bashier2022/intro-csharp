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

        static string[] Create_String_Array()
        {
            string[] A =
            {
                "0110000000",
                "0111000000",
                "0000001000",
                "0000011000",
                "0000000000",
                "0000000111",
                "0001000011",
                "1010110001",
                "0101001100",
                "0100010100",
            };
            return A;
        }

        static void Fill_Life_Board(Game game)
        {
            string[] A = Create_String_Array();

            for (int i = 0; i < A.Length; i++)
            {
                string row_st = A[i];
                Console.WriteLine($"r({i}) =: {row_st}");
                for (int j = 0; j < row_st.Length; j++)
                {
                    if (row_st[j] == '1')
                    {
                        game.turnon(i+1, j+1); 
                    }
                    else
                    {
                        game.turnoff(i+1, j+1);
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            Game game = new Game(10,10);
            int[,] matrix = Create_Matrix();

            //game.Fill_Board(matrix);
            //game.Fill_Board_From_Array_of_strings(Create_String_Array());
            Fill_Life_Board(game);
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