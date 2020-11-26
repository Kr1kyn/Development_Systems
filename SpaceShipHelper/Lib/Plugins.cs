using ds.test.impl.Interfaces;
using System.Linq;

namespace ds.test.impl
{
    /// <summary>
    /// Provides a collection of plugins for working with integers, with the ability to get the desired plugin by the plugin name
    /// </summary>
    public static class Plugins
    {
        private static PluginFactory usedPlugin;
        /// <value>Count of plugins.</value>
        public static int PluginsCount => usedPlugin.PluginsCount;

        /// <value>List of plugins.</value>
        public static string[] GetPluginNames => usedPlugin.GetPluginNames;

        static Plugins()
        {
            usedPlugin = new MathPlugin();
        }

        /// <summary>
        /// Main method for getting need plugin by given name of plugin
        /// </summary>
        /// <param name="pluginName">String veiw of the plugin name</param>
        /// <returns>Plugin that implements the IPlugin interface by the passed plugin name</returns>
        /// <exception cref="InvalidPluginNameException">Thrown when the plugin by the given plugin name not exist</exception>
        public static IPlugin GetPlugin(string pluginName)
        {
            if (GetPluginNames.Any(item => item == pluginName))
            {
                return usedPlugin.GetPlugin(pluginName);
            }
            else throw new InvalidPluginNameException($"Wrong plugin name, you given: {pluginName}.");
        }
    }
}

    