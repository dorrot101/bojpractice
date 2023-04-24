using System;



class Q10988
{
    Dictionary<string, float> _Grade = new Dictionary<string, float>()
     {
          {"A+", 4.5},
          {"A0", 4.0},
          {"B+", 3.5},
          {"B0", 3.0},
          {"C+", 2.5},
          {"C0", 2.0},
          {"D+", 1.5},
          {"D0", 1.0},
          {"F", 0.0},
     };

    public static void Main()
    {
        var count = 20;
        var sum = 0.0;
        var under = 0.0;

        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine().Split();
            if (input[2].Equals("P"))
            {
                sum += float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat) * this._Grade[input[2]];
                under = float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);
            }
        }

        Console.WriteLine(String.Format("{0:F6}", sum/under));

     }


}



