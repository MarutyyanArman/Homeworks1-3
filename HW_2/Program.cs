/*  Write a function To find the middle element(s) of a list 

using System;
using System.Collections.Generic;

class Program
{
   static List<int> FindMidNums(List<int> numbers)
    {
        int midIndex = numbers.Count / 2;
        List<int> midNums = new List<int>();

        // The count is even, then add 2 elements from the middle
        if (numbers.Count % 2 == 0)
        {
            midNums.Add(numbers[midIndex]);
            midNums.Add(numbers[midIndex - 1]);
        }
        // The count is odd, then add 1 element
        else
        {
            midNums.Add(numbers[midIndex]);

        }

        return midNums;
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 8, 7, 5, 10, 1, 4, 3 };
        List<int> middleElements = FindMidNums(numbers);
        Console.WriteLine("The Middle Elements of The List are:");
        foreach (int element in middleElements)
        {
            Console.WriteLine(element);
        }
    }
}
*/


/* Write a function that takes in a list of integers and returns the largest integer in the list. 

using System;
using System.Collections.Generic;
class Program
{
    static int MaxNum(List<int> numbers)
    {
        int maxNum = numbers[0]; 
        foreach (int num in numbers)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        return maxNum;
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 7, 3 };
        int maxNum = MaxNum(numbers);
        Console.WriteLine("The max num is: " + maxNum);
    }
}
*/