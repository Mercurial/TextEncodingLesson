using System;
using Clark.Text;

namespace TextEncodingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to convert to 5 bits: ");
            byte firstNo = byte.Parse(Console.ReadLine());
            var newFiveBit = new FiveBits(firstNo);
            Console.WriteLine($"The number you entered was: {newFiveBit.ToByte()}");
            char c = Encoding.Table[newFiveBit.ToByte()];
            Console.WriteLine($"The number you entered in char was: {c}");
        }
    }
}
