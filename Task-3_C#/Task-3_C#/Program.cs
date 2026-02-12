namespace Task_3_C_
{
    internal class Program
    {
        /*
        Write a function that takes two integers and returns their sum.
        */
        static int sum(int x, int y) { 
            return x + y;
        }

        /*
        Write a function that takes an integer and returns true if the number is even, otherwise false. 
        */
        static bool isEven(int x) { 
            return x % 2 == 0;
        }

        /*
        Write a function that takes three integers and returns the largest one without using Math.Max.
        */
        static int max(int x, int y, int z) { 
            if(x>=y && x >= z)
            {
                return x;
            }
            if(y>=z && y >= x)
            {
                return y;
            }
            return z;
        }

        /*
        Write a recursive function that calculates the factorial of a given number. 
        */
        static int factorial(int x)
        {
            if(x == 1)
                return 1;
            return factorial(x-1)*x;
        }

        /*
         Write a recursive function that calculates base^exponent without using Math.Pow.
        */
        static int pow(int x, int y) { 
            if (y==1)
                return x;
            return pow(x, y - 1) * x;
        }

        /*
         Write a recursive function that counts the number of digits in a positive integer.
        */
        static int count(long x)
        {
            if (x < 10)
                return 1;
            return 1 + count(x/10);
        }

        /*
         Write a recursive function that returns the n-th Fibonacci number.
        */
        static List<int> memo = new List<int>();
        static int fibonacci(int x) {
            if (x <= 1)
                return memo[x];
            if (memo[x] != -1)
                return memo[x];
            memo[x] = fibonacci(x-1)+fibonacci(x-2);
            return memo[x];       
        }

        /*
        Write a recursive function that reverses a string.
        */
        static string stringReverse(string s,int size)
        {
            if (size == 0 )
                return ""+s[0];
            return s[size]+stringReverse(s,size-1);
        }

        /*
         Write a recursive function that calculates the sum of all numbers in an integer array, without using loops. 
        */
        static int arraySum(int[] arr,int i = 0)
        {
            if(i == arr.Length-1)
                return arr[i];
            return arr[i]+arraySum(arr,i+1);
        }

        /*
        Write a recursive function that counts the number of vowels in a string (ignore letter case). 
        */
        static int vowelsCount(string s, int i = 0)
        {
            if (i == s.Length-1)
                return "aeiou".Contains(s[i])?1:0;
            return ("aeiou".Contains(s[i]) ? 1 : 0) + vowelsCount(s, i + 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ans 1");
            Console.WriteLine(sum(4, 2));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 2");
            Console.WriteLine(isEven(4));
            Console.WriteLine(isEven(5));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 3");
            Console.WriteLine(max(5,12,8));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 4");
            Console.WriteLine(factorial(5));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 5");
            Console.WriteLine(pow(5, 3));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 6");
            Console.WriteLine(count(123456789));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 7");
            int n = int.Parse(Console.ReadLine());
            memo.Add(0);
            memo.Add(1);
            for (int i = 2; i <= n; i++) memo.Add(-1);
            Console.WriteLine(fibonacci(n));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 8");
            string s = "Youssef";
            Console.WriteLine(stringReverse(s,s.Length-1));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 9");
            int[] arr = { 1, 2, 3, 5 };
            Console.WriteLine(arraySum(arr));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ans 10");
            Console.WriteLine(vowelsCount("youssef"));
        }
    }
}
