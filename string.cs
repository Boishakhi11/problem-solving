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

class Result
{

    /*
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string superReducedString(string s)
     {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (stack.Count > 0 && stack.Peek() == c)
            {
                stack.Pop();  // Remove the matching pair
            }
            else
            {
                stack.Push(c);  // Add the character to the stack
            }
        }

        // If stack is empty, return "Empty String"
        if (stack.Count == 0)
        {
            return "Empty String";
        }
        else
        {
            char[] resultArray = stack.ToArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
    }
}
