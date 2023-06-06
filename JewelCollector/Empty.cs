/// <summary>
/// Clase Empty, la cual será usada para inicializar el mapa
/// </summary>
public class Empty : ICell
{
    /// <summary>
    /// Posición X en el mapa
    /// </summary>
    /// <value>[0,rows]</value>
    public int x { get; set; }

    /// <summary>
    /// Posición Y en el mapa
    /// </summary>
    /// <value>[0,cols]</value>
    public int y { get; set; }

    /// <summary>
    /// Variable que almacena el string a imprimir.
    /// </summary>
    /// <value>" -- "</value>
    public string value { get; set; } = string.Empty;

    /// <summary>
    /// Color de la celula en la consola
    /// </summary>
    /// <value>ConsoleColor.White</value>
    public ConsoleColor color { get; set; } = ConsoleColor.White;

    /// <summary>
    /// Constructor de la clase Empty
    /// </summary>
    /// <param name="_x">Posición X en el mapa</param>
    /// <param name="_y">Posición Y en el mapa</param>
    public Empty(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " -- ";
    }
}
