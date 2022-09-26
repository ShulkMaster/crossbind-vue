using CrossBind.Engine.BaseModels;
using CrossBind.Engine.ComponentModels;

namespace Crossbind_Vue.Component;

// Vue component common definitions
public class VueComponent
{
    public string componentName { get; init; } = string.Empty;
    public List<PropModel> Props { get; init; } = new();
    public ComponentModel Model { get; init; } = null!;
}
