using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Read and save an integer, double, and String to your variables.
        
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        string z = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(String.Format("{0:0}", i + x));
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", d + y));
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + z);
    }
}