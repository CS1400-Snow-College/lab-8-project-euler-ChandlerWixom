// Chandler Wixom 3/26/2025 Lab 8 Project Euler
//1,2,4,5,6


// intro
using System.Runtime.InteropServices;
do
{
Console.Clear();
int problem = ReadNumber(5, 1);
Console.Clear();

switch (problem)
{
    case 1:
        Multiples();

        break;
    
    case 2:
        EvenFibonacci();

        break;

    case 3:
        PalindromeProduct();

        break;

    case 4:
        SmallestMultiple();

        break;

    case 5:
        SquareDifference();

        break;
    
}
Console.ReadKey(true);
} while (true);

//1
static void Multiples()
{

}

// 2
static void EvenFibonacci()
{

}

//3
static void PalindromeProduct()
{

}

//4
static void SmallestMultiple()
{

}

//5
static void SquareDifference()
{

}

// Writes the into stuff
void WriteIntro()
{
Console.WriteLine("This is a program that will demonstrate the solution to five Project Euler problems");
Console.Write("1. Multiples of 3 or 5\n2. Even Fibonacci Numbers\n3. Largest Palindrome Product\n4. Smallest Multiple\n5. Sum Square Difference\nPlease select a problem to be demonstrated: ");
}

// reads int between the max and min if fail rewrites intro and tries again
 int ReadNumber(int max, int min)
{
    do
    {
        
    WriteIntro();
   bool pass = Int32.TryParse(Console.ReadLine() , out int number);

    if (!pass)
    {
        Console.Clear();
        Console.SetCursorPosition(50,6);
    Console.WriteLine("Hmm?");
    Console.SetCursorPosition(0,0);
    }
   else if (number < min || number > max)
   {
    Console.Clear();
    Console.SetCursorPosition(50,6);
    Console.WriteLine("Sorry Out of Range");
    Console.SetCursorPosition(0,0);
   }
   else 
   {
    return number;
   }


    } while (true);
}