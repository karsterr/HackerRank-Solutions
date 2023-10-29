using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        
        for (int x = 0; x < n; x++){
            string str = Console.ReadLine();
            
            for (int y = 0; y < str.Length; y++){
                if (y % 2 == 0) Console.Write(str[y]);
            }
            
            Console.Write(" "); 
            
            for (var z = 0; z < str.Length; z++) {
                if (z % 2 != 0) Console.Write(str[z]);
            }

            Console.Write(Environment.NewLine);
        }
    }
}