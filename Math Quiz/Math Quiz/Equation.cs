using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{
    public class Equation
    {
        enum MathSymbol
        {
            Add,
            Subtract,
            Multiply,
            Divide

        }

        float num1;
        float num2;
        Random gen;
        MathSymbol symbol;
        //public bool isDivision => symbol == MathSymbol.Divide;
        /// <summary>
        /// When a new equation is created, two random numbers are generated and a random symbol is generated. 
        /// </summary>
        public Equation(Random gen)
        {
            this.gen = gen;
            num1 = gen.Next(21);
            symbol = (MathSymbol)gen.Next(4);
            num2 = gen.Next(21);
            while (symbol == MathSymbol.Divide && num2 == 0)
            {
                num2 = gen.Next(21);
            }

        }
        /// <summary>
        /// Creates a string of the randomly generated equation
        /// </summary>
        /// <returns>string of the randomly generated equation</returns>
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

        /// <summary>
        /// Gets the answer to the randomly generated equation
        /// </summary>
        /// <returns>the answer to the randomly generated equation</returns>
        public float Answer()
        {
            float result = 0;
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

            return result;
        }
    }
}
