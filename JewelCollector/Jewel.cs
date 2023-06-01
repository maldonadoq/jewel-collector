public class Jewel : ICell
{
    public int score;
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;
    public ConsoleColor color { get; set; }
    public Jewel(int _x, int _y, string _value, int _score, ConsoleColor _color)
    {
        x = _x;
        y = _y;
        value = _value;
        score = _score;
        color = _color;
    }
}

