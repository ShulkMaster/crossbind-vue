using CrossBind.Engine.BaseModels;
using Crossbind_Vue.Imports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossbind_Vue.Component;

public class VueModule
{
    public readonly string ModuleId;

    public SortedSet<DefaultImport> DefaultImports { get; } = new();
    public List<VueComponent> Components { get; set; } = new();

    public VueModule(string moduleId)
    {
        ModuleId = moduleId;
    }

    public void ResolveImports(UnitModel unit)
    {
        DefaultImports.Add(new DefaultImport("vue")
        {
            ModuleName = "Vue"
        });

        // TODO: Add named imports
    }
}

