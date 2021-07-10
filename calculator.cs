
class calculator
{

    public int Add(int num1, int num2) 
    {
        return num1 + num2;
    }

    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            System.Console.WriteLine("cannot divide by 0");
            return 0;
        }
        else {
            return num1 / num2;
        }
    }
}

