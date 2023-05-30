public class Map
{
    ICell[,] board;
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
}