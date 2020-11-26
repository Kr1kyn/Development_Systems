using ds.test.impl.Interfaces;
using System;
using System.Drawing;

namespace ds.test.impl.MathPlugins
{
    /// <summary>
    /// Plugin for math operation multiplication of two numbers
    /// </summary>
    internal class OperationMultiply : IPlugin
    {
        public string PluginName => "MULT";

        public string Version => "v.0.1";

        public Image Image => Image.FromFile(Properties.Resources.mult);

        public string Description => "Calculation result of multiplying given two numbers";

        /// <summary>
        /// The main method of multiplying the number from the first parameter(first multiplier) by the number from the second parameter (second multiplier)
        /// </summary>
        /// <param name="input1">First multiplier</param>
        /// <param name="input2">Second multiplier</param>
        /// <returns>Integer is the result of multiplying the first multiplier by the second one</returns>
        /// <exception cref="System.OverflowException">>Thrown when result is outside the range of int values.</exception>
        public int Run(int input1, int input2)
        {
            ///<remarks>to evaluate the correctness of the result, the sum of the logarithms of the modules of the first and second multipliers
            ///is compared with the logarithm of the maximum value of the int type</remarks>
            if (Math.Log10(Math.Abs(input1)) + Math.Log10(Math.Abs(input2)) < Math.Log10(int.MaxValue)) return input1 * input2;
            else throw new OverflowException($"Result is outside the range of int value.");
        }
    }
}
