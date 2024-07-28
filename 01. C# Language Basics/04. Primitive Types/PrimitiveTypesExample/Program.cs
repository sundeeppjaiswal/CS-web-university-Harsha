class Sample //Non primitive type
{
    static void Main()
    {
        //sbyte
        sbyte maxValSByte = sbyte.MaxValue; //Primitive type
        sbyte minValSByte = sbyte.MinValue; //Primitive type
        sbyte defaultSByte = default(sbyte); //Primitive type
        //byte
        byte minValByte = byte.MinValue; //Primitive type
        byte maxValByte = byte.MaxValue; //Primitive type
        byte defaultByte = default(byte); //Primitive type
        //short
        short shortMinVal = short.MinValue; //Primitive type
        short shortMaxVal = short.MaxValue; //Primitive type
        short defaultShort = default(short); //Primitive type
        //ushort
        ushort ushortMinVal = ushort.MinValue; //Primitive type
        ushort ushortMaxVal = ushort.MaxValue; //Primitive type
        ushort defaultUShort = default(ushort); //Primitive type
        //int
        int intMinVal = int.MinValue; //Primitive type
        int intMaxVal = int.MaxValue; //Primitive type
        int defaultInteger = default(int); //Primitive type
        //uint
        uint uintMinVal = uint.MinValue; //Primitive type
        uint uintMaxVal = uint.MaxValue; //Primitive type
        uint defaultUInteger = default(uint); //Primitive type
        //long
        long longMinVal = long.MinValue; //Primitive type
        long longMaxVal = long.MaxValue; //Primitive type
        long defaultLong = default(long); //Primitive type
        //ulong
        ulong ulongMinVal = ulong.MinValue; //Primitive type
        ulong ulongMaxVal = ulong.MaxValue; //Primitive type
        ulong defaultULong = default(ulong); //Primitive type
        //float, suffix as F
        float floatMinVal = float.MinValue; //Primitive type
        float floatMaxVal = float.MaxValue; //Primitive type
        float defaultFloat = default(float); //Primitive type
        //double, suffix as D
        double doubleMinVal = double.MinValue; //Primitive type
        double doubleMaxVal = double.MaxValue; //Primitive type
        double defaultDouble = default(double); //Primitive type
        //decimal, suffix as M
        decimal decimalMinVal = decimal.MinValue; //Primitive type
        decimal decimalMaxVal = decimal.MaxValue; //Primitive type
        decimal defaultDecimal = default(decimal); //Primitive type
        //char
        char n = 'S'; //Primitive type
        string o = "Sam"; //Non primitive type
        bool p = true; //Primitive type

        System.Console.WriteLine("sbyte: Size is 1 byte & Range: " + minValSByte + " to " + maxValSByte);
        System.Console.WriteLine("Default of sbyte: " + defaultSByte);
        System.Console.WriteLine();
        System.Console.WriteLine("byte: Size is 1 byte & Range: " + minValByte + " to " + maxValByte);
        System.Console.WriteLine("Default of byte: " + defaultByte);
        System.Console.WriteLine();
        System.Console.WriteLine("short: Size is 2 byte & Range: " + shortMinVal + " to " + shortMaxVal);
        System.Console.WriteLine("Default of short: " + defaultShort);
        System.Console.WriteLine();
        System.Console.WriteLine("ushort: Size is 2 byte & Range: " + ushortMinVal + " to " + ushortMaxVal);
        System.Console.WriteLine("Default of ushort: " + defaultUShort);
        System.Console.WriteLine();
        System.Console.WriteLine("int: Size is 4 byte & Range: " + intMinVal + " to " + intMaxVal);
        System.Console.WriteLine("Default of int: " + defaultInteger);
        System.Console.WriteLine();
        System.Console.WriteLine("uint: Size is 4 byte & Range: " + uintMinVal + " to " + uintMaxVal);
        System.Console.WriteLine("Default of uint: " + defaultUInteger);
        System.Console.WriteLine();
        System.Console.WriteLine("long: Size is 8 byte & Range: " + longMinVal + " to " + longMaxVal);
        System.Console.WriteLine("Default of long: " + defaultLong);
        System.Console.WriteLine();
        System.Console.WriteLine("ulong: Size is 8 byte & Range: " + ulongMinVal + " to " + ulongMaxVal);
        System.Console.WriteLine("Default of ulong: " + defaultULong);
        System.Console.WriteLine();
        System.Console.WriteLine("float: Size is 4 byte & Range: " + floatMinVal + " to " + floatMaxVal);
        System.Console.WriteLine("Default of float: " + defaultFloat);
        System.Console.WriteLine();
        System.Console.WriteLine("double: Size is 8 byte & Range: " + doubleMinVal + " to " + doubleMaxVal);
        System.Console.WriteLine("Default of double: " + defaultDouble);
        System.Console.WriteLine();
        System.Console.WriteLine("decimal: Size is 16 byte & Range: " + decimalMinVal + " to " + decimalMaxVal);
        System.Console.WriteLine("Default of decimal: " + defaultDecimal);
        System.Console.WriteLine();
        System.Console.WriteLine("char: " + n);
        System.Console.WriteLine();
        System.Console.WriteLine("String, Non primitive type(2 bytes): " + o);
        System.Console.WriteLine();
        System.Console.WriteLine("bool, 1bit: " + p);
        System.Console.ReadKey();
    }
}