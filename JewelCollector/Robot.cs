public class Robot : ICell
{
    public int energy;
    static List<Jewel> bag = new List<Jewel>();
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;
    public ConsoleColor color { get; set; } = ConsoleColor.Black;

    public Robot(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " ME ";
        energy = 5;
    }
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
                    
                    if (isRadioactive(_map, coord[i, 0], coord[i, 1]))
                    {
                        Console.WriteLine("olaaa" + _map.board[coord[i, 0], coord[i, 1]]);
                        _radioactive = true;
                        verifyEnergy(_map.board[coord[i, 0], coord[i, 1]].value);
                    }
                }

                if(!_radioactive) {
                    energy = energy - 1;
                }
            }
            if(_map.board[_x,_y] is Radioactive) {
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

    public bool isJewel(Map _map, int _x, int _y)
    {
        try
        {
            if (_map.board[_x, _y] is Jewel)
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

    public bool isRadioactive(Map _map, int _x, int _y)
    {
        try
        {
            if (_map.board[_x, _y] is Radioactive)
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

    public bool isObstacle(Map _map, int _x, int _y)
    {
        try
        {
            if (_map.board[_x, _y] is Obstacle)
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

    public void verifyEnergy(string _value)
    {
        if (_value == " JB ")
        {
            energy = energy + 5;
        }
        if (_value == " $$ ")
        {
            energy = energy + 3;
        }
        if (_value == " !! ")
        {
            energy = energy - 10;
        }
    }

    public void collect(Map _map)
    {
        int[,] coord = { { x, y - 1 }, { x, y + 1 }, { x - 1, y }, { x + 1, y } };

        for (int i = 0; i < coord.GetLength(0); i++)
        {
            if (isJewel(_map, coord[i, 0], coord[i, 1]))
            {
                bag.Add((Jewel)_map.board[coord[i, 0], coord[i, 1]]);
                verifyEnergy(_map.board[coord[i, 0], coord[i, 1]].value);
                _map.addCell(new Empty(coord[i, 0], coord[i, 1]));
            }

            if (isObstacle(_map, coord[i, 0], coord[i, 1]))
            {
                verifyEnergy(_map.board[coord[i, 0], coord[i, 1]].value);
            }
        }
    }

    public void printScore()
    {
        Console.WriteLine("Bag total items: " + bag.Count + " | Bag total value: " + bag.Sum(x => x.score) + " | Energy: " + energy);
    }
}