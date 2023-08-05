namespace CalculatorLibrary;

public class Calculator
{
    public static float Compute(string? firstOperand, string? secondOperand, string? operation)
    {
        int op1;
        int op2;
        bool isOp1Numeric = int.TryParse(firstOperand, out op1);
        bool isOp2Numeric = int.TryParse(secondOperand, out op2);

        if (!isOp1Numeric || !isOp2Numeric)
        {
            return -1;
        }

        switch (operation)
        {
            case ("+"): return op1 + op2;
            case ("-"): return op1 - op2;
            case ("*"): return op1 * op2;
            case ("/"): 
                if (op2 ==  0)
                {
                    return -1;
                }
                return op1 / op2;
            default: return -1;
        }   
    }
}
