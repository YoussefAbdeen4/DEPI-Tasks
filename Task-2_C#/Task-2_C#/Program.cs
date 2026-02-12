/*
 Question 1: Write a C# program that prints the first 10 multiples of 5 using a dowhile loop. 
*/
Console.WriteLine("Ans 1");
int i = 1;
do
{
    Console.Write(5 * i + " ");
} while (i++ < 10);

/*
 Question 2: Write a C# program that calculates the factorial of a given number.
*/
Console.WriteLine("\nAns 2");
int n = int.Parse(Console.ReadLine());
int f = n;
for (int j = 1; j < n; j++)
{
    f *= j;
}
Console.WriteLine(f);

/*
Question 3: Write a C# program that calculates and prints the sum of all even 
numbers between 1 and 100 using a for loop.
*/
Console.WriteLine("\nAns 3");
int sum = 0;
for (int k = 2; k <= 100; k += 2)
{
    sum += k;
}
Console.WriteLine(sum);

/*
Question 4: Write a C# program that prints the multiplication table for all numbers 
from 1 to 12.  
*/
Console.WriteLine("\nAns 4");
for (int table = 1; table <= 12; table++)
{
    for (int number = 1; number <= 12; number++)
    {
        Console.WriteLine($"{table} * {number} = {table * number}");
    }
    Console.WriteLine();
}

/*
Question 5: Write a C# program that prints all prime numbers between 1 and 500.  
*/
Console.WriteLine("\nAns 5");
Console.Write(2 + " ");
for (int num = 3; num <= 500; num++)
{
    bool f = true;
    for (int prime = 2; prime * prime <= num; prime++)
    {
        if (num % prime == 0) f = false;
    }
    if (f) Console.Write(num + " ");
}

/*
Question 6: Write a C# program that prints the following pattern using a loop: 
a 
ab 
abc 
abcd 
abcde  
*/
Console.WriteLine("\nAns 6");
string st = "abcde";
for (int s = 0; s < st.Length; s++)
{
    for (int c = 0; c <= s; c++)
    {
        Console.Write(st[c]);
    }
    Console.WriteLine();
}

/*
Question 7: Write a C# program that creates an array of 10 integers and finds the 
maximum and minimum elements in the array using a for loop. 
*/
Console.WriteLine("\nAns 7");
int[] nums = { 2, 4, 6, 8, 12, 16, 24, 32, 36, 40 };
int mn = 1000, mx = 0;
for (int index = 0; index < nums.Length; index++)
{
    if (nums[index] < mn) mn = nums[index];
    if (nums[index] > mx) mx = nums[index];
}
Console.WriteLine($"max is {mx} & min is {mn}");

/*
Question 8: Write a C# program that reverses the elements of an array and prints the 
reversed array. Use a for loop. 
*/
Console.WriteLine("\nAns 8");
int[] arr = { 2, 4, 6, 8, 12, 16, 24, 32, 36, 40 };
for (int idx = arr.Length - 1; idx >= 0; idx--)
{
    Console.Write(arr[idx] + " ");
}

/*
Question 9: Write a C# program that prompts the user to enter 5 integers and stores 
them in an array. Then, the program should print the array elements in reverse order 
using a while loop.  
*/
Console.WriteLine("\nAns 9");
int[] arr2 = new int[5];
for (int idx2 = 0; idx2 < arr2.Length; idx2++)
{
    arr2[idx2] = int.Parse(Console.ReadLine());
}
int idx3 = arr2.Length - 1;
while (idx3 >= 0)
{
    Console.Write(arr2[idx3--] + " ");
}

/*
Question 10: Write a C# program that prints all numbers from 1 to 100 but skips 
numbers that are multiples of 3 using a for loop. 
*/
Console.WriteLine("\nAns 10");
for (int m = 0; m <= 100; m++)
{
    Console.Write(m % 3 == 0 ? "" : m + " ");
}

/*
Question 11: Write a C# program that checks if a given number is prime. If it is 
prime, print "Prime" otherwise, print "Not Prime".  
*/
Console.WriteLine("\nAns 11");
int primeNum = int.Parse(Console.ReadLine());
if (primeNum == 0 || primeNum == 1)
{
    Console.WriteLine("Not Prime");
    return;
}
bool b = true;
for (int prime = 2; prime * prime <= primeNum; prime++)
{
    if (primeNum % prime == 0) b = false;
}
Console.WriteLine(b ? "Prime" : "Not Prime");

/*
Question 12: Write a C# program that finds and prints the first 20 prime numbers.  
*/
Console.WriteLine("\nAns 12");
int cnt = 0, pn = 2;
while (cnt < 20)
{
    bool flag = true;
    for (int p = 2; p * p <= pn; p++)
    {
        if (pn % p == 0) flag = false;
    }
    if (flag)
    {
        Console.Write(pn + " ");
        cnt++;
    }
    if (pn != 2) pn += 2;
    else pn++;
}

/*
Question 13: Write a C# program that prints the count of even/odd/positive/negative 
values in an given array. 
*/
Console.WriteLine("\nAns 13");
int size = int.Parse(Console.ReadLine());
int[] arr3 = new int[size];
int odd = 0, even = 0, pos = 0, neg = 0;
for (int idx = 0; idx < arr3.Length; idx++)
{
    arr3[idx] = int.Parse(Console.ReadLine());
}
for (int idx = 0; idx < arr3.Length; idx++)
{
    if (arr3[idx] % 2 == 0) even++;
    else odd++;
    if (arr3[idx] > 0) pos++;
    else if (arr3[idx] < 0) neg++;
}
Console.WriteLine($"even = {even} \nodd = {odd} \npositive = {pos} \nnegative = {neg}");

/*
Question 14: Write a C# program that generates the Fibonacci sequence up to a 
specified number of terms entered by the user.  
*/
Console.WriteLine("\nAns 14");
int y = int.Parse(Console.ReadLine());
int[] fib = new int[y + 1];
fib[1] = 0;
if (y > 1) fib[2] = 1;
for (int idx = 3; idx < fib.Length; idx++)
{
    fib[idx] = fib[idx - 1] + fib[idx - 2];
}

for (int idx = 1; idx < fib.Length; idx++)
{
    Console.Write(fib[idx] + " ");
}

/*
Question 15: Write a C# program that checks if an given array is palindrome or not.
*/
Console.WriteLine("\nAns 15");
int sz = int.Parse(Console.ReadLine());
int[] palindrome = new int[sz];
int l = 0,r = sz-1;
bool ck = true;
for (int idx = 0; idx < palindrome.Length; idx++)
{
    palindrome[idx] = int.Parse(Console.ReadLine());
}
for (int idx = 0;l<=r && l<sz; l++,r--)
{
    if(palindrome[l]!= palindrome[r])
    {
        ck = false; 
        break; 
    }
}
if (ck) Console.WriteLine("palindrome");
else Console.WriteLine("not palindrome");