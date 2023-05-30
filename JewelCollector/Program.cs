public class JewelCollector
{

    public static void Main()
    {
        // Create map
        Map map = new Map(10, 10);

        // Add obstacle
        map.addCell(new Obstacle(2, 2, " ## "));


        bool running = true;

        do
        {
            map.printMap();

            Console.WriteLine("Enter the command: ");
            string command = Console.ReadLine();

            if (command.Equals("quit"))
            {
                running = false;
            }
            else if (command.Equals("w"))
            {

            }
            else if (command.Equals("a"))
            {

            }
            else if (command.Equals("s"))
            {

            }
            else if (command.Equals("d"))
            {

            }
            else if (command.Equals("g"))
            {

            }
        } while (running);
    }
}