/// <summary>
/// JewelCollector class, class in charge of creating the levels, recognizing the events of the keyboard to move the game
/// </summary>
public class JewelCollector
{

    public static void Main()
    {
        // Create Robot
        Robot robot = new Robot(0, 0);
        int max_level = 30;

        bool playing;
        int initial = 0;
        ConsoleKeyInfo command;
        for (int level = 10; level <= max_level; level++)
        {
            // Playing level
            playing = true;

            // Create Map
            Map map = new Map(level, level);

            // Add random Cells
            map.addRandomCells(initial + 2, " JR ");
            map.addRandomCells(initial + 2, " JG ");
            map.addRandomCells(initial + 2, " JB ");
            map.addRandomCells(initial + 2, " ## ");
            map.addRandomCells(initial + 2, " $$ ");
            map.addRandomCells(initial, " !! ");

            // Add Robot
            robot.x = 0;
            robot.y = 0;
            map.addCell(robot);

            Console.WriteLine("Level: " + (initial + 1));
            map.printMap();
            robot.printScore();
            bool running = true;
            do
            {
                Console.Write("Enter the command: ");
                command = Console.ReadKey();
                Console.WriteLine();

                if (command.KeyChar.Equals('q'))
                {
                    playing = false;
                    break;
                }
                else if (command.KeyChar.Equals('w'))
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

                map.printMap();
                robot.printScore();
                running = (robot.energy > 0 && map.hasJewels());
            } while (running);

            if (!playing || robot.energy <= 0)
            {
                break;
            }

            initial += 1;
        }
    }
}