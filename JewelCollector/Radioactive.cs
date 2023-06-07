/// <summary>
/// Radioactive class, responsible for creating Radioactive on the map
/// </summary>
public class Radioactive : ICell
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
    /// <value>" !! "</value>
    public string value { get; set; } = string.Empty;

    /// <summary>
    /// Cell color on the console
    /// </summary>
    /// <value>ConsoleColor.Yellow</value>
    public ConsoleColor color { get; set; } = ConsoleColor.Yellow;

    /// <summary>
    /// Constructor of the Radioactive class
    /// </summary>
    /// <param name="_x">Position X on the map</param>
    /// <param name="_y">Position Y on the map</param>
    public Radioactive(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " !! ";
    }

}
