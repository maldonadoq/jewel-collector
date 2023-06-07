/// <summary>
/// Jewel class, responsible for creating Jewels on the map
/// </summary>
public class Jewel : ICell
{
    /// <summary>
    /// Variable that stores the Jewel score
    /// </summary>
    /// <value>10, 50, 100</value>
    public int score { get; set; }

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
    /// <value>" JR ", " JG ", " JB "</value>
    public string value { get; set; } = string.Empty;

    /// <summary>
    /// Color of the Jewel on the console
    /// </summary>
    /// <value>ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue</value>
    public ConsoleColor color { get; set; }

    /// <summary>
    /// Constructor of the Empty class
    /// </summary>
    /// <param name="_x">Position X on the map</param>
    /// <param name="_y">Position Y on the map</param>
    /// <param name="_value">Jewel type value, can be Red, Green or Blue</param>
    /// <param name="_score">Score of each Jewel by type</param>
    /// <param name="_color">Color of Jewel</param>
    public Jewel(int _x, int _y, string _value, int _score, ConsoleColor _color)
    {
        x = _x;
        y = _y;
        value = _value;
        score = _score;
        color = _color;
    }
}

