/// <summary>
/// Obstacle class, responsible for creating the Obstacle on the map
/// </summary>
public class Obstacle : ICell
{
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
    /// <value>" ## ", " $$ "</value>
    public string value { get; set; } = string.Empty;

    /// <summary>
    /// Cell color on the console
    /// </summary>
    /// <value>ConsoleColor.Cyan, ConsoleColor.DarkGray</value>
    public ConsoleColor color { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_x">Position X on the map</param>
    /// <param name="_y">Position Y on the map</param>
    /// <param name="_value">Obstacle type value, can be Tree or Water</param>
    /// <param name="_color">Color of the Obstacle</param>
    public Obstacle(int _x, int _y, string _value, ConsoleColor _color)
    {
        x = _x;
        y = _y;
        value = _value;
        color = _color;
    }
}
