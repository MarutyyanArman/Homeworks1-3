/*
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the temperature");
        int temperature = Convert.ToInt32(Console.ReadLine());
        if (temperature < 0)
        {
            Console.WriteLine("Cold");
        }
    }
}
*/

/*
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 13)
        {
            Console.WriteLine("You're a child");
        }
        else if (age > 19)
        {
            Console.WriteLine("You're an adult");
        }
        else
        {
            Console.WriteLine("You're a teenager");
        }
    }
}
*/

/*
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Convert Temperature: ");
        Console.WriteLine("1. F to C");
        Console.WriteLine("2. C to F");
        Console.WriteLine("Enter what you want to convert");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Enter the temperature in F");
            double far = Convert.ToDouble(Console.ReadLine());
            double cel = (5 * (far - 32)) / 9;
            Console.WriteLine("Your temperature is: ", cel);
        }
        else
        {
            Console.WriteLine("Enter the temperature in C");
            double cel = Convert.ToDouble(Console.ReadLine());
            double far = (5 * cel) / 9 + 32;
            Console.WriteLine($"Your temperature is: ", far);
        }
    }
}
*/

/*
using System;
class Program
{
    static void Main()
    {
        int[] arr = { 11, 4, 1, 5, 2 };
        int min = arr[0];
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Min num is: " + min);
        Console.WriteLine("Max num is: " + max);
    }
}
*/

/*
using System;
class program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Array.Reverse(arr);
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
*/

/*
using System;
class program
{
    static void Main()
    {
        int[] arr = {3, 4, 2, 1, 9};
        Array.Sort(arr);
        int len = arr.Length;
        Console.WriteLine(arr[len - 2]);
    }
}
*/

/*
using System;
class program
{
    static void Main(string[] args)
    {
        int[] arr1= { 5, 4, 1 };
        int[] arr2 = { 1, 2, 1 };
        int[] arr3 = { 0, 0, 0 };
        for (int i = 0; i < arr1.Length; i++)
        {
            arr3[i] = arr1[i] + arr2[i];
        }
        foreach (int j in arr3)
        {
            Console.WriteLine(j);
        }
    }
}
*/