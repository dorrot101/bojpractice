using System;

class Q10807
{
    public static void Main()
    {
        var num = Console.ReadLine();
        var inputs = Console.ReadLine().Split();
        var Int_inputs = Array.ConvertAll(inputs, int.Parse);
        var target = Console.ReadLine();
        var Int_target = Int32.Parse(target);
        
        var count = 0;
        foreach(int t in Int_inputs)
        {
            if(t == Int_target)
            {
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
}