
/// <summary>
/// Interface ICell, esta interfaz es la encargada de tener las informaciones necesarias en cada celda del Mapa
/// </summary>
public interface ICell
{
    /// <summary>
    /// Posición X en el mapa
    /// </summary>
    int x { get; set; }

    /// <summary>
    /// Posición Y en el mapa
    /// </summary>
    int y { get; set; }

    /// <summary>
    /// Variable que almacena el string a imprimir por cada tipo de celula (Jewel, Obstacle, Robot)
    /// </summary>
    string value { get; set; }

    /// <summary>
    /// Color de la celula en la consola
    /// </summary>
    ConsoleColor color { get; set; }

    /// <summary>
    /// Función que se encarga de imprimir las celulas, todas las clases que hereden de esta heredaran
    /// esta función print, sin embargo cada clase puede re-implementar esta función
    /// </summary>
    public void print()
    {
        ConsoleColor current = Console.BackgroundColor;
        Console.BackgroundColor = color;
        Console.Write(value);
        Console.BackgroundColor = current;
    }
}
