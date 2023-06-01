public interface ICell
{
    int x { get; set; }
    int y { get; set; }
    string value { get; set; }
    ConsoleColor color { get; set; }

    public void print(){
        ConsoleColor current = Console.BackgroundColor;
        Console.BackgroundColor = color;
        Console.Write(value);
        Console.BackgroundColor = current;
    }
}
