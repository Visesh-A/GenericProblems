using GenericsProblems;
using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
namespace GenericsProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumGeneric<int> maximum1 = new MaximumGeneric<int>(12, 82, 43);
            maximum1.FindMax();
            MaximumGeneric<float> maximum2 = new MaximumGeneric<float>(12, 8, 43);
            maximum2.FindMax();
            MaximumGeneric<string> maximum3 = new MaximumGeneric<string>("Apple", "Peach", "Banana");
            maximum3.FindMax();
        }
    }

}
