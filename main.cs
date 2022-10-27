// Created by: Ashley Monaghan
// Created on: Oct 2022
//
//This program calculates area of a trapizoid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user imput
        int baseA;
        int baseB;
        int height;
        int area;

        Console.WriteLine("This program calculates the area of a trapizoid.");
        Console.WriteLine("");

        Console.Write("Enter base A (cm): ");
        baseA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter base B (cm): ");
        baseB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        area = ((baseA + baseB) / 2) * height;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");

        Console.WriteLine("\nDone.");
    }
}