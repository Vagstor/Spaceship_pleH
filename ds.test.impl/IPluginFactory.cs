using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    interface IPluginFactory
    {
        IPlugin GetPlugin(string pluginName);
    }
}
