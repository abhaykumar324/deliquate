using System;

public delegate int PerformCalculation(int x, int y);

class deliquate4
{
    static int Add(int x, int y)
    {
        return x + y;
    }

    static void Main4()
    {
        PerformCalculation p = Add;

        Console.WriteLine(p(10, 20));
    }
}