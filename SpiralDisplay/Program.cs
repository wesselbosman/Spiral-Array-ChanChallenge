using System;
using Core;

namespace SpiralDisplay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var spiralDisplay = new SpiralArray(10, 10);
            Console.Write(spiralDisplay.ToString());
            Console.ReadLine();
        }
    }
}
