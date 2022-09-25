using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossbind_Vue.Imports;

public sealed class DefaultImport : VueImport
{
    public string ModuleName { get; init; } = string.Empty;

    public DefaultImport(string path) : base(path)
    {
    }

    public override void WriteImportStatement(StringBuilder sb, int indent)
    {
        sb.Append(' ', indent);
        sb.Append($"import {ModuleName} from '{ModulePath}'");
    }
}
