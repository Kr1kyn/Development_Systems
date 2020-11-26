using System;
using System.Drawing;

namespace ds.test.impl.MathPlugins
{
    /// <summary>
    /// Plugin  for the mathematical operation of raising a number to a power
    /// </summary>
    internal class OperationExp : PluginWithCheckNegativNumber
    {
        public override string PluginName => "EXP";
        public override Image Image => Image.FromFile(Properties.Resources.exp);
        public override string Description => "Return a number equal to the number from the first parameter, to the power of the second parameter (firstNumber^(secondNumber))";

        /// <summary>
        /// The main method for raising a number from the first parameter to the power of the second parameter
        /// </summary>
        /// <param name="input1">The number to be raised to a power</param>
        /// <param name="input2">Degree of number</param>
        /// <returns>input1^(input2)</returns>
        /// <exception cref="System.ArgumentException">Thrown when second parameter (degree of number) is negative.</exception>
        /// <exception cref="System.OverflowException">>Thrown when result is outside the range of int values.</exception>
        public override int Run(int input1, int input2)
        {
            if (checkForNonNegativeNumber(input2))
            {
                ///<remarks>to to evaluate the correctness of the result, the mathematical product of the logarithm of the first parameter by the required degree
                ///is compared with the logarithm of the maximum value of the int type</remarks>
                if (Math.Log10(Math.Abs(input1)) * input2 < Math.Log10(int.MaxValue))
                {
                    int result = 1;
                    for (var i = 0; i < input2; i++)
                    {
                        result *= input1;
                    }
                    return result;
                }
                else throw new OverflowException($"Result is outside the range of int values.");
            }
            else throw new ArgumentException($"Second parameter can't be negative, given: {input2}.");
        }
    }
}
