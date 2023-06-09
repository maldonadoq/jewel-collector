/// <summary>
/// Robot class, responsible for the functionality of the game
/// </summary>
public class Robot : ICell
{
    /// <summary>
    /// Robot energy
    /// </summary>
    /// <value>5</value>
    public int energy { get; set; }

    /// <summary>
    /// List that will store all collected jewel
    /// </summary>
    /// <typeparam name="Jewel"></typeparam>
    /// <returns></returns>
    static List<Jewel> bag = new List<Jewel>();

    /// <summary>
    /// Position X on the map
    /// </summary>
    /// <value>[0,rows]</value>
    public int x { get; set; }

    /// <summary>
    /// Position Y on the map
    /// </summary>
    /// <value>[0,cols]</value>
    public int y { get; set; }

    /// <summary>
    /// Variable that stores the string to print.
    /// </summary>
    /// <value>" ME "</value>
    public string value { get; set; } = string.Empty;

    /// <summary>
    /// Cell color on the console
    /// </summary>
    /// <value>ConsoleColor.Black</value>
    public ConsoleColor color { get; set; } = ConsoleColor.Black;

    /// <summary>
    /// Constructor of the Robot class
    /// </summary>
    /// <param name="_x">Position X on the map</param>
    /// <param name="_y">Position Y on the map</param>
    public Robot(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " ME ";
        energy = 5;
    }

    /// <summary>
    /// Method of moving the robot inside the map.
    /// </summary>
    /// <param name="_map">Map where the robot will move</param>
    /// <param name="_x">Position X of the map where the robot will move</param>
    /// <param name="_y">Position Y of the map where the robot will move</param>
    public void move(Map _map, int _x, int _y)
    {
        int[,] coord = { { _x, _y - 1 }, { _x, _y + 1 }, { _x - 1, _y }, { _x + 1, _y } };
        try
        {
            if (_map.board[_x, _y] is Empty)
            {
                _map.addCell(new Empty(x, y));
                x = _x;
                y = _y;
                _map.addCell(this);

                //verify radioactive
                bool _radioactive = false;
                for (int i = 0; i < coord.GetLength(0); i++)
                {
                    if (isType(_map, coord[i, 0], coord[i, 1], 3))
                    {
                        _radioactive = true;
                        verifyEnergy(_map.board[coord[i, 0], coord[i, 1]].value);
                    }
                }

                if (!_radioactive)
                {
                    energy = energy - 1;
                }
            }
            else if (_map.board[_x, _y] is Radioactive)
            {
                _map.addCell(new Empty(x, y));
                x = _x;
                y = _y;
                _map.addCell(this);
                energy = energy - 30;
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }

    }

    /// <summary>
    /// Method that determines if a position on the map is of a certain type.
    /// </summary>
    /// <param name="_map">Map on which the position will be evaluated (_x, _y)</param>
    /// <param name="_x">Position X on the map where we’ll check the cell type</param>
    /// <param name="_y">Position Y on the map where we’ll check the cell type</param>
    /// <param name="_type">Variable that determines the type of cell (1: Jewel, 2: Obstacle, 3: Radiactive)</param>
    /// <returns>true or false</returns>
    public bool isType(Map _map, int _x, int _y, int _type)
    {
        try
        {
            if (_type == 1 && _map.board[_x, _y] is Jewel)
            {
                return true;
            }
            else if (_type == 2 && _map.board[_x, _y] is Obstacle)
            {
                return true;
            }
            else if (_type == 3 && _map.board[_x, _y] is Radioactive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (IndexOutOfRangeException)
        {
            return false;
        }
    }

    /// <summary>
    /// Method to increase or decrease energy according to last value
    /// </summary>
    /// <param name="_value">Indicates the value of the map (" JB ", " $$ ", " !! ")</param>
    public void verifyEnergy(string _value)
    {
        if (_value == " JB ")
        {
            energy = energy + 5;
        }
        else if (_value == " $$ ")
        {
            energy = energy + 3;
        }
        else if (_value == " !! ")
        {
            energy = energy - 10;
        }
    }

    /// <summary>
    /// Method for collecting Jewels and energy of Trees
    /// </summary>
    /// <param name="_map">Map where we will check by pressing the "g" key (North, South, East, West)</param>
    public void collect(Map _map)
    {
        // Ddirections by which to verify
        int[,] coord = { { x, y - 1 }, { x, y + 1 }, { x - 1, y }, { x + 1, y } };

        for (int i = 0; i < coord.GetLength(0); i++)
        {
            // Jewel check
            if (isType(_map, coord[i, 0], coord[i, 1], 1))
            {
                bag.Add((Jewel)_map.board[coord[i, 0], coord[i, 1]]);
                verifyEnergy(_map.board[coord[i, 0], coord[i, 1]].value);
                _map.addCell(new Empty(coord[i, 0], coord[i, 1]));
            }

            // Obstacle Check
            if (isType(_map, coord[i, 0], coord[i, 1], 2))
            {
                verifyEnergy(_map.board[coord[i, 0], coord[i, 1]].value);
            }
        }
    }

    /// <summary>
    /// Method for printing the number of items, total value and accumulated energy on the console
    /// </summary>
    public void printScore()
    {
        Console.WriteLine("Bag total items: " + bag.Count + " | Bag total value: " + bag.Sum(x => x.score) + " | Energy: " + energy);
    }
}