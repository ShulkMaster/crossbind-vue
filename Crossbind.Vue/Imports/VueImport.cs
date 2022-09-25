using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossbind_Vue.Imports;

public abstract class VueImport
{
    public string ModulePath { get; set; }

    protected VueImport(string modulePath)
    {
        ModulePath = modulePath;
    }

    public abstract void WriteImportStatement(StringBuilder sb, int indent);
}
