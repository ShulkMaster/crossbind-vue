using CrossBind.Engine;
using CrossBind.Engine.BaseModels;
using CrossBind.Engine.ComponentModels;
using CrossBind.Engine.Generated;
using Crossbind_Vue.Component;
using Crossbind_Vue.Generation;
using System;
using System.Text;

namespace Crossbind_Vue
{
    public class VueEngine : IEngine
    {
        public string Name => "Vue Engine Official";

        private static VueComponent CompileComponent(ComponentModel model)
        {
            return new VueComponent
            {
                componentName = model.Name,
                Model = model
            };
        }

        // TODO: Añadir el modulo de Vue y un compile component
        public SourceFile[] CompileUnit(UnitModel unit)
        {
            string baseName = Path.GetFileName(unit.FilePath);
            int dotIndex = baseName.LastIndexOf('.');
            string fileName = baseName[..dotIndex];

            var module = new VueModule(unit.FilePath.Replace(Path.PathSeparator, '.'));
            module.ResolveImports(unit);
            var files = new List<SourceFile>();

            foreach (BindModel model in unit.Models)
            {
                switch (model)
                {
                    case ComponentModel cModel:
                    {
                        VueComponent component = CompileComponent(cModel);
                        module.Components.Add(component);
                        break;
                    }
                }
            }

            var sb = new StringBuilder();
            VueComponentWriter vueCW = new(sb);

            vueCW.WriteSourceCode(module);

            files.Add(new SourceFile(fileName, "vue")
            {
                SourceCode = sb.ToString(),
                SourceName = unit.FilePath,
            });

            return files.ToArray();
        }
    }
}