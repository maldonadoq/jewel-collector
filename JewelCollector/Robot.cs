public class Robot : ICell
{
    static List<Jewel> bag = new List<Jewel>();
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;

    public Robot(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " ME ";
    }
    public void move(Map _map, int _x, int _y)
    {
        try
        {
            if (_map.board[_x, _y] is Empty)
            {
                _map.addCell(new Empty(x, y));
                x = _x;
                y = _y;

                _map.addCell(this);
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

    public void collect(Map _map)
    {
        if (isJewel(_map, x, y - 1))
        {
            bag.Add((Jewel)_map.board[x, y - 1]);
            _map.addCell(new Empty(x, y - 1));
        }
        if (isJewel(_map, x, y + 1))
        {
            bag.Add((Jewel)_map.board[x, y + 1]);
            _map.addCell(new Empty(x, y + 1));
        }
        if (isJewel(_map, x - 1, y))
        {
            bag.Add((Jewel)_map.board[x - 1, y]);
            _map.addCell(new Empty(x - 1, y));
        }
        if (isJewel(_map, x + 1, y))
        {
            bag.Add((Jewel)_map.board[x + 1, y]);
            _map.addCell(new Empty(x + 1, y));
        }
    }

    public void printScore()
    {
        Console.WriteLine("Bag total items: " + bag.Count + " | Bag total value: " + bag.Sum(x => x.score));
    }
    public void print()
    {
        Console.Write(value);
    }

}