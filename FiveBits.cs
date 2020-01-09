using System;

class FiveBits
{
    private const byte MAX_BITS = 5;
    private readonly bool[] Values = new bool[MAX_BITS];
    public FiveBits(byte value)
    {
        bool[] tempValues = new bool[MAX_BITS];
        byte ctr = 0;

        while (value >= 1)
        {
            tempValues[ctr++] = value % 2 == 1;
            value = (byte)(value / 2);
        }

        int max_index = MAX_BITS - 1;
        for (int x = 0; x < MAX_BITS; x++)
        {
            Values[max_index--] = tempValues[x];
        }
    }

    public byte ToByte()
    {
        byte value = 0;
        byte pow = 0;
        for (int x = Values.Length - 1; x >= 0; x--)
        {
            if (Values[x] == true)
            {
                value += (byte)Math.Pow(2, pow);
            }
            pow++;
        }
        return value;
    }

    public override string ToString()
    {
        string result = string.Empty;
        foreach (bool b in Values)
        {
            result += b ? "1" : "0";
        }
        return result;
    }
}