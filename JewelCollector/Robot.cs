public class Robot : ICell
{
    static List<Jewel> bag = new List<Jewel>();
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;

    public Robot(int _x, int _y)
    {
        x = _x;
        y = _y;
        value = " ME ";
    }
    public void move(Map _map, int _x, int _y) 
    {
        _map.addCell(new Empty(x,y));
        x = _x;
        y = _y;
        
        _map.addCell(this);
    }
    public void collect() { }
    public void update() {
    }
    public void print()
    {
        Console.Write(value);
    }

}