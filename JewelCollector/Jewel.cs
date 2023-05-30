public class Jewel : ICell
{
    int score;
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;
    public Jewel(int _x, int _y, string _value, int _score){
        x = _x;
        y = _y;
        value = _value;
        score = _score;
    }
    public void print(){
        Console.Write(value);
    }
}

