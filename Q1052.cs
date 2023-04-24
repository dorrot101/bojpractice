using System;

class Q1052
{
    public static void Main()
    {
        var conditions = Array.ConvertAll(Console.ReadLine().Split().int.Parse);
        var bottles = conditions[0];
        var filledBottles = conditions[1];

        var targetArr = new int[30];
        targetArr[1] = bottles;

        var answer = 0;
        var lowestLevel = 1;

        while(countBottles(bottles, targetArr) > filledBottles)
        {
            pour(lowestLevel, targetArr, answer);
            if(targetArr[lowestLevel] == 0) lowestLevel++;
        }

        Console.WirteLine(answer);
    }

    static int countBottles(int bottles, int[] arr)
    {
        return bottles - arr[0];
    }

    static void pour(int level, int[] arr, out int ans)
    {
        arr[level+1] += 1;
        arr[level] -= 2;
        if(arr[level] == -1) ans+=1;
        arr[0] += 1;
    }

}