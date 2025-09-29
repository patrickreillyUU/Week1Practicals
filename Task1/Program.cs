void Task1()
{
    string name;
    int age;
    Console.WriteLine("Please enter your name:");
    name = Console.ReadLine();

    Console.WriteLine("Please enter your age:");
    age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Hello {name}, you will be {age + 5} in 5 years");


}
Task1();



