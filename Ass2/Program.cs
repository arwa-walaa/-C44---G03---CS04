using System;

class Program
{
    static void Main()
    {
        //#region 1. Write a program that allows the user to insert an integer then print all numbers between 1 to that number

        //Console.Write("Enter Number: ");
        //int num = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= num; i++)
        //{
        //    Console.Write(i +", ");
        //}

        //#endregion

        //#region 2. Write a program that allows the user to insert an integer then print a multiplication table up to 12

        //Console.Write("Enter Number: ");
        //int num = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= 12; i++)
        //{
        //    Console.Write(num * i + " ");
        //}

        //#endregion

        //#region 3. Write a program that allows to user to insert number then print all even numbers between 1 to this number

        //Console.Write("Enter Number: ");
        //int num = int.Parse(Console.ReadLine());

        //for (int i = 2; i <= num; i += 2)
        //{
        //    Console.Write(i + " ");
        //}

        //#endregion

        //#region 4. Write a program that takes two integers then prints the power.

        //Console.Write("Enter Tow Number to Calculate the Power  ");
        //int num = int.Parse(Console.ReadLine());
        //int num2 = int.Parse(Console.ReadLine());
        //int result = 1;
        //for (int i = 0; i < num2; i++)
        //{
        //    result *= num;
        //}
        //Console.WriteLine( result );

        //#endregion

        //#region 5.Write a program to enter marks of five subjects and calculate total, average and percentage.

        //Console.Write("Enter Marks of 5 subjects: ");
        //string[] marks = Console.ReadLine().Split();
        //int total = 0;
        //for (int i = 0; i < 5; i++)
        //{
        //    total += int.Parse(marks[i]);
        //}
        //int average = total / 5;
        //Console.WriteLine($"Total marks = {total}");
        //Console.WriteLine($"Average Marks = {average}");
        //Console.WriteLine($"Percentage = {average} %");
        //#endregion

        //#region 6.Write a program to allow the user to enter a string and print the REVERSE of it.

        //Console.Write("Enter String: ");
        //string str = Console.ReadLine();
        //Console.Write("THE REVERSE: ");
        //for (int i = str.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(str[i]);
        //}

        //#endregion

        //#region 7.Write a program to allow the user to enter int and print the REVERSED of it.

        //Console.Write("Enter Number: ");
        //string input7 = Console.ReadLine();
        //Console.Write("THE REVERSE:: ");
        //for (int i = input7.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(input7[i]);
        //}

        //#endregion

        //#region 8.Write a program in C# Sharp to find prime numbers within a range of numbers.

        //Console.Write("Input starting number of range: ");
        //int start = int.Parse(Console.ReadLine());
        //Console.Write("Input ending number of range: ");
        //int end = int.Parse(Console.ReadLine());
        //Console.Write($"The prime number between {start} and {end} are ");
        //for (int num = start; num <= end; num++)
        //{
        //    if (num > 1)
        //    {
        //        bool isPrime = true;
        //        for (int i = 2; i <= num / 2; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                isPrime = false;
        //                break;
        //            }
        //        }
        //        if (isPrime) Console.Write(num + " ");
        //    }
        //}

        //#endregion

        //#region 9. Write a program in C# Sharp to convert a decimal number into binary without using an array.

        //Console.Write("Enter Number : ");
        //int decimalNum = int.Parse(Console.ReadLine());
        //string binary = "";
        //while (decimalNum > 0)
        //{
        //    binary = (decimalNum % 2) + binary;
        //    decimalNum /= 2;
        //}
        //Console.WriteLine("Output: " + binary );
        //#endregion

        //#region 10.Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line
        //Console.WriteLine("Enter three points (x1 y1 x2 y2 x3 y3):");
        //string[] points = Console.ReadLine().Split();
        //int x1 = int.Parse(points[0]);
        //int y1 = int.Parse(points[1]);
        //int x2 = int.Parse(points[2]);
        //int y2 = int.Parse(points[3]);
        //int x3 = int.Parse(points[4]);
        //int y3 = int.Parse(points[5]);
        //bool colinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);

        //Console.WriteLine(colinear ? "single straight line" : "Not single straight line");
        //#endregion

        //#region 11.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

        //Console.Write("Input n: ");
        //int num = int.Parse(Console.ReadLine());
        //for (int i = 0; i < num; i++)
        //{
        //    for (int j = 0; j < num; j++)
        //    {
        //        Console.Write(i == j ? "1 " : "0 ");
        //    }
        //    Console.WriteLine();
        //}

        //#endregion

        //#region 12. Write a program in C# Sharp to find the sum of all elements of the array

        //Console.Write("Enter array elements separated by space: ");
        //string[] arr12 = Console.ReadLine().Split();
        //int sum = 0;
        //foreach (string num in arr12)
        //{
        //    sum += int.Parse(num);
        //}
        //Console.WriteLine("Output: " + sum + "\n");
        //#endregion

        //#region 13.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

        //Console.Write("Enter first array elements: ");
        //int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //Console.Write("Enter second array elements: ");
        //int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //int[] merged = new int[arr1.Length + arr2.Length];
        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    merged[i] = arr1[i];
        //}
        //for (int i = 0; i < arr2.Length; i++)
        //{
        //    merged[arr1.Length + i] = arr2[i];
        //}

        //Array.Sort(merged);
        //Console.WriteLine(string.Join(" ", merged) );

        //#endregion

        //#region 14. Write a program in C# Sharp to count the frequency of each element of an array.

        //Console.Write("Enter array elements: ");
        //string[] arr = Console.ReadLine().Split();
        //int[] freq = new int[arr.Length];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    int count = 1;
        //    for (int j = i + 1; j < arr.Length; j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            count++;
        //            freq[j] = -1;
        //        }
        //    }
        //    if (freq[i] != -1) freq[i] = count;
        //}
        //Console.WriteLine("Output:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (freq[i] != -1)
        //        Console.WriteLine($"{arr[i]} occurs {freq[i]} times");
        //}
        //Console.WriteLine();
        //#endregion

        //#region 15.Write a program in C# Sharp to find maximum and minimum element in an array

        //Console.Write("Enter array elements: ");
        //string[] arr = Console.ReadLine().Split();
        //int max = int.Parse(arr[0]);
        //int min = max;
        //for (int i = 1; i < arr.Length; i++)
        //{
        //    int num = int.Parse(arr[i]);
        //    if (num > max) max = num;
        //    if (num < min) min = num;
        //}
        //Console.WriteLine($"Output: Max = {max}, Min = {min}\n");
        //#endregion

        //#region 16.Write a program in C# Sharp to find the second largest element in an array.


        //Console.Write("Enter array elements: ");
        //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //if (arr.Length < 2)
        //{
        //    Console.WriteLine("Output: Array has fewer than 2 elements");
        //}
        //else
        //{

        //    Array.Sort(arr);          
        //    Array.Reverse(arr);      


        //    int secondLargest = arr[1];
        //    Console.WriteLine(secondLargest);
        //}
        //#endregion

        //#region 17.Consider an Array of Integer values with size N, having values as in this Example

        //Console.Write("Enter array elements: ");
        //string[] arr = Console.ReadLine().Split();
        //int maxDistance = -1;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = i + 1; j < arr.Length; j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            int distance = j - i - 1;
        //            if (distance > maxDistance) maxDistance = distance;
        //        }
        //    }
        //}
        //Console.WriteLine("Output: " + (maxDistance != -1 ? maxDistance.ToString() : "No equal elements") + "\n");
        //#endregion

        //#region 18.Given a list of space separated words, reverse the order of the words.

        //Console.Write("Enter sentence : ");
        //string str = Console.ReadLine();
        //string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //Console.Write("reverse: ");
        //for (int i = words.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(words[i] + (i > 0 ? " " : ""));
        //}

        //#endregion

        //#region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

        //Console.Write("Enter array dimensions (rows columns): ");
        //string[] dims = Console.ReadLine().Split();
        //int rows = int.Parse(dims[0]);
        //int cols = int.Parse(dims[1]);
        //int[,] arr1 = new int[rows, cols];
        //int[,] arr2 = new int[rows, cols];

        //Console.WriteLine("Enter array elements row by row:");
        //for (int i = 0; i < rows; i++)
        //{
        //    string[] row = Console.ReadLine().Split();
        //    for (int j = 0; j < cols; j++)
        //    {
        //        arr1[i, j] = int.Parse(row[j]);
        //        arr2[i, j] = arr1[i, j];
        //    }
        //}

        //Console.WriteLine("Copied array:");
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write(arr2[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //#endregion

        //#region 20.Write a Program to Print One Dimensional Array in Reverse Order
       
        //Console.Write("Enter array elements: ");
        //string[] arr = Console.ReadLine().Split();
        //Console.Write("Output: ");
        //for (int i = arr.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(arr[i] + " ");
        //}
      
        //#endregion
    }
}