using CrossBind.Engine.BaseModels;
using Crossbind_Vue;

namespace CrossBind.Vue.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange: Preparacion
            List<ImportModel> list = new();
            list.Add(new ImportModel("vue", new[] { "xd" }));
            var unit = new UnitModel("", "/myfile.txt", list, ArraySegment<BindModel>.Empty);
            var engine = new VueEngine();

            // act: proceso
            var code = engine.CompileUnit(unit);

            // assert
            Assert.Equal("import { xd} from 'react';\nimport React from 'react';\r\nimport './myfile.css';\r\n\r\n", code[0].SourceCode);
        }
    }
}