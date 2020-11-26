namespace ds.test.impl.Interfaces
{
    interface PluginFactory
    {
        /// <value>Count of plugins</value>
        int PluginsCount { get; }

        /// <value>List of plugins</value>
        string[] GetPluginNames { get; }

        /// <returns>
        /// Plugin by given name of plugin
        /// </returns>
        IPlugin GetPlugin(string pluginName);
    }
}
