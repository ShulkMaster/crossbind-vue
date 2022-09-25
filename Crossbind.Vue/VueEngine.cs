using CrossBind.Engine;
using CrossBind.Engine.BaseModels;
using CrossBind.Engine.Generated;
using Crossbind_Vue.Generation;
using System;
using System.Text;

namespace Crossbind_Vue
{
    public class VueEngine : IEngine
    {
        public string Name => "Vue Engine Official";

        // TODO: Añadir el modulo de Vue y un compile component
        public SourceFile[] CompileUnit(UnitModel unit)
        {
            string baseName = Path.GetFileName(unit.FilePath);
            int dotIndex = baseName.LastIndexOf('.');
            string fileName = baseName[..dotIndex];

            var files = new List<SourceFile>();

            var sb = new StringBuilder();
            VueComponentWriter vueCW = new(sb);

            return files.ToArray();
        }
    }
}