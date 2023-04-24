using System;

class Q10811
{
    public static void Main()
            {
                var conditions = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int[] baskets = new int[conditions[0]];
                for(int i = 0; i<baskets.Length; i++)
                {
                    baskets[i] = i+1;
                }
                var count = conditions[1];

                for(int i = 0; i<count; i++)
                {
                    var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    Inverse(inputs[0]-1, inputs[1]-1, baskets);
                }

                foreach(int i in baskets)
                {
                    Console.Write($"{i} ");
                }
            }

            static void Inverse(int from, int to, int[] arr)
            {
                for(int i = from; i<(from+to)/2+1; i++)
                {
                    (arr[i], arr[to+from-i]) = (arr[to+from-i], arr[i]);
                }
            }
        
}