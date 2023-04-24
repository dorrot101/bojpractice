using System;

class Q10807
{
    public static void Main()
    {
        var _conditions = Console.ReadLine().Split();

        var _basketNum = Int32.Parse(_conditions[0]);
        var baskets = new int[_basketNum];

        var _count = Int32.Parse(_conditions[1]);


        for (int i = 0; i < _count; i++)
        {
            var _inputs = Console.ReadLine().Split();
            var from = Int32.Parse(_inputs[0]);
            var to = Int32.Parse(_inputs[1]);
            var Ball = Int32.Parse(_inputs[2]);

            for (int t = from - 1; t < to; t++)
            {
                baskets[t] = Ball;
            }
        }

        foreach (int i in baskets)
        {
            Console.Write($"{i} ");
        }
    }
}