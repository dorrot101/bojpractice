using System;

class Q5597
    {
        public static void Main()
        {
           bool[] students = new bool[30];
           for(int i = 0; i<28; i++)
           {
                var input = Int32.Parse(Console.ReadLine());
                students[input-1] = true; 
           }

            var target = 1;
           foreach(bool t in students)
           {

                if(!t) Console.WriteLine(target);
                target++;
           }
        }

}