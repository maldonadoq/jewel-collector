public class JewelCollector
{

    public static void Main()
    {
        // Create Map
        Map map = new Map(10, 10);

        // Add Obstacles
        map.addCell(new Obstacle(5, 0, " ## "));
        map.addCell(new Obstacle(5, 1, " ## "));
        map.addCell(new Obstacle(1, 0, " ## "));
        // Create Robot
        Robot robot = new Robot(0, 0);
        map.addCell(robot);

        Jewel jewel = new Jewel(1,1," JR ", 100);
        map.addCell(jewel);

        bool running = true;
        do
        {
            map.printMap();

            Console.WriteLine("Enter the command: ");
            string command = Console.ReadLine() ?? string.Empty;

            if (command.Equals("quit"))
            {
                running = false;
            }
            else if (command.Equals("w"))
            {
                robot.move(map, robot.x - 1, robot.y);
            }
            else if (command.Equals("a"))
            {
                robot.move(map, robot.x, robot.y - 1);
            }
            else if (command.Equals("s"))
            {
                robot.move(map, robot.x + 1, robot.y);
            }
            else if (command.Equals("d"))
            {
                robot.move(map, robot.x, robot.y + 1);
            }
            else if (command.Equals("g"))
            {
                robot.collect(map);
            }
        } while (running);
    }
}