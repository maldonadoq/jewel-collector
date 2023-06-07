
/// <summary>
/// Interface ICell, this interface is responsible for having the necessary information in each cell of the Map
/// </summary>
public interface ICell
{
    /// <summary>
    /// Position X on the map
    /// </summary>
    int x { get; set; }

    /// <summary>
    /// Position Y on the map
    /// </summary>
    int y { get; set; }

    /// <summary>
    /// Variable that stores the string to print for each type of cell (Jewel, Obstacle, Robot)
    /// </summary>
    string value { get; set; }

    /// <summary>
    /// Cell color on the console
    /// </summary>
    ConsoleColor color { get; set; }

    /// <summary>
    /// Function that prints cells, all classes that inherit from it, will inherit the print function, however each class can re-implement it
    /// </summary>
    public void print()
    {
        ConsoleColor current = Console.BackgroundColor;
        Console.BackgroundColor = color;
        Console.Write(value);
        Console.BackgroundColor = current;
    }
}
