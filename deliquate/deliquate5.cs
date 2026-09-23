using System;

public delegate int Calculater(int x, int y);

class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}

class deliquate5
{
    static void Main11()
    {
        Calculater c = Calculator.Add;

        Console.WriteLine(c(10, 20));
    }
}