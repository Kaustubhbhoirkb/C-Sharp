// A Program To Find Prime No. And Count Of The Prime No. Between 2 No. Using Nested While Loop
class PrimeNo
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter First No. : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Second No. : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Prime numbers between " + "{0} and {1} are: ",a,b);
        int count = 0;
        while (a < b) // Traverse each number in the interval with the help of for loop
        {
            int flag = 0;
            int n = a, i = 2;
            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
                i++;
            }
            if (flag == 0 & n > 1)
            {
                count++;
                Console.WriteLine(n);
            }
            a++;
        }
        Console.WriteLine("Count: " + count);

    }
}

