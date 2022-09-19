using CrossBind.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Crossbind_Vue
{
    public class VuePlugin : ICrossPlugin
    {
        public Version Version => new Version(0,1,0);

        public string Name => "Vue Plugin Official";

        public string PluginId => "VUE_TS_CROSSBIND_OFFICIAL";

        public string Target => "VUE";

        public IEngine GetEngineInstance(bool production, JsonObject? options)
        {
            return new VueEngine();
        }
    }
}
