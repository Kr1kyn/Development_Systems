using System;

namespace ds.test.impl
{
    /// <summary>
    /// Exception of wrong given name of plugin
    /// </summary>
    internal class InvalidPluginNameException : Exception
    {
        public InvalidPluginNameException() : base() { }
        public InvalidPluginNameException(string message) : base (message) { }
        public InvalidPluginNameException(string message, Exception innerException) : base(message, innerException) { }
    }
}
