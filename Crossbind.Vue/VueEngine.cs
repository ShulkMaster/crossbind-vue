using CrossBind.Engine;
using CrossBind.Engine.BaseModels;
using CrossBind.Engine.Generated;
using System;

namespace Crossbind_Vue
{
    public class VueEngine : IEngine
    {
        public string Name => "Vue Engine Official";

        public SourceFile[] CompileUnit(UnitModel unit)
        {
            throw new NotImplementedException();
        }
    }
}