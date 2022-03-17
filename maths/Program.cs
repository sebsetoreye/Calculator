// See https://aka.ms/new-console-template for more information

//looping
int coucloop = 3;
while (coucloop > 0)

{





    //nameing
    Console.Clear();
    Console.WriteLine("---------------------        (^---------^)");
    Console.WriteLine("                            /__|____|____|");
    Console.WriteLine("SEB'S CALCULATOR           /___|____|____|");
    Console.WriteLine("                          (____|____|____|");
    Console.WriteLine("---------------------     <-------------->");
    Console.WriteLine();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("");
    Console.WriteLine("IT CAN ONLY DO FULL NUMBERS (INTS) NO DECIMAL");
    Console.WriteLine();
    Console.WriteLine("-----------------------------------");

    //veriables couc
    float num1, num2;

    string typeofoperation, couc_exit;


    //getting the numbers
    Console.WriteLine();
    Console.Write("your first number: ");
    num1 = Convert.ToInt64(Console.ReadLine());


    Console.Write("your Operation ( * ) = times, ( / ) = divide, ( + ) = Add, ( - ) = subtract ), ( ^ ) = to the power: ");
    typeofoperation = Console.ReadLine();


    Console.Write("your 2nd number: ");
    num2 = Convert.ToInt64(Console.ReadLine());




    //output 

    Console.WriteLine("IT EQUALS");
    Console.WriteLine();


    if (typeofoperation == "+")
    {
        Console.Write(num1 + num2);
        Console.WriteLine();
        Console.Write("do you want to continue? (Y or N): ");
        couc_exit = Console.ReadLine();

        if (couc_exit == "Y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "N")
        {
            System.Environment.Exit(0);
        }
        else if (couc_exit == "y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "n")
        {
            System.Environment.Exit(0);
        }
        else
        {
            Console.Write("you did not put in the right syntax");
            Thread.Sleep(5000);
        }

    }
    else if (typeofoperation == "*")
    {
        Console.Write(num1 * num2);
        Console.WriteLine();
        Console.Write("do you want to continue? (Y or N): ");
        couc_exit = Console.ReadLine();

        if (couc_exit == "Y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "N")
        {
            System.Environment.Exit(0);
        }
        else if (couc_exit == "y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "n")
        {
            System.Environment.Exit(0);
        }
        else
        {
            Console.Write("you did not put in the right syntax");
            Thread.Sleep(5000);
        }

    }
    else if (typeofoperation == "-")
    {
        Console.Write(num1 - num2);
        Console.WriteLine();
        Console.Write("do you want to continue? (Y or N): ");
        couc_exit = Console.ReadLine();

        if (couc_exit == "Y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "N")
        {
            System.Environment.Exit(0);
        }
        else if (couc_exit == "y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "n")
        {
            System.Environment.Exit(0);
        }
        else
        {
            Console.Write("you did not put in the right syntax");
            Thread.Sleep(5000);
        }
    }
    else if (typeofoperation == "/")
    {
           //to yell at people who divide by zero
        if (num2 == 0)
        {
            Console.Write("ERROR CAN'T DIVIDE BY ZERO");
            Thread.Sleep(5000);
        }
        else
        {
            Console.Write(num1 / num2);
            Console.WriteLine();
            Console.Write("do you want to continue? (Y or N): ");
            couc_exit = Console.ReadLine();

            if (couc_exit == "Y")
            {
                Thread.Sleep(500);
            }
            else if (couc_exit == "N")
            {
                System.Environment.Exit(0);
            }
            else if (couc_exit == "y")
            {
                Thread.Sleep(500);
            }
            else if (couc_exit == "n")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.Write("you did not put in the right syntax");
                Thread.Sleep(5000);
            }
        }
        

    }
    else if (typeofoperation == "^")
    {
        Console.WriteLine(Math.Pow(num1, num2));
        Console.WriteLine();
        Console.Write("do you want to continue? (Y or N): ");
        couc_exit = Console.ReadLine();

        if (couc_exit == "Y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "N")
        {
            System.Environment.Exit(0);
        }
        else if (couc_exit == "y")
        {
            Thread.Sleep(500);
        }
        else if (couc_exit == "n")
        {
            System.Environment.Exit(0);
        }
        else
        {
            Console.Write("you did not put in the right syntax");
            Thread.Sleep(5000);
        }

    }
    else
    {
        Console.WriteLine("incorrect syntax this Calculator can only do full numbers ( No decimals ) ");
        Console.WriteLine();
        Thread.Sleep(5000);
    }
}