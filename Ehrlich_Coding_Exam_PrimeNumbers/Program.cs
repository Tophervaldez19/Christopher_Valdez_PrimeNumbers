// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Write("Input a Word:");

    var number = Convert.ToInt32(Console.ReadLine());

    //var number = Convert.ToInt32(input);

    if (number == 1)
    {
        Console.WriteLine("Neither prime nor composite.");
        continue;
    }

    if (number <= 0)
    {
        Console.WriteLine("Not a Prime Number");
        continue;
    }

    bool isPrime = true;

    for (int i = 2; i < number; i++)
    {
        if ((number % i) == 0)
        {
            isPrime = false;
            break;
        }
    }

    Console.WriteLine(isPrime ? "Prime number" : "Not a prime number");
    Console.WriteLine("~~~~~~~~~~~~~~~");
}
