using System;

class Q1052
{

    public delegate int Del(int value);

    public static void Main()
    {

        var input = Int32.Parse(Console.ReadLine());

        Del vv = new Del(fac);

        Console.WriteLine(vv(input)); 
    }

    public int fac(int value)
    {
        return value == 1 ? 1 : fac(value-1);
    }
}