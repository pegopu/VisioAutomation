using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisioAutomation.ShapeSheet;
using VA = VisioAutomation;
using IVisio = Microsoft.Office.Interop.Visio;

namespace VisioAutomation_Tests.Core.Shapes
{
    [TestClass]
    public class UserDefinedCellsTests : VisioAutomationTest
    {
        [TestMethod]
        public void UserDefinedCells_GetSet()
        {
            var page1 = this.GetNewPage();

            var s1 = page1.DrawRectangle(0, 0, 2, 2);

            // By default a shape has ZERO custom Properties
            Assert.AreEqual(0, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));

            // Add a Custom Property
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "BAR", null);
            Assert.AreEqual(1, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            // Check that it is called FOO1
            Assert.AreEqual(true, VisioAutomation.Shapes.UserDefinedCellHelper.Contains(s1, "FOO1"));

            // Check that non-existent properties can't be found
            Assert.AreEqual(false, VisioAutomation.Shapes.CustomPropertyHelper.Contains(s1, "FOOX"));



            var udcs = VA.Shapes.UserDefinedCellHelper.GetDictionary(s1, VA.ShapeSheet.CellValueType.Formula);
            Assert.AreEqual(1,udcs.Count);
            Assert.AreEqual("\"BAR\"", udcs["FOO1"].Value.Value);
            Assert.AreEqual("\"\"", udcs["FOO1"].Prompt.Value);

            // Verify that we can set the value without affecting the prompt
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1,"FOO1","BEER",null);
            udcs = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(s1, VA.ShapeSheet.CellValueType.Formula);
            Assert.AreEqual(1, udcs.Count);
            Assert.AreEqual("\"BEER\"", udcs["FOO1"].Value.Value);
            Assert.AreEqual("\"\"", udcs["FOO1"].Prompt.Value);

            // Verify that we can set passing in nulls changes nothing
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", null, null);
            udcs = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(s1, VA.ShapeSheet.CellValueType.Formula);
            Assert.AreEqual(1, udcs.Count);
            Assert.AreEqual("\"BEER\"", udcs["FOO1"].Value.Value);
            Assert.AreEqual("\"\"", udcs["FOO1"].Prompt.Value);

            // Verify that we can set the prompt without affecting the value
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", null, "Prompt1");
            udcs = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(s1, VA.ShapeSheet.CellValueType.Formula);
            Assert.AreEqual(1, udcs.Count);
            Assert.AreEqual("\"BEER\"", udcs["FOO1"].Value.Value);
            Assert.AreEqual("\"Prompt1\"", udcs["FOO1"].Prompt.Value);

