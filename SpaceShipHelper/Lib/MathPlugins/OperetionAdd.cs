using System;
using System.Drawing;
using ds.test.impl.Interfaces;

namespace ds.test.impl.MathPlugins
{
    /// <summary>
    /// Plugin for calculating sum of two integers
    /// </summary>
    internal class OperetionAdd : IPlugin
    {
        public string PluginName => "ADD";

        public string Version => "v.0.1";

        public Image Image => Image.FromFile(Properties.Resources.add);

        public string Description => "Calculation summ of two given integers values";

        /// <summary>
        /// The main method for calculating the sum of integers from the first and second parameters
        /// </summary>
        /// <param name="input1">First summand</param>
        /// <param name="input2">Second summand</param>
        /// <returns>The sum of two given integers</returns>
        /// <exception cref="System.OverflowException">>Thrown when result is outside the range of int values.</exception>
        public int Run(int input1, int input2)
        {
            long result = input1;
            result += input2;
            if (result > int.MaxValue || result < int.MinValue) throw new OverflowException($"Result is outside the range of int values, result = {result}.");
            return (int)result;
        }
    }
}
