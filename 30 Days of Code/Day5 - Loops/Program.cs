using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        int i, oneToTen;
        i = 0;
        oneToTen = 0;
        while (i < 10)
        {
            oneToTen++;
            Console.WriteLine($"{n} x {oneToTen} = {n * oneToTen}");
            i++;
        }
    }
}
