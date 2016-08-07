namespace VisioAutomation_Tests
{
    public static class TestExtensions
    {
        public static VisioAutomation.Drawing.Point GetPinPosResult(this VisioAutomation.Shapes.XFormCells xform)
        {
            return new VisioAutomation.Drawing.Point(xform.PinX.Result, xform.PinY.Result);
        }
    }
}