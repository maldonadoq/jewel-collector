public class Map
{
    public ICell[,] board;
    public Map(int rows, int cols)
    {
        board = new ICell[rows, cols];
        initialize();
    }

    public void initialize()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = new Empty(i, j);
            }
        }
    }

    public void printMap()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j].print();
            }
            Console.Write("\n");
        }
    }

    public void addCell(ICell cell)
    {
        board[cell.x, cell.y] = cell;
    }

    public void addRandomCells(int _numbers, string _type)
    {
        Random rnd = new Random();
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        for (int i = 0; i < _numbers; i++)
        {
            int x = rnd.Next(0, rows);
            int y = rnd.Next(0, cols);

            if (_type.Equals("JR"))
            {
                addCell(new Jewel(x, y, " JR ", 100, ConsoleColor.Red));
            }
            else if (_type.Equals("JG"))
            {
                addCell(new Jewel(x, y, " JG ", 50, ConsoleColor.Green));
            }
            else if (_type.Equals("JB"))
            {
                addCell(new Jewel(x, y, " JB ", 10, ConsoleColor.Blue));
            }
            else if (_type.Equals("##"))
            {
                addCell(new Obstacle(x, y, " ## ", ConsoleColor.Cyan));
            }
            else if (_type.Equals("$$"))
            {
                addCell(new Obstacle(5, 9, " $$ ", ConsoleColor.DarkGray));
            }
        }
    }

    public bool hasJewels()
    {
        bool isJewel = false;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] is Jewel)
                {
                    isJewel = true;
                    break;
                }
            }
        }

        return isJewel;
    }
}