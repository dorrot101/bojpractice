using System;

class Q10813
        {
            public static void Main()
            {
                var conditions = Console.ReadLine().Split();
                var baskets = new int[Int32.Parse(conditions[0])];
                for(int i = 0; i<baskets.Length; i++ )
                {
                    baskets[i] = i+1;
                }
                var count = Int32.Parse(conditions[1]);

                for(int i = 0; i<count; i++)
                {
                    var inputs = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                    (baskets[inputs[1]-1], baskets[inputs[0]-1]) = (baskets[inputs[0]-1], baskets[inputs[1]-1]); 
                }

                foreach (int i in baskets)
                {
                    Console.Write($"{i} ");
                }
            }

        }