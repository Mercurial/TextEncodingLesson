namespace SAIB.Text
{
    class Encoding
    {
        public static readonly char[] Table = new char[]
        {
            (char)0,
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z',
            '.',
            '.',
            '.',
            '.',
            '.',
        };

        public static FiveBits[] ToFiveBits(string input)
        {
            byte[] buffer = GetBytes(input);
            FiveBits[] result = new FiveBits[buffer.Length];
            for(int x = 0; x < buffer.Length; x++)
            {
                result[x] = new FiveBits(buffer[x]);
            }
            return result;
        }

        public static byte[] GetBytes(string input)
        {
            byte[] result = new byte[input.Length];
            for (int x = 0; x < input.Length; x++)
            {
                for (int y = 0; y < Table.Length; y++)
                {
                    if(input[x] == Table[y])
                    {
                        result[x] = (byte)y;
                    }
                }
            }
            return result;
        }

    }
}