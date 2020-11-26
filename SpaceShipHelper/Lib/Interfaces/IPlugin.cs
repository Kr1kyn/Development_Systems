namespace ds.test.impl.Interfaces
{
    /// <summary>
    /// Interface for plugin that allows to execute operations on integers
    /// </summary>
    public interface IPlugin
    {
        /// <value>Name of plugin</value>
        string PluginName { get; }

        /// <value>Version of plugin</value>
        string Version { get; }

        /// <value>Graphic icon of math operation</value>
        System.Drawing.Image Image { get; }

        /// <value>Description of what the plugin does</value>
        string Description { get; }

        /// <summary>
        /// Tha main method that do math operation
        /// </summary>
        /// <returns>Integer result of math operation</returns>
        int Run(int input1, int input2);
    }
}
