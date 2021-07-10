using System;

class calc
{
    static void Main(string[] args)
    {
        calculator calc = new calculator();

        Console.WriteLine("Select operation type:\n ( A, S, M, D / X to Exit)");
        string operation = Console.ReadLine();

        while (operation.ToUpper() != "X") {

            Console.WriteLine("Insert the first number:\n");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the second number:\n");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            if (operation.ToUpper() == "A")
            {
                Console.WriteLine(calc.Add(firstNum, secondNum));
            }
            else if (operation.ToUpper() == "S")
            {
                Console.WriteLine(calc.Subtract(firstNum, secondNum));
            }
            else if (operation.ToUpper() == "M")
            {
                Console.WriteLine(calc.Multiply(firstNum, secondNum));
            }
            else if (operation.ToUpper() == "D")
            {
                Console.WriteLine(calc.Divide(firstNum, secondNum));
            }
            else
            {
                Console.WriteLine("Imput error, try again");
            }
            
            Console.WriteLine("Select operation type:\n ( A, S, M, D / X to Exit)");
            operation = Console.ReadLine();

        }



        


        
        
        
        


    }
}
