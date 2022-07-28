// See https://aka.ms/new-console-template for more information
//method-performs a section of code when called, which is known
//as invoking a method. the benefit is it lets us reuse code
Console.WriteLine("Enter your name!");
String name = Console.ReadLine();
int age = 21;
if (1 == 1)
{
    singHappyBirthday(name,age);
}
static void singHappyBirthday(String name,int age)
{
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday dear "+name);
    Console.WriteLine("You are "+ age + " years old!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine();
}
Console.ReadKey();