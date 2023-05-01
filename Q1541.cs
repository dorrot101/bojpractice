using System;
using System.Collections;

class Q1541
{
    public static void Main()
    {
        var inputs = Console.ReadLine();

        Queue<char> operators = new Queue<char>(1);
        Queue<int> numbers = new Queue<int>(1);
        
        string number = "";

        for(int i = 0; i<inputs.Length; i++)
        {
            if(inputs[i] != '+' && inputs[i] != '-')
            {
                number += inputs[i];
            }
            else
            {
                operators.Enqueue(inputs[i]);
                numbers.Enqueue(Int32.Parse(number));
                number = "";
            }
        }

        numbers.Enqueue(Int32.Parse(number));

        int result = numbers.Dequeue();
        bool bracket = false;
        int inBracket = 0;

        foreach(char opt in operators)
        {
            if(opt == '-')
            {   
                bracket = true;
                result -= numbers.Dequeue();
            }
            else 
            {
                if(bracket) result -= numbers.Dequeue();
                else result += numbers.Dequeue();
            }
        }


        Console.WriteLine(result);
    }
}