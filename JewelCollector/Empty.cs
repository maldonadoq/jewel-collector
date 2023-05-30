public class Empty : ICell
{
    public int x { get; set; }
    public int y { get; set; }
    public string value { get; set; } = string.Empty;

    public Empty(int x, int y)
    {
        this.x = x;
        this.y = y;
        this.value = " -- ";
    }

    public void print()
    {
        Console.Write(this.value);
    }
}
