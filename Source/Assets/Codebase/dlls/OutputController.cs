using System.Collections;
using System.Collections.Generic;

//The dll file to achieve certain outputs.
namespace OutputController
{
    public class Convert
    {
        public static byte ToByte(double value)
        {
            byte byteValue;

            if (value < byte.MinValue)
            {
                byteValue = byte.MinValue;
            }
            else if (value > byte.MaxValue)
            {
                byteValue = byte.MaxValue;
            }
            else
            {
                byteValue = (byte)value;
            }

            return byteValue;
        }

        public static ushort ToUShort(double value)
        {
            ushort ushortValue;

            if (value < ushort.MinValue)
            {
                ushortValue = ushort.MinValue;
            }
            else if (value > ushort.MaxValue)
            {
                ushortValue = ushort.MaxValue;
            }
            else
            {
                ushortValue = (ushort)value;
            }

            return ushortValue;
        }

        public static short ToShort(double value)
        {
            short shortValue;

            if (value < short.MinValue)
            {
                shortValue = short.MinValue;
            }
            else if (value > short.MaxValue)
            {
                shortValue = short.MaxValue;
            }
            else
            {
                shortValue = (short)value;
            }

            return shortValue;
        }

        public static uint ToUInt(double value)
        {
            uint uintValue;

            if (value < uint.MinValue)
            {
                uintValue = uint.MinValue;
            }
            else if (value > uint.MaxValue)
            {
                uintValue = uint.MaxValue;
            }
            else
            {
                uintValue = (uint)value;
            }

            return uintValue;
        }

        public static int ToInt(double value)
        {
            int intValue;

            if (value < int.MinValue)
            {
                intValue = int.MinValue;
            }
            else if (value > int.MaxValue)
            {
                intValue = int.MaxValue;
            }
            else
            {
                intValue = (int)value;
            }

            return intValue;
        }
    }
}
