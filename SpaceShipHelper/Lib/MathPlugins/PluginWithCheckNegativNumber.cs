using ds.test.impl.Interfaces;
using System.Drawing;

namespace ds.test.impl.MathPlugins
{
    internal abstract class PluginWithCheckNegativNumber :IPlugin
    {
        public abstract string PluginName { get; }
        public string Version => "v.0.1";
        public abstract Image Image { get; }
        public abstract string Description { get; }

        /// <summary>
        /// Check given number for negativity
        /// </summary>
        /// <param name="number">Number, which need to check</param>
        /// <returns>If number isn't negative returned true, else false</returns>
        protected bool checkForNonNegativeNumber(int number)
        {
            if (number < 0) return false;
            else return true;
        }

        public abstract int Run(int input1, int input2);
    }
}
