bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    string? choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.Write("Enter first number: ");
            double firstAddNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter second number: ");
            double secondAddNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Result: {firstAddNumber + secondAddNumber}");
            break;
        case "2":
            Console.WriteLine("Enter first number: ");
            double firstSubtractNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter second number: ");
            double secondSubtractNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Result: {firstSubtractNumber - secondSubtractNumber}");
            break;
        case "3":
            Console.WriteLine("Enter first number: ");
            double firstMultiplyNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter second number: ");
            double secondMultiplyNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Result: {firstMultiplyNumber * secondMultiplyNumber}");
            break;
        case "4":
            Console.WriteLine("Enter first number: ");
            double firstDivideNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter second number: ");
            double secondDivideNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Result: {firstDivideNumber / secondDivideNumber}");
            break;
        case "5":
            Console.WriteLine("Exiting...");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    if (running)
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}