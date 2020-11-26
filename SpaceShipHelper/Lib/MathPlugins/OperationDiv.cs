using System;
using System.Drawing;

namespace ds.test.impl.MathPlugins
{
    /// <summary>
    /// Plugin for the mathematical operation of finding an integer part of dividing two numbers
    /// </summary>
    internal class OperationDiv : PluginWithCheckNegativNumber
    {
        public override string PluginName => "DIV";

        public override Image Image => Image.FromFile(Properties.Resources.div);

        public override string Description => "Calculating integer part of dividing the first number by the second";

        /// <summary>
        /// Main method for calculating integer part of dividing
        /// </summary>
        /// <param name="input1">Number whose integer part of division by divider must be found</param>
        /// <param name="input2">Divider</param>
        /// <returns>Integer part of dividing the first parameter by the second(divider)</returns>
        /// <exception cref="System.ArgumentException">Thrown when second parameter (divider) is negative or equal zero.</exception>
        public override int Run(int input1, int input2)
        {
            
            if (checkForNonNegativeNumber(input2)&& input2!=0)
            {
                /// <remarks>for a negative number, calculated the integer part of the division of its non-negative part (input1 * -1),
                /// after which made the result negative for the correctness of the answer</remarks>
                if (input1 < 0) return subtractionСycle(input1 * -1, input2) * -1;
                else return subtractionСycle(input1, input2);
            }
            else throw new ArgumentException($"Second parameter can't be negative and zero, given: {input2}.");
        }

        private int subtractionСycle(int number, int subtrahend)
        {
            int result = 0;
            while (number >= subtrahend)
            {
                result++;
                number -= subtrahend;
            }
            return result;
        }
    }
}
