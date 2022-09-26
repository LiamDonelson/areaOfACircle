while (true)
{
    Console.WriteLine("Please input the radius of a circle");

    string input = Console.ReadLine();
    double radius;
    
    if (!double.TryParse(input, out radius))
    {
        Console.WriteLine("Please enter a numerical value");
        continue;
    }
    
    Console.WriteLine("Radius: " + radius);
    double area = Math.PI * radius * radius;
    Console.WriteLine("Area: " + area);
    
    
    Console.WriteLine("Would you like to measure the area of another Circle?(Y/N)");
    string Response = Console.ReadLine().ToLower();
    if (Response == "y")
    {
        continue;
    }
    else
        Console.WriteLine("Thanks for trying!");
    break;
}
