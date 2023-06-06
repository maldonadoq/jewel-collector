public class Radioactive : ICell
{
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;
    public ConsoleColor color { get; set; }
    public Radioactive(int _x, int _y, string _value, ConsoleColor _color)
    {
        x = _x;
        y = _y;
        value = _value;
        color = _color;
    }

}
