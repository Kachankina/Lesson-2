//int num = new Random().Next(99,1000);
//int a1 = (num/100);
//int a2 = (num%10);
//Console.WriteLine($"Our random number is: {num}");
//Console.Write(a1*10 + a2 +"\n");
//Console.Write($"Our random number is: {num}");

// Console.WriteLine("Insert number");
// int num = int.Parse(Console.ReadLine()!);
// if (num%7==0 & num%23==0)
// {
//    Console.WriteLine($"Our number divides on 7 and 23 {num}");
// }
// else
// {
//    Console.WriteLine($"Our number does not divide on 7 and 23 {num}");
// }

Console.WriteLine("Insert number 1:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Insert number 2:");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine($"First number {num1} is square of {num2}");
    Console.WriteLine($"First number {num2} is square of {num1}");
}
else
{
    Console.WriteLine("Numbers don't divide");
}






