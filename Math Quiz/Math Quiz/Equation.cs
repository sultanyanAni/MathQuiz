using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{
    public class Equation
    {
        public enum MathSymbol
        {
            Add,
            Subtract,
            Multiply,
            Divide

        }

        int num1;
        int num2;
        Random gen;
        MathSymbol symbol;
        public Equation()
        {
            gen = new Random();
            num1 = gen.Next(21);
            symbol = (MathSymbol)gen.Next(4);
            num2 = gen.Next(21);
            while (symbol == MathSymbol.Divide && num2 == 0)
            {
                num2 = gen.Next(21);
            }

        }

        public string GetEquation()
        {
            string EquationSymbol = "";
            switch (symbol)
            {
                case MathSymbol.Add:
                    EquationSymbol = "+";
                    break;
                case MathSymbol.Subtract:
                    EquationSymbol = "-";
                    break;
                case MathSymbol.Multiply:
                    EquationSymbol = "*";
                    break;
                case MathSymbol.Divide:
                    EquationSymbol = "/";
                    break;
            }

            return $"{num1} {EquationSymbol} {num2}";
        }
        public int Answer()
        {
            int result = 0;
            switch (symbol)
            {
                case MathSymbol.Add:
                    result = num1 + num2;
                    break;
                case MathSymbol.Subtract:
                    result = num1 - num2;
                    break;
                case MathSymbol.Multiply:
                    result = num1 * num2;
                    break;
                case MathSymbol.Divide:
                    result = num1 / num2;
                    break;
            }

        }
    }
}
}