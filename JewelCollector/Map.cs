/// <summary>
/// Clase Map, encargado de almacenar toda las celulas en una array 2D
/// </summary>
public class Map
{
    /// <summary>
    /// Map's board
    /// </summary>
    public ICell[,] board;

    /// <summary>
    /// Class constructor where instance field board (Array 2D) and initialize this board
    /// </summary>
    /// <param name="_rows">Board rows ()</param>
    /// <param name="_cols">Board cols</param>
    public Map(int _rows, int _cols)
    {
        board = new ICell[_rows, _cols];
        initialize();
    }

    /// <summary>
    /// Initialize map with Empty cells;
    /// </summary>
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

    /// <summary>
    /// Metodo encargado de imprimir el mapa
    /// </summary>
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

    /// <summary>
    /// Add any cell to map
    /// </summary>
    /// <param name="_cell">Cell parameter (Jewel, Obstacle, Robot, Radioactive)</param>
    public void addCell(ICell _cell)
    {
        board[_cell.x, _cell.y] = _cell;
    }

    /// <summary>
    /// Add random cells to map
    /// </summary>
    /// <param name="_numbers">Number of cell type</param>
    /// <param name="_type">Cell type</param>
    public void addRandomCells(int _numbers, string _type)
    {
        Random rnd = new Random();
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        for (int i = 0; i < _numbers; i++)
        {
            int x = rnd.Next(0, rows);
            int y = rnd.Next(0, cols);

            if (_type.Equals(" JR "))
            {
                addCell(new Jewel(x, y, _type, 100, ConsoleColor.Red));
            }
            else if (_type.Equals(" JG "))
            {
                addCell(new Jewel(x, y, _type, 50, ConsoleColor.Green));
            }
            else if (_type.Equals(" JB "))
            {
                addCell(new Jewel(x, y, _type, 10, ConsoleColor.Blue));
            }
            else if (_type.Equals(" ## "))
            {
                addCell(new Obstacle(x, y, _type, ConsoleColor.Cyan));
            }
            else if (_type.Equals(" $$ "))
            {
                addCell(new Obstacle(x, y, _type, ConsoleColor.DarkGray));
            }
            else if (_type.Equals(" !! "))
            {
                addCell(new Radioactive(x, y));
            }
        }
    }

    /// <summary>
    /// Verify if map has Jewels
    /// </summary>
    /// <returns>Return True if there are jewels or False if not</returns>
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