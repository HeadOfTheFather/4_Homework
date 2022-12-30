Console.WriteLine("Enter the number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int temp = a;
    if (b == 0) 
    {
        Console.WriteLine("The answer is: 1"); 
    }

    else
    {
        for(int i = 1; i < b; i++) 
    {
        a *= temp;
    }
    Console.WriteLine("The answer is: ");
    Console.WriteLine(a);
    }