/// <summary>
/// Clase Jewel, encargada para crear Joyas en el mapa
/// </summary>
public class Jewel : ICell
{
    /// <summary>
    /// Variable que se encarga de almacenar el puntaje del Jewel
    /// </summary>
    /// <value>10, 50, 100</value>
    public int score { get; set; }

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
    /// <value>" JR ", " JG ", " JB "</value>
    public string value { get; set; } = string.Empty;

    /// <summary>
    /// Color de la Joya en la consola
    /// </summary>
    /// <value>ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue</value>
    public ConsoleColor color { get; set; }

    /// <summary>
    /// Constructor de la clase Empty
    /// </summary>
    /// <param name="_x">Posición X en el mapa</param>
    /// <param name="_y">Posición Y en el mapa</param>
    /// <param name="_value">Valor del tipo de Jewel, puede ser Rojo, Verde o Azul</param>
    /// <param name="_score">Puntaje de cada Jewel por el tipo</param>
    /// <param name="_color">Color del Jewel</param>
    public Jewel(int _x, int _y, string _value, int _score, ConsoleColor _color)
    {
        x = _x;
        y = _y;
        value = _value;
        score = _score;
        color = _color;
    }
}

