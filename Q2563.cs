using System;

class Q2563
{
     public static void Main()
     {
          bool[,] canvas = new bool[100,100];
          int count = Int32.Parse(Console.ReadLine());
          for(int i = 0; i<count; i++)
          {
               var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
               Draw(inputs[0], inputs[1], canvas);
          }

          var result = 0; 
            foreach(bool d in canvas)
               if(d) result++;

          Console.WriteLine(result);
     }

     static void Draw(int x, int y, bool[,] bg)
     {
          for(int i = 0; i<10; i++)
          {
               for(int j = 0; j<10; j++)
               {
                    bg[x+i,y+j] = true;
               }
          }
     }
}

     

