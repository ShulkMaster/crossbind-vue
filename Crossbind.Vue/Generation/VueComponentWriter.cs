using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossbind_Vue.Generation;

public class VueComponentWriter
{
    private readonly StringBuilder _sb;

    public VueComponentWriter(StringBuilder sb)
    {
        _sb = sb;
    }

    public void WriteSourceCode()
    {
        WriteTemplateSection();
        WriteScriptSection();
        WriteStyleSection();
    }

    #region Vue SFC Sections
    private void WriteTemplateSection()
    {
        _sb.AppendLine("<template>");
        // TODO: Add write markup section
        _sb.AppendLine("</template>");
    }

    private void WriteScriptSection()
    {
        _sb.AppendLine("<script>");
        // TODO: Fill all the vue component config such as props, component name HERE
        _sb.AppendLine("</script>");
    }

    private void WriteStyleSection()
    {
        _sb.AppendLine("<style scoped>");
        // TODO: Handle css imports here
        _sb.AppendLine("</style");
    }
    #endregion
}

