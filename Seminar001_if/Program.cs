Console.WriteLine("Enter number A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int B = int.Parse(Console.ReadLine());
if (A > B)
{
    Console.WriteLine("A = max"); 
    Console.WriteLine("B = min"); 
} 

if (B > A)
{
    Console.WriteLine("A = min"); 
    Console.WriteLine("B = max");
}
if (A ==B)
{
    Console.WriteLine("A = B"); 

}