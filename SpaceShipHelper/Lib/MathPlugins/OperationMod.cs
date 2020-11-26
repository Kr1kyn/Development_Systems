using System;
using System.Drawing;

namespace ds.test.impl.MathPlugins
{
    /// <summary>
    /// Plugin for the mathematical operation of finding the remainder of dividing two numbers
    /// </summary>
    internal class OperationMod : PluginWithCheckNegativNumber
    {
        public override string PluginName => "MOD";

        public override Image Image => Image.FromFile(Properties.Resources.mod);

        public override string Description => "Calculation remainder of dividing the first number by the second";

        /// <summary>
        /// Main method for calculating remainder of dividing
        /// </summary>
        /// <param name="input1">Number whose remainder of division by divider must be found</param>
        /// <param name="input2">Divider</param>
        /// <returns>Remainder of dividing the first parameter by the second(divider)</returns>
        /// <exception cref="System.ArgumentException">Thrown when second parameter (divider) is negative or equal zero.</exception>
        public override int Run(int input1, int input2)
        {
            var result = 0;
            if (checkForNonNegativeNumber(input2)&& input2 != 0)
            {
                if (input1 > 0) result = subtractionСycle(input1, input2);
                /// <remarks>for a negative number, calculated the remainder of division of its non-negative part (input1 * -1),
                /// after which made the result negative for the correctness of the answer</remarks>
                else result = subtractionСycle(input1 * -1, input2) * -1;
                return result;
            }
            else throw new ArgumentException($"Second parameter can't be negative and zero, given: {input2}.");
        }

        private int subtractionСycle(int number, int subtrahend)
        {
            while (number >= subtrahend)
            {
                number -= subtrahend;
            }
            return number;
        }
    }
}
