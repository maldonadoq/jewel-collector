public class Map
{
    ICell[,] board;
    public Map(int rows, int cols)
    {
        this.board = new ICell[rows, cols];
    }

    void printMap()
    {
        for (int i = 0; i < this.board.GetLength(0); i++)
        {
            for (int j = 0; j < this.board.GetLength(1); j++)
            {
                this.board[i, j].print();
            }
            Console.Write("\n");
        }
    }

    void addCell(ICell cell)
    {
        this.board[cell.x, cell.y] = cell;
    }
}