using System;
class FiveBits
{
    private const byte MAX_BITS = 5;
    private bool[] values = new bool[MAX_BITS];
    public FiveBits(byte value)
    {
        bool[] tempValues = new bool[MAX_BITS];
        byte ctr = 0;

        while(value >= 1)
        {
            tempValues[ctr++] = value % 2 == 1;
            value = (byte)(value / 2);
        }

        if(ctr < MAX_BITS)
        {
            var offset = MAX_BITS - ctr;
            for(int x = offset; x < MAX_BITS; x++)
            {
                values[x] = tempValues[x - offset];
            }
        }
        else
        {
            int max_index  = MAX_BITS - 1;
            for(int x = 0; x < MAX_BITS; x++)
            {
                values[max_index] = tempValues[x];
            }
        }
    }

    public byte ToByte()
    {
        byte value = 0;
        byte pow = 0;
        for(int x = values.Length - 1; x >= 0; x--)
        {
            if(values[x] == true)
            {
                value += (byte)Math.Pow(2, pow);
            }
            pow++;
        }
        return value;
    }
}