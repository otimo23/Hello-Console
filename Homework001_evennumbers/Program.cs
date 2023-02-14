Console.Clear();
Console.WriteLine("enter number from 1 to 100: ");
int num = int.Parse(Console.ReadLine()!);
while (num > 1)
{
    if (num % 2 ==0)
    {
        Console.WriteLine($"even numbers - {num}");
    }
    else
    {
        num = num - 1;
        Console.WriteLine($"even numbers - {num}");

    }
num = num - 1;
}
