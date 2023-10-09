Console.WriteLine("Enter your exam point ");
int Point = Convert.ToInt32(Console.ReadLine()); 


    if (Point >= 0 && Point <= 100)
    {
        if (Point >= 91 && Point <= 100)
        {
            Console.WriteLine("A");
        }
        if (Point >= 81 && Point <= 90)
        {
            Console.WriteLine("B");
        }
        if (Point >= 71 && Point <= 80)
        {
            Console.WriteLine("C");
        }
        if (Point >= 61 && Point <= 70)
        {
            Console.WriteLine("D");
        }
        if (Point >= 51 && Point <= 60)
        {
            Console.WriteLine("E");
        }
        if (Point < 51)
        {
            Console.WriteLine("You failed the exam");
        }
    }
    else
    {
        Console.WriteLine("Point should be a number between 1 and 100");
    }
