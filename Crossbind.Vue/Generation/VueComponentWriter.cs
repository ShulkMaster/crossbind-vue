using Crossbind_Vue.Component;
using Crossbind_Vue.Imports;
using System.Text;

namespace Crossbind_Vue.Generation;

public class VueComponentWriter
{
    private readonly StringBuilder _sb;

    public VueComponentWriter(StringBuilder sb)
    {
        _sb = sb;
    }

    public void WriteSourceCode(VueModule module)
    {
        WriteTemplateSection();
        WriteScriptSection(module);
        WriteStyleSection();
    }

    #region Vue SFC Sections
    private void WriteTemplateSection()
    {
        _sb.AppendLine("<template>");
        // TODO: Add write markup section
        _sb.AppendLine("</template>");
    }

    private void WriteScriptSection(VueModule module)
    {
        _sb.AppendLine("<script>");
        // TODO: Fill all the vue component config such as props, component name HERE
        WriteImports(module.DefaultImports);
        _sb.AppendLine("</script>");
    }

    private void WriteStyleSection()
    {
        _sb.AppendLine("<style scoped>");
        // TODO: Handle css imports here
        _sb.AppendLine("</style");
    }
    #endregion

    private void WriteImports(IEnumerable<DefaultImport> imports)
    {
        foreach (DefaultImport import in imports)
        {
            _sb.Append($"import {import.ModuleName}");

            /*if (import.Symbols.Any())
            {
                _sb.Append(", {");
                foreach (string symbol in import.Symbols)
                {
                    _sb.Append($" {symbol},");
                }

                _sb.Pop();
                _sb.Append('}');
            }*/

            _sb.AppendLine($" from '{import.ModulePath}';");
        }
    }
}

