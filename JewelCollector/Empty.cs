public class Empty : ICell
{
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;
    public ConsoleColor color { get; set; } = ConsoleColor.White;

    public Empty(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " -- ";
    }
}
