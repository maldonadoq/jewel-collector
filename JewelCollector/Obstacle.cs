public class Obstacle : ICell
{
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;

    public Obstacle(int _x, int _y, string _value)
    {
        x = _x;
        y = _y;
        value = _value;
    }

    public void print()
    {
        Console.Write(value);
    }
}
