public class Obstacle : ICell
{
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;

    public Obstacle(int x, int y, string value)
    {
        this.x = x;
        this.y = y;
        this.value = value;
    }

    public void print()
    {
    }
}
