int firstNumber = GetValidNumber("Hello! \nInput the first number:");
int secondNumber = GetValidNumber("Input the second number:");

char operatorSymbol = GetOperator();

int result = PerformOperation(firstNumber, secondNumber, operatorSymbol);

Console.WriteLine($"Result: {firstNumber} {operatorSymbol} {secondNumber} = {result}");
Console.WriteLine("\nPress any key to close.");
Console.ReadKey();

static int GetValidNumber(string prompt)
{
    int number;
    Console.WriteLine(prompt);
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid number:");
    }
    return number;
}

static char GetOperator()
{
    Console.WriteLine("\nWhat would you like to do with these numbers? \n" +
        " - [A]dd (+) \n" +
        " - [S]ubtract (-) \n" +
        " - [M]ultiply (*)");

    while (true)
    {
        string choice = Console.ReadLine()?.ToLower() ?? "";
        if (choice == "a") return '+';
        if (choice == "s") return '-';
        if (choice == "m") return '*';

        Console.WriteLine("Invalid choice. Please select A, S, or M:");
    }
}

static int PerformOperation(int firstNumber, int secondNumber, char operatorSymbol)
{
    return operatorSymbol switch
    {
        '+' => firstNumber + secondNumber,
        '-' => firstNumber - secondNumber,
        '*' => firstNumber * secondNumber,
        _ => throw new InvalidOperationException("Unexpected operator")
    };
}

