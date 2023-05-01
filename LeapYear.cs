using System;

class LeapYear
{
    public static void Main()
    {
        var count = Int32.Parse(Console.ReadLine());

        for(int i = 0; i<count; i++)
        {
            var inputs = Int32.Parse(Console.ReadLine());

            if(inputs % 4 == 0 && (inputs % 400 == 0 || inputs % 100 != 0)) Console.WriteLine($"{inputs} is leap year");
            else 


        }
    }
}