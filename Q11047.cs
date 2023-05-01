using System;

class Template
{
    public static void Main()
    {
        var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] coins = new int[inputs[0]];

        for(int i = 0; i<inputs[0]; i++)
        {
            coins[i] = Int32.Parse(Consoel.ReadLine());
        }
        int value = 0;
        int count = 0;

        for(int greedy = conis.Length-1; value != inputs[1];)
        {
            value += coins[greedy];
            count++;
            if(value > inputs[1])
            {
                count--;
                value -= coins[greedy];
                greedy--;
            }
        }

        Console.WriteLine(count);

    }
}