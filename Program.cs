using System;

namespace TextEncodingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNo = 0;
            Console.WriteLine("Enter number to convert to 5 bits: ");
            firstNo = int.Parse(Console.ReadLine());
            var newFiveBit = new FiveBits(firstNo);
            Console.WriteLine($"The number you entered was: {newFiveBit.ToInt()}");
            Console.WriteLine($"The number you entered in char was: {newFiveBit.ToChar()}");
        }
    }
}
