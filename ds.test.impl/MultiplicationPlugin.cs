using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class MultiplicationPlugin : IPlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        //public System.Drawing.Image Image { get; }
        public string Description { get; }
        public int Run(int num1, int num2)
        {
            return num1 * num2;
        }
        public MultiplicationPlugin(string pluginName, string version, string desc)
        {
            PluginName = pluginName;
            Version = version;
            //Image = image;
            Description = desc;
        }
    }
}
