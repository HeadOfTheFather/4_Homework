Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
    for (int i = num ; i > 0 ; i/= 10)
{
     int temp = i % 10;
     if (temp > 0)
     {
        if (num % temp == 0)
        {
            sum = sum + temp;
        }
     }
}
Console.WriteLine(sum);