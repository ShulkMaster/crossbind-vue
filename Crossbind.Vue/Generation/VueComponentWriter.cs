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

    private void WriteTemplateSection()
    {
        _sb.AppendLine("<template>");
        // TODO: Add write markup section
        _sb.AppendLine("</template>");
    }

    private void WriteScriptSection()
    {

    }

    private void WriteStyleSection()
    {

    }
}

