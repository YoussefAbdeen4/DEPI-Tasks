/*
 Question 1: Write a C# program that prints your name, age, and favorite hobby on separate lines.
 */
Console.WriteLine("Ans Q1");
Console.WriteLine("Nmae : Youssef Abdeen Ramadan\n"
    + "Age : 21\n"
    + "Fave hoppy : Watching animy");

/*
 Question 2: Write a C# program that declares variables of different data types (int, double, string, bool)
 and assigns them values. Then, print these values to the console.
 */

Console.WriteLine("\nAns Q2");
int x = 4;
double d = 4.4;
string s = "Monky D. Luffy";
bool flag = true;
Console.WriteLine(x + "\n" + d + "\n" + s + "\n" + flag);

/*
 Question 3: Write a C# program that converts a temperature value from Celsius to Fahrenheit. 
 The Celsius temperature should be stored in a variable.
 */

Console.WriteLine("\nAns Q3");
Console.Write("Enter temperature in Celsius : ");
float c = float.Parse(Console.ReadLine());
Console.WriteLine($"{c}°C = {(c * 9 / 5) + 32}°F");

/*
 Question 4: Write a C# program that takes two numbers as input and performs thefollowing operations:
 addition, subtraction, multiplication, and division. Print the results of each operation.
 */

Console.WriteLine("\nAns Q4");
Console.Write("Enter first number : ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter scound number : ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("\nSum = " + (num1 + num2)
    + "\nSub = " + (num1 - num2)
    + "\nMult = " + (num1 * num2)
    + "\nDiv = " + ((double)num1 / num2));

/*
 Question 5: Write a C# program that calculates the area of a rectangle. 
 The program should prompt the user to enter the length and width of the rectangle,
 and then calculate and display the area.
 */

Console.WriteLine("\nAns Q5");
Console.Write("Enter lengh : ");
int l = int.Parse(Console.ReadLine());
Console.Write("Enter width : ");
int w = int.Parse(Console.ReadLine());
Console.WriteLine("Area  = " + (l * w));

/*
 Question 6: Write a C# program that takes an integer as input and checks if it is even or odd. 
 Print a message indicating whether the number is even or odd.
 */

Console.WriteLine("\nAns Q6");
Console.Write("Enter the number : ");
int num = int.Parse(Console.ReadLine());
switch (num % 2)
{
    case 0:
        Console.WriteLine("Even");
        break;
    case 1:
        Console.WriteLine("Odd");
        break;
}

/*
 Question 7: Write a C# program that prompts the user to enter their age. 
 If the age is 18 or older, print "You are eligible to vote." 
 If the age is less than 18, print "You are not eligible to vote."
 */

Console.WriteLine("\nAns Q7");
Console.Write("Enter the age : ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine(age >= 18 ? "You are eligible to vote." : "You are noteligible to vote.");

/*
Question 8: Write a C# program that simulates a simple grading system.
The program should prompt the user to enter a score (0-100), 
and then print the corresponding grade based on the following criteria:
90-100: A
80-89: B
70-79: C
60-69: D
Below 60: F
 */

Console.WriteLine("\nAns Q8");
Console.Write("Enter the grad : ");
int g = int.Parse(Console.ReadLine());
if (g < 0)
{
    Console.WriteLine("Illogical....!");
}
else if (g <= 100 && g >= 90)
{
    Console.WriteLine("A");
}
else if (g < 90 && g >= 80)
{
    Console.WriteLine("B");
}
else if (g < 80 && g >= 70)
{
    Console.WriteLine("C");
}
else if (g < 70 && g >= 60)
{
    Console.WriteLine("D");
}
else
    Console.WriteLine("F");