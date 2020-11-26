using ds.test.impl.Interfaces;
using ds.test.impl.MathPlugins;
using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin, which include plugins for math operation 
    /// </summary>
    internal class MathPlugin : PluginFactory
    {
        private List<IPlugin> _plugins;

        /// <value>Count of plugins</value>
        public int PluginsCount => _plugins.Count;

        /// <value>List of plugins</value>
        public string[] GetPluginNames { get; private set; }
        ///
        internal MathPlugin()
        {
            var plugins = new List<IPlugin> { new OperationDiv(), new OperationMod(), new OperationMultiply(), new OperationSubsract(), new OperetionAdd(), new OperationExp()};
            _plugins = new List<IPlugin>();
            _plugins = plugins;
            GetPluginNames = new string[plugins.Count];
            int index = 0;
            foreach (var plugin in _plugins)
            {
                GetPluginNames[index++] = plugin.PluginName;
            }
        }

        /// <summary>
        /// Method for getting need plugin by given name of plugin
        /// </summary>
        /// <param name="pluginName">Name of the required plugin</param>
        /// <returns>One plugin by getting <c>pluginName</c> </returns>
        public IPlugin GetPlugin(string pluginName)
        {
            return _plugins.Where(item => item.PluginName == pluginName).First();
        }
    }
}
