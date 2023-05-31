public class JewelCollector
{

    public static void Main()
    {
        // Create Map
        Map map = new Map(10, 10);

        // Create Robot
        Robot robot = new Robot(0, 0);
        map.addCell(robot);

        // Add Obstacles
        //Water
        map.addCell(new Obstacle(5, 0, " ## "));
        map.addCell(new Obstacle(5, 1, " ## "));
        map.addCell(new Obstacle(5, 2, " ## "));
        map.addCell(new Obstacle(5, 3, " ## "));
        map.addCell(new Obstacle(5, 4, " ## "));
        map.addCell(new Obstacle(5, 5, " ## "));
        map.addCell(new Obstacle(5, 6, " ## "));
        //Tree
        map.addCell(new Obstacle(5, 9, " $$ "));
        map.addCell(new Obstacle(3, 9, " $$ "));
        map.addCell(new Obstacle(8, 3, " $$ "));
        map.addCell(new Obstacle(2, 5, " $$ "));
        map.addCell(new Obstacle(1, 4, " $$ "));

        // Add Jewels
        map.addCell(new Jewel(1,9," JR ", 100));
        map.addCell(new Jewel(8,8," JR ", 100));
        map.addCell(new Jewel(9,1," JG ", 50));
        map.addCell(new Jewel(7,6," JG ", 50));
        map.addCell(new Jewel(9,4," JB ", 10));
        map.addCell(new Jewel(2,1," JB ", 10));

        bool running = true;
        do
        {
            map.printMap();
            robot.printScore();

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