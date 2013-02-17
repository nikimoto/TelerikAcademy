using System;


class TriangleArea
{
    private static void Menu()
    {
        Console.WriteLine("Choose method to calculate triangle's area: ");
        Console.WriteLine();
        Console.WriteLine("1. By given side and altitude to it");
        Console.WriteLine("2. By three sides");
        Console.WriteLine("3. By given two sides and angle between them");
        Console.WriteLine();       
    }

    private static void Choise()
    {
        string input = Console.ReadLine();
        int choise = 0;
        double[] output;
        double result = 0;

        if (int.TryParse(input, out choise))
        {
            switch (choise)
            {
                case 1:
                    output = GetData("Side a", "Altitude h");
                    result = CalculateArea(output);
                    break;
                case 2:
                    output = GetData("Side a", "Side b", "Side c");
                    result = CalculateArea(output);
                    break;
                case 3:
                    output = GetData("Side a", "Side b", "Angle (in degrees)");
                    result = CalculateArea(output, angle:true);
                    break;
                default: break;
            }
        }
        PrintResult(result);
    }

    private static void PrintResult(double result)
    {
        if (result > 0)
        {
            Console.Write("Area is: {0:F2}", result);
            Console.WriteLine();
        }
        else if (result < 0 || double.IsNaN(result))
        {
            Console.WriteLine("No such triangle!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid choise");
            Console.WriteLine();
        }
    }

    private static double CalculateArea(double[] inputData, bool angle = false)
    {
        if (!angle)
        {
            if (inputData.Length == 2)
            {
                return (inputData[0] * inputData[1]) / 2;
            }
            else
            {
                double p = (inputData[0] + inputData[1] + inputData[2]) / 2;
                return Math.Sqrt(p * (p - inputData[0]) * (p - inputData[1]) * (p - inputData[2]));
            }
        }
        else
        {
            return (inputData[0] * inputData[1] * Math.Sin(Math.PI * inputData[2] / 180)) / 2;
        }
    }

    private static double[] GetData(params string[] variables)
    {
        double[] output = new double[variables.Length];

        for (int i = 0; i < variables.Length; i++)
        {
            Console.Write(variables[i] + " = ");
            output[i] = double.Parse(Console.ReadLine());
        }
        return output;
    }

    static void Main()
    {
        Menu();
        Choise();        
    }
}
