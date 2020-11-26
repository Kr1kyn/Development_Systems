using ds.test.impl.Interfaces;
using System;
using System.Drawing;

namespace ds.test.impl.MathPlugins
{
    /// <summary>
    /// Plugin for calculating difference between two numbers
    /// </summary>
    internal class OperationSubsract : IPlugin
    {
        public string PluginName => "SUB";

        public string Version => "v.0.1";

        public Image Image => Image.FromFile(Properties.Resources.sub);

        public string Description => "Calculation difference obtained when subtracting from the first number of the second";

        /// <summary>
        /// The main method for calculating the difference obtained by subtracting a number from the first parameter of a number from the second parameter
        /// </summary>
        /// <param name="input1">The number to be subtracted from</param>
        /// <param name="input2">The number to be subtracted from the first parameter</param>
        /// <returns>Integer difference between two given numbers</returns>
        /// <exception cref="System.OverflowException">>Thrown when result is outside the range of int values.</exception>
        public int Run(int input1, int input2)
        {
            long result = input1;
            result -= input2;
            if (result > int.MaxValue || result < int.MinValue) throw new OverflowException($"Result is outside the range of int values, result = {result}.");
            return (int)result;
        }
    }
}