            // Delete that custom property
            VisioAutomation.Shapes.UserDefinedCellHelper.Delete(s1, "FOO1");
            // Verify that we have zero Custom Properties
            Assert.AreEqual(0, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));

            page1.Delete(0);
        }

        [TestMethod]
        public void UserDefinedCells_GetFromMultipleShapes()
        {
            var page1 = this.GetNewPage();

            var s1 = page1.DrawRectangle(0, 0, 1, 1);
            var s2 = page1.DrawRectangle(1, 1, 2, 2);
            var shapes = new[] { s1, s2 };

            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "foo", "bar", null);
            var props1 = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(page1, shapes, VisioAutomation.ShapeSheet.CellValueType.Formula);
            Assert.AreEqual(2, props1.Count);
            Assert.AreEqual(1, props1[0].Count);
            Assert.AreEqual(0, props1[1].Count);

            page1.Delete(0);
        }

        [TestMethod]
        public void UserDefinedCells_GetFromMultipleShapes_WithAdditionalProps()
        {
            var page1 = this.GetNewPage();

            var s1 = page1.DrawRectangle(0, 0, 1, 1);
            var s2 = page1.DrawRectangle(1, 1, 2, 2);
            var shapes = new[] { s1, s2 };

            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "foo", "bar", null);

            var query = new VA.ShapeSheet.Query.SectionsQuery();
            var sec = query.SectionQueries.Add(IVisio.VisSectionIndices.visSectionUser);
            var Value = sec.Columns.Add(VisioAutomation.ShapeSheet.SrcConstants.UserDefCellValue,"Value");
            var Prompt = sec.Columns.Add(VisioAutomation.ShapeSheet.SrcConstants.UserDefCellPrompt,"Prompt");

            var formulas = query.GetFormulas(page1, shapes.Select(s => s.ID).ToList());


            page1.Delete(0);
        }

        [TestMethod]
        public void UserDefinedCells_SetMultipleTimes()
        {
            var page1 = this.GetNewPage();

            var s1 = page1.DrawRectangle(0, 0, 2, 2);

            // By default a shape has ZERO custom Properties
            Assert.AreEqual(0, VisioAutomation.Shapes.CustomPropertyHelper.GetCells(s1, CellValueType.Formula).Count);

            // Add the same one multiple times Custom Property
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "BAR1", null);
            // Asset that now we have ONE CustomProperty
            Assert.AreEqual(1, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            // Check that it is called FOO1
            Assert.AreEqual(true, VisioAutomation.Shapes.UserDefinedCellHelper.Contains(s1, "FOO1"));

            // Try to SET the same property again many times
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "BAR2", null);
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "BAR3", null);
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "BAR4", null);

            // Asset that now we have ONE CustomProperty
            Assert.AreEqual(1, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            // Check that it is called FOO1
            Assert.IsTrue(VisioAutomation.Shapes.UserDefinedCellHelper.Contains(s1, "FOO1"));
            page1.Delete(0);
        }

        [TestMethod]
        public void UserDefinedCells_InvalidNames()
        {
            if (!VisioAutomation.Shapes.UserDefinedCellHelper.IsValidName("A"))
            {
                Assert.Fail();
            }

            if (!VisioAutomation.Shapes.UserDefinedCellHelper.IsValidName("A.B"))
            {
                Assert.Fail();
            }

            if (VisioAutomation.Shapes.UserDefinedCellHelper.IsValidName("A B") )
            {
                Assert.Fail();
            }

            if (VisioAutomation.Shapes.UserDefinedCellHelper.IsValidName(" ") )
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void UserDefinedCells_CheckInvalidNamesNotAllowed()
        {
            bool caught = false;
            var page1 = this.GetNewPage();
            var s1 = page1.DrawRectangle(0, 0, 2, 2);
            Assert.AreEqual(0, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            try
            {
                VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO 1", "BAR1", null);
            }
            catch (System.ArgumentException)
            {
                // this was expected
                page1.Delete(0);
                caught = true;
            }
            if (caught == false)
            {
                Assert.Fail("Did not catch expected exception");
            }
        }

        [TestMethod]
        public void UserDefinedCells_SetAdditionalProperties()
        {
            var page1 = this.GetNewPage();
            var s1 = page1.DrawRectangle(0, 0, 2, 2);
            Assert.AreEqual(0, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));

            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "foo", null, "Some prmpt");
            Assert.AreEqual(1, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            page1.Delete(0);
        }

        [TestMethod]
        public void UserDefinedCells_GetNames()
        {
            var page1 = this.GetNewPage();
            var s1 = page1.DrawRectangle(0, 0, 2, 2);

            Assert.AreEqual(0, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "BAR1", null);
            Assert.AreEqual(1, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "BAR2", null);
            Assert.AreEqual(1, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO2", "BAR3", null);

            var names1 = VisioAutomation.Shapes.UserDefinedCellHelper.GetNames(s1);
            Assert.AreEqual(2,names1.Count);
            Assert.IsTrue(names1.Contains("FOO1"));
            Assert.IsTrue(names1.Contains("FOO2"));

            Assert.AreEqual(2, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            VisioAutomation.Shapes.UserDefinedCellHelper.Delete(s1, "FOO1");

            var names2 = VisioAutomation.Shapes.UserDefinedCellHelper.GetNames(s1);
            Assert.AreEqual(1, names2.Count);
            Assert.IsTrue(names2.Contains("FOO2"));

            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO3", "BAR1", null);
            var names3 = VisioAutomation.Shapes.UserDefinedCellHelper.GetNames(s1);
            Assert.AreEqual(2, names3.Count);
            Assert.IsTrue(names3.Contains("FOO2"));
            Assert.IsTrue(names3.Contains("FOO3"));

            VisioAutomation.Shapes.UserDefinedCellHelper.Delete(s1, "FOO3");

            Assert.AreEqual(1, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));
            VisioAutomation.Shapes.UserDefinedCellHelper.Delete(s1, "FOO2");

            Assert.AreEqual(0, VisioAutomation.Shapes.UserDefinedCellHelper.GetCount(s1));

            page1.Delete(0);
        }

        [TestMethod]
        public void UserDefinedCells_SetForMultipleShapes()
        {
            var page1 = this.GetNewPage();
            var s1 = page1.DrawRectangle(0, 0, 2, 2);
            var s2 = page1.DrawRectangle(0, 0, 2, 2);
            var s3 = page1.DrawRectangle(0, 0, 2, 2);
            var s4 = page1.DrawRectangle(0, 0, 2, 2);

            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "1", "p1");
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s2, "FOO2", "2", "p2");
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s2, "FOO3", "3", "p3");
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s4, "FOO4", "4", "p4");
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s4, "FOO5", "5", "p4");
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s4, "FOO6", "6", "p6");

            var shapeids = new[] {s1, s2, s3, s4};
            var allprops = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(page1, shapeids, VisioAutomation.ShapeSheet.CellValueType.Formula);

            Assert.AreEqual(4, allprops.Count);
            Assert.AreEqual(1, allprops[0].Count);
            Assert.AreEqual(2, allprops[1].Count);
            Assert.AreEqual(0, allprops[2].Count);
            Assert.AreEqual(3, allprops[3].Count);

            Assert.AreEqual("\"1\"", allprops[0]["FOO1"].Value.Value);
            Assert.AreEqual("\"2\"", allprops[1]["FOO2"].Value.Value);
            Assert.AreEqual("\"3\"", allprops[1]["FOO3"].Value.Value);
            Assert.AreEqual("\"4\"", allprops[3]["FOO4"].Value.Value);
            Assert.AreEqual("\"5\"", allprops[3]["FOO5"].Value.Value);
            Assert.AreEqual("\"6\"", allprops[3]["FOO6"].Value.Value);
            page1.Delete(0);
        }

        [TestMethod]
        public void UserDefinedCells_ValueQuoting()
        {
            var page1 = this.GetNewPage();
            var s1 = page1.DrawRectangle(0, 0, 2, 2);

            var p1 = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(s1, VA.ShapeSheet.CellValueType.Formula);
            Assert.AreEqual(0, p1.Count);

            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO1", "1", null);
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO2", "2", null);
            VisioAutomation.Shapes.UserDefinedCellHelper.Set(s1, "FOO3", "3\"4", null);

            var p2 = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(s1, VA.ShapeSheet.CellValueType.Formula);
            Assert.AreEqual(3, p2.Count);
            
            Assert.AreEqual("\"1\"", p2["FOO1"].Value.Value);
            Assert.AreEqual("\"2\"", p2["FOO2"].Value.Value);
            Assert.AreEqual("\"3\"\"4\"", p2["FOO3"].Value.Value);
            
            var results_dic = VisioAutomation.Shapes.UserDefinedCellHelper.GetDictionary(s1, VisioAutomation.ShapeSheet.CellValueType.Result);
            Assert.AreEqual(3, results_dic.Count);

            Assert.AreEqual("1", results_dic["FOO1"].Value.Value);
            Assert.AreEqual("2", results_dic["FOO2"].Value.Value);
            Assert.AreEqual("3\"4", results_dic["FOO3"].Value.Value);

            page1.Delete(0);
        }
    }
}