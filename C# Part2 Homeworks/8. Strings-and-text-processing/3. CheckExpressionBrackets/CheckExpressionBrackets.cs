using System;

class CheckExpressionBrackets
{
    static bool CheckBrackets(string expression)
    {
        int countBrackets = 0;
        foreach (char ch in expression)
        {
            if (ch == '(')
            {
                countBrackets++;
            }
            else if (ch == ')')
            {
                countBrackets--;
            }
            if (countBrackets < 0)
            {
                return false;
            }
        }
        if (countBrackets == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    static void Main()
    {
        Console.Write("Enter expression to check if its brackets are correctly: ");
        string input = Console.ReadLine();
        bool result = CheckBrackets(input);
        if (result)
        {
            Console.WriteLine("The brackets are entered in correct way");
        }
        else
        {
            Console.WriteLine("The brackets are entered in incorrect way.");
        }
    }
}
