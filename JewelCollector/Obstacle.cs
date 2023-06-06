/// <summary>
/// Clase Obstacle, encargada para crear los Obstaculos en el mapa
/// </summary>
public class Obstacle : ICell
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
    /// <value>" ## ", " $$ "</value>
    public string value { get; set; } = string.Empty;

    /// <summary>
    /// Color de la celula en la consola
    /// </summary>
    /// <value>ConsoleColor.Cyan, ConsoleColor.DarkGray</value>
    public ConsoleColor color { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_x">Posición X en el mapa</param>
    /// <param name="_y">Posición Y en el mapa</param>
    /// <param name="_value">Valor del tipo de Obstacle, puede ser Arbol o Agua</param>
    /// <param name="_color">Color del Obstacle</param>
    public Obstacle(int _x, int _y, string _value, ConsoleColor _color)
    {
        x = _x;
        y = _y;
        value = _value;
        color = _color;
    }
}
