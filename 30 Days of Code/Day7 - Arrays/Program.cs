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
    static void Main(){
        Console.ReadLine();
        var text = Console.ReadLine();
        var textList = text.Split(" ");
        Array.Reverse(textList);
        
        foreach (var num in textList){
            Console.Write($"{num} ");
        }

    }
}
