using Microsoft.VisualStudio.TestTools.UnitTesting;
using VA = VisioAutomation;

namespace TestVisioAutomation
{
    [TestClass]
    public class ScriptingDevTests : VisioAutomationTest
    {
        [TestMethod]
        public void Scripting_Dev_ScriptingDocumentation()
        {
            var ss = GetScriptingSession();
            ss.Developer.DrawScriptingDocumentation();
        }
    }
}