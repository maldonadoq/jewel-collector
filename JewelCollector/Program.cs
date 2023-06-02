public class JewelCollector
{

    public static void Main()
    {
        // Create robot
        Robot robot = new Robot(0, 0);
        int max_level = 10;

        for (int level = 10; level <= max_level; level++)
        {
            // Create Map
            Map map = new Map(level, level);

            // Add Robot
            robot.x = 0;
            robot.y = 0;
            map.addCell(robot);

             // Add Obstacles
            //Water
            map.addCell(new Obstacle(5, 0, " ## ", ConsoleColor.Cyan));
            map.addCell(new Obstacle(5, 1, " ## ", ConsoleColor.Cyan));
            map.addCell(new Obstacle(5, 2, " ## ", ConsoleColor.Cyan));
            map.addCell(new Obstacle(5, 3, " ## ", ConsoleColor.Cyan));
            map.addCell(new Obstacle(5, 4, " ## ", ConsoleColor.Cyan));
            map.addCell(new Obstacle(5, 5, " ## ", ConsoleColor.Cyan));
            map.addCell(new Obstacle(5, 6, " ## ", ConsoleColor.Cyan));
            //Tree
            map.addCell(new Obstacle(5, 9, " $$ ", ConsoleColor.DarkGray));
            map.addCell(new Obstacle(3, 9, " $$ ", ConsoleColor.DarkGray));
            map.addCell(new Obstacle(8, 3, " $$ ", ConsoleColor.DarkGray));
            map.addCell(new Obstacle(2, 5, " $$ ", ConsoleColor.DarkGray));
            map.addCell(new Obstacle(1, 4, " $$ ", ConsoleColor.DarkGray));

            // Add Jewels
            map.addCell(new Jewel(1, 9, " JR ", 100, ConsoleColor.Red));
            map.addCell(new Jewel(8, 8, " JR ", 100, ConsoleColor.Red));
            map.addCell(new Jewel(9, 1, " JG ", 50, ConsoleColor.Green));
            map.addCell(new Jewel(7, 6, " JG ", 50, ConsoleColor.Green));
            map.addCell(new Jewel(9, 4, " JB ", 10, ConsoleColor.Blue));
            map.addCell(new Jewel(2, 1, " JB ", 10, ConsoleColor.Blue));

            /* map.addRandomCells(3, "JR");
            map.addRandomCells(3, "JG");
            map.addRandomCells(3, "JB");
            map.addRandomCells(10, "##");
            map.addRandomCells(5, "$$"); */

            bool running = true;
            do
            {
                map.printMap();
                robot.printScore();

                Console.Write("Enter the command: ");
                ConsoleKeyInfo command = Console.ReadKey();
                Console.WriteLine();

                if (command.KeyChar.Equals('w'))
                {
                    robot.move(map, robot.x - 1, robot.y);
                }
                else if (command.KeyChar.Equals('a'))
                {
                    robot.move(map, robot.x, robot.y - 1);
                }
                else if (command.KeyChar.Equals('s'))
                {
                    robot.move(map, robot.x + 1, robot.y);
                }
                else if (command.KeyChar.Equals('d'))
                {
                    robot.move(map, robot.x, robot.y + 1);
                }
                else if (command.KeyChar.Equals('g'))
                {
                    robot.collect(map);
                }

                running = map.hasJewels();
            } while (running);
        }
    }
}