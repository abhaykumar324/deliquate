using System;
class Callingthroghdelegate
{
    delegate void operation(int a, int b, int c);

    static void Div(int a, int b, int c)
    {
        int result = a * b / c;
        Console.WriteLine("Solution is  = " + result);
    }

    static void Mul(int a, int b, int c)
    {
        int result = (a * a / b * b) + c;
        Console.WriteLine("Given solution is =  " + result);

    }

    static void Main()
    {
        operation op = Div;
        op += Mul;
        op -= Mul;
        op(10, 5, 10);
        //operation op1 = Mul;
        //op1(10, 20);


    }
}