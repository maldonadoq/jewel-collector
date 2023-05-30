public class Robot : ICell
{
    static List<Jewel> bag = new List<Jewel>();
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;
    public Robot(){}
    public void move(Map _map, int _x, int _y){}
    public void collect(){}
    public void update(){}
    public void print(){
        Console.Write("ME");
    }

}