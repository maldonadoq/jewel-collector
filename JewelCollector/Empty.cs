public class Empty : ICell
{
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;

    public Empty(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " -- ";
    }

    public void print()
    {
        Console.Write(value);
    }
}
