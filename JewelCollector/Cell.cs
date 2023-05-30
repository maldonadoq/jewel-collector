public interface ICell
{
    int x { get; set; }
    int y { get; set; }
    string value { get; set; }

    public void print();
}
