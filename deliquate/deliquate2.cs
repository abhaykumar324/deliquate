using System;

class deliquate2
{
    // Delegate declaration
    delegate int Operation(int a, int b);

    // Compatible methods
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main2()
    {
        // Instantiate delegate and associate it with Add
        Operation op = new Operation(Add);

        Console.WriteLine(op(10, 20)); // 30

        // Associate the same delegate with Multiply
        op = new Operation(Multiply);

        Console.WriteLine(op(10, 20)); // 200
    }
}