using System.Collections.Generic;
using VisioAutomation.ShapeSheet.CellGroups;
using IVisio = Microsoft.Office.Interop.Visio;

namespace VisioAutomation.Pages
{
    public class PageFormatCells : ShapeSheet.CellGroups.CellGroupSingleRow
    {
        public VisioAutomation.ShapeSheet.CellValueLiteral DrawingScale { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral DrawingScaleType { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral DrawingSizeType { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral InhibitSnap { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral Height { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral Scale { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral Width { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral ShadowObliqueAngle { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral ShadowOffsetX { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral ShadowOffsetY { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral ShadowScaleFactor { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral ShadowType { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral UIVisibility { get; set; }
        public VisioAutomation.ShapeSheet.CellValueLiteral DrawingResizeType { get; set; } // new in visio 2010

        public override IEnumerable<SrcValuePair> SrcValuePairs
        {
            get
            { 
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageDrawingScale, this.DrawingScale.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageDrawingScaleType, this.DrawingScaleType.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageDrawingSizeType, this.DrawingSizeType.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageInhibitSnap, this.InhibitSnap.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageHeight, this.Height.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageScale, this.Scale.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageWidth, this.Width.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageShadowObliqueAngle, this.ShadowObliqueAngle.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageShadowOffsetX, this.ShadowOffsetX.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageShadowOffsetY, this.ShadowOffsetY.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageShadowScaleFactor, this.ShadowScaleFactor.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageShadowType, this.ShadowType.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageUIVisibility, this.UIVisibility.Value);
                yield return SrcValuePair.Create(ShapeSheet.SrcConstants.PageDrawingResizeType, this.DrawingResizeType.Value);
            }
        }

        public static PageFormatCells GetFormulas(IVisio.Shape shape)
        {
            var query = PageFormatCells.lazy_query.Value;
            return query.GetFormulas(shape);
        }

        public static PageFormatCells GetResults(IVisio.Shape shape)
        {
            var query = PageFormatCells.lazy_query.Value;
            return query.GetResults(shape);
        }
        private static readonly System.Lazy<PageFormatCellsReader> lazy_query = new System.Lazy<PageFormatCellsReader>();
    }
}