using System;
using System.IO;

namespace TextEncodingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter your string");
            // string input = Console.ReadLine();
            // byte[] utfBuffer = System.Text.Encoding.UTF8.GetBytes(input);
            // byte[] clarkBuffer = SAIB.Text.Encoding.GetBytes(input);
            // FiveBits[] fiveBitsBuffer = SAIB.Text.Encoding.ToFiveBits(input);

            // foreach (byte b in utfBuffer)
            // {
            //     Console.WriteLine($"UTF-8 Buffer: {b}");
            // }

            // foreach (byte b in clarkBuffer)
            // {
            //     Console.WriteLine($"Clark Buffer: {b}");
            // }

            // foreach (FiveBits f in fiveBitsBuffer)
            // {
            //     Console.WriteLine($"FiveBits: {f}");
            // }

            // File.WriteAllBytes("test.clark", clarkBuffer);
            // byte[] readBytes = File.ReadAllBytes("test.clark");
            // foreach(byte b in readBytes)
            // {
            //     Console.Write(SAIB.Text.Encoding.Table[b]);
            // }
            // Console.Write("\n");
            Copy(args[0], args[1]);
        }

        public static void Copy(string path1, string path2)
        {
            byte[] buffer = File.ReadAllBytes(path1);
            File.WriteAllBytes(path2, buffer);
        }
    }
}
