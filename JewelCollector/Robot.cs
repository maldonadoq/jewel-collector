public class Robot:ICell
{
    static List<int> bag = new List<int>();
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;
    public Robot(){}
    public void move(){}
    public void collect(){}
    public void update(){}
    public void print(){
        Console.Write("ME");
    }

}