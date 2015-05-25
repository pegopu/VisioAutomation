namespace VisioAutomation.ShapeSheet.Query.Common
{
    class PageCellsQuery : CellQuery
    {
        public Query.CellColumn PageLeftMargin { get; set; }
        public Query.CellColumn CenterX { get; set; }
        public Query.CellColumn CenterY { get; set; }
        public Query.CellColumn OnPage { get; set; }
        public Query.CellColumn PageBottomMargin { get; set; }
        public Query.CellColumn PageRightMargin { get; set; }
        public Query.CellColumn PagesX { get; set; }
        public Query.CellColumn PagesY { get; set; }
        public Query.CellColumn PageTopMargin { get; set; }
        public Query.CellColumn PaperKind { get; set; }
        public Query.CellColumn PrintGrid { get; set; }
        public Query.CellColumn PrintPageOrientation { get; set; }
        public Query.CellColumn ScaleX { get; set; }
        public Query.CellColumn ScaleY { get; set; }
        public Query.CellColumn PaperSource { get; set; }
        public Query.CellColumn DrawingScale { get; set; }
        public Query.CellColumn DrawingScaleType { get; set; }
        public Query.CellColumn DrawingSizeType { get; set; }
        public Query.CellColumn InhibitSnap { get; set; }
        public Query.CellColumn PageHeight { get; set; }
        public Query.CellColumn PageScale { get; set; }
        public Query.CellColumn PageWidth { get; set; }
        public Query.CellColumn ShdwObliqueAngle { get; set; }
        public Query.CellColumn ShdwOffsetX { get; set; }
        public Query.CellColumn ShdwOffsetY { get; set; }
        public Query.CellColumn ShdwScaleFactor { get; set; }
        public Query.CellColumn ShdwType { get; set; }
        public Query.CellColumn UIVisibility { get; set; }
        public Query.CellColumn XGridDensity { get; set; }
        public Query.CellColumn XGridOrigin { get; set; }
        public Query.CellColumn XGridSpacing { get; set; }
        public Query.CellColumn XRulerDensity { get; set; }
        public Query.CellColumn XRulerOrigin { get; set; }
        public Query.CellColumn YGridDensity { get; set; }
        public Query.CellColumn YGridOrigin { get; set; }
        public Query.CellColumn YGridSpacing { get; set; }
        public Query.CellColumn YRulerDensity { get; set; }
        public Query.CellColumn YRulerOrigin { get; set; }
        public Query.CellColumn AvenueSizeX { get; set; }
        public Query.CellColumn AvenueSizeY { get; set; }
        public Query.CellColumn BlockSizeX { get; set; }
        public Query.CellColumn BlockSizeY { get; set; }
        public Query.CellColumn CtrlAsInput { get; set; }
        public Query.CellColumn DynamicsOff { get; set; }
        public Query.CellColumn EnableGrid { get; set; }
        public Query.CellColumn LineAdjustFrom { get; set; }
        public Query.CellColumn LineAdjustTo { get; set; }
        public Query.CellColumn LineJumpCode { get; set; }
        public Query.CellColumn LineJumpFactorX { get; set; }
        public Query.CellColumn LineJumpFactorY { get; set; }
        public Query.CellColumn LineJumpStyle { get; set; }
        public Query.CellColumn LineRouteExt { get; set; }
        public Query.CellColumn LineToLineX { get; set; }
        public Query.CellColumn LineToLineY { get; set; }
        public Query.CellColumn LineToNodeX { get; set; }
        public Query.CellColumn LineToNodeY { get; set; }
        public Query.CellColumn PageLineJumpDirX { get; set; }
        public Query.CellColumn PageLineJumpDirY { get; set; }
        public Query.CellColumn PageShapeSplit { get; set; }
        public Query.CellColumn PlaceDepth { get; set; }
        public Query.CellColumn PlaceFlip { get; set; }
        public Query.CellColumn PlaceStyle { get; set; }
        public Query.CellColumn PlowCode { get; set; }
        public Query.CellColumn ResizePage { get; set; }
        public Query.CellColumn RouteStyle { get; set; }
        public Query.CellColumn AvoidPageBreaks { get; set; }
        public Query.CellColumn DrawingResizeType { get; set; }

        public PageCellsQuery()
        {
            this.PageLeftMargin = this.AddCell(ShapeSheet.SRCConstants.PageLeftMargin, "PageLeftMargin");
            this.CenterX = this.AddCell(ShapeSheet.SRCConstants.CenterX, "CenterX");
            this.CenterY = this.AddCell(ShapeSheet.SRCConstants.CenterY, "CenterY");
            this.OnPage = this.AddCell(ShapeSheet.SRCConstants.OnPage, "OnPage");
            this.PageBottomMargin = this.AddCell(ShapeSheet.SRCConstants.PageBottomMargin, "PageBottomMargin");
            this.PageRightMargin = this.AddCell(ShapeSheet.SRCConstants.PageRightMargin, "PageRightMargin");
            this.PagesX = this.AddCell(ShapeSheet.SRCConstants.PagesX, "PagesX");
            this.PagesY = this.AddCell(ShapeSheet.SRCConstants.PagesY, "PagesY");
            this.PageTopMargin = this.AddCell(ShapeSheet.SRCConstants.PageTopMargin, "PageTopMargin");
            this.PaperKind = this.AddCell(ShapeSheet.SRCConstants.PaperKind, "PaperKind");
            this.PrintGrid = this.AddCell(ShapeSheet.SRCConstants.PrintGrid, "PrintGrid");
            this.PrintPageOrientation = this.AddCell(ShapeSheet.SRCConstants.PrintPageOrientation, "PrintPageOrientation");
            this.ScaleX = this.AddCell(ShapeSheet.SRCConstants.ScaleX, "ScaleX");
            this.ScaleY = this.AddCell(ShapeSheet.SRCConstants.ScaleY, "ScaleY");
            this.PaperSource = this.AddCell(ShapeSheet.SRCConstants.PaperSource, "PaperSource");
            this.DrawingScale = this.AddCell(ShapeSheet.SRCConstants.DrawingScale, "DrawingScale");
            this.DrawingScaleType = this.AddCell(ShapeSheet.SRCConstants.DrawingScaleType, "DrawingScaleType");
            this.DrawingSizeType = this.AddCell(ShapeSheet.SRCConstants.DrawingSizeType, "DrawingSizeType");
            this.InhibitSnap = this.AddCell(ShapeSheet.SRCConstants.InhibitSnap, "InhibitSnap");
            this.PageHeight = this.AddCell(ShapeSheet.SRCConstants.PageHeight, "PageHeight");
            this.PageScale = this.AddCell(ShapeSheet.SRCConstants.PageScale, "PageScale");
            this.PageWidth = this.AddCell(ShapeSheet.SRCConstants.PageWidth, "PageWidth");
            this.ShdwObliqueAngle = this.AddCell(ShapeSheet.SRCConstants.ShdwObliqueAngle, "ShdwObliqueAngle");
            this.ShdwOffsetX = this.AddCell(ShapeSheet.SRCConstants.ShdwOffsetX, "ShdwOffsetX");
            this.ShdwOffsetY = this.AddCell(ShapeSheet.SRCConstants.ShdwOffsetY, "ShdwOffsetY");
            this.ShdwScaleFactor = this.AddCell(ShapeSheet.SRCConstants.ShdwScaleFactor, "ShdwScaleFactor");
            this.ShdwType = this.AddCell(ShapeSheet.SRCConstants.ShdwType, "ShdwType");
            this.UIVisibility = this.AddCell(ShapeSheet.SRCConstants.UIVisibility, "UIVisibility");
            this.XGridDensity = this.AddCell(ShapeSheet.SRCConstants.XGridDensity, "XGridDensity");
            this.XGridOrigin = this.AddCell(ShapeSheet.SRCConstants.XGridOrigin, "XGridOrigin");
            this.XGridSpacing = this.AddCell(ShapeSheet.SRCConstants.XGridSpacing, "XGridSpacing");
            this.XRulerDensity = this.AddCell(ShapeSheet.SRCConstants.XRulerDensity, "XRulerDensity");
            this.XRulerOrigin = this.AddCell(ShapeSheet.SRCConstants.XRulerOrigin, "XRulerOrigin");
            this.YGridDensity = this.AddCell(ShapeSheet.SRCConstants.YGridDensity, "YGridDensity");
            this.YGridOrigin = this.AddCell(ShapeSheet.SRCConstants.YGridOrigin, "YGridOrigin");
            this.YGridSpacing = this.AddCell(ShapeSheet.SRCConstants.YGridSpacing, "YGridSpacing");
            this.YRulerDensity = this.AddCell(ShapeSheet.SRCConstants.YRulerDensity, "YRulerDensity");
            this.YRulerOrigin = this.AddCell(ShapeSheet.SRCConstants.YRulerOrigin, "YRulerOrigin");
            this.AvenueSizeX = this.AddCell(ShapeSheet.SRCConstants.AvenueSizeX, "AvenueSizeX");
            this.AvenueSizeY = this.AddCell(ShapeSheet.SRCConstants.AvenueSizeY, "AvenueSizeY");
            this.BlockSizeX = this.AddCell(ShapeSheet.SRCConstants.BlockSizeX, "BlockSizeX");
            this.BlockSizeY = this.AddCell(ShapeSheet.SRCConstants.BlockSizeY, "BlockSizeY");
            this.CtrlAsInput = this.AddCell(ShapeSheet.SRCConstants.CtrlAsInput, "CtrlAsInput");
            this.DynamicsOff = this.AddCell(ShapeSheet.SRCConstants.DynamicsOff, "DynamicsOff");
            this.EnableGrid = this.AddCell(ShapeSheet.SRCConstants.EnableGrid, "EnableGrid");
            this.LineAdjustFrom = this.AddCell(ShapeSheet.SRCConstants.LineAdjustFrom, "LineAdjustFrom");
            this.LineAdjustTo = this.AddCell(ShapeSheet.SRCConstants.LineAdjustTo, "LineAdjustTo");
            this.LineJumpCode = this.AddCell(ShapeSheet.SRCConstants.LineJumpCode, "LineJumpCode");
            this.LineJumpFactorX = this.AddCell(ShapeSheet.SRCConstants.LineJumpFactorX, "LineJumpFactorX");
            this.LineJumpFactorY = this.AddCell(ShapeSheet.SRCConstants.LineJumpFactorY, "LineJumpFactorY");
            this.LineJumpStyle = this.AddCell(ShapeSheet.SRCConstants.LineJumpStyle, "LineJumpStyle");
            this.LineRouteExt = this.AddCell(ShapeSheet.SRCConstants.LineRouteExt, "LineRouteExt");
            this.LineToLineX = this.AddCell(ShapeSheet.SRCConstants.LineToLineX, "LineToLineX");
            this.LineToLineY = this.AddCell(ShapeSheet.SRCConstants.LineToLineY, "LineToLineY");
            this.LineToNodeX = this.AddCell(ShapeSheet.SRCConstants.LineToNodeX, "LineToNodeX");
            this.LineToNodeY = this.AddCell(ShapeSheet.SRCConstants.LineToNodeY, "LineToNodeY");
            this.PageLineJumpDirX = this.AddCell(ShapeSheet.SRCConstants.PageLineJumpDirX, "PageLineJumpDirX");
            this.PageLineJumpDirY = this.AddCell(ShapeSheet.SRCConstants.PageLineJumpDirY, "PageLineJumpDirY");
            this.PageShapeSplit = this.AddCell(ShapeSheet.SRCConstants.PageShapeSplit, "PageShapeSplit");
            this.PlaceDepth = this.AddCell(ShapeSheet.SRCConstants.PlaceDepth, "PlaceDepth");
            this.PlaceFlip = this.AddCell(ShapeSheet.SRCConstants.PlaceFlip, "PlaceFlip");
            this.PlaceStyle = this.AddCell(ShapeSheet.SRCConstants.PlaceStyle, "PlaceStyle");
            this.PlowCode = this.AddCell(ShapeSheet.SRCConstants.PlowCode, "PlowCode");
            this.ResizePage = this.AddCell(ShapeSheet.SRCConstants.ResizePage, "ResizePage");
            this.RouteStyle = this.AddCell(ShapeSheet.SRCConstants.RouteStyle, "RouteStyle");
            this.AvoidPageBreaks = this.AddCell(ShapeSheet.SRCConstants.AvoidPageBreaks, "AvoidPageBreaks");
            this.DrawingResizeType = this.AddCell(ShapeSheet.SRCConstants.DrawingResizeType, "DrawingResizeType");
        }


        public VisioAutomation.Pages.PageCells GetCells(System.Collections.Generic.IList<ShapeSheet.CellData<double>> row)
        {

            var cells = new VisioAutomation.Pages.PageCells();
            cells.PageLeftMargin = row[this.PageLeftMargin];
            cells.CenterX = row[this.CenterX];
            cells.CenterY = row[this.CenterY];
            cells.OnPage = Extensions.CellDataMethods.ToInt(row[this.OnPage]);
            cells.PageBottomMargin = row[this.PageBottomMargin];
            cells.PageRightMargin = row[this.PageRightMargin];
            cells.PagesX = row[this.PagesX];
            cells.PagesY = row[this.PagesY];
            cells.PageTopMargin = row[this.PageTopMargin];
            cells.PaperKind = Extensions.CellDataMethods.ToInt(row[this.PaperKind]);
            cells.PrintGrid = Extensions.CellDataMethods.ToInt(row[this.PrintGrid]);
            cells.PrintPageOrientation = Extensions.CellDataMethods.ToInt(row[this.PrintPageOrientation]);
            cells.ScaleX = row[this.ScaleX];
            cells.ScaleY = row[this.ScaleY];
            cells.PaperSource = Extensions.CellDataMethods.ToInt(row[this.PaperSource]);
            cells.DrawingScale = row[this.DrawingScale];
            cells.DrawingScaleType = Extensions.CellDataMethods.ToInt(row[this.DrawingScaleType]);
            cells.DrawingSizeType = Extensions.CellDataMethods.ToInt(row[this.DrawingSizeType]);
            cells.InhibitSnap = Extensions.CellDataMethods.ToInt(row[this.InhibitSnap]);
            cells.PageHeight = row[this.PageHeight];
            cells.PageScale = row[this.PageScale];
            cells.PageWidth = row[this.PageWidth];
            cells.ShdwObliqueAngle = row[this.ShdwObliqueAngle];
            cells.ShdwOffsetX = row[this.ShdwOffsetX];
            cells.ShdwOffsetY = row[this.ShdwOffsetY];
            cells.ShdwScaleFactor = row[this.ShdwScaleFactor];
            cells.ShdwType = Extensions.CellDataMethods.ToInt(row[this.ShdwType]);
            cells.UIVisibility = row[this.UIVisibility];
            cells.XGridDensity = row[this.XGridDensity];
            cells.XGridOrigin = row[this.XGridOrigin];
            cells.XGridSpacing = row[this.XGridSpacing];
            cells.XRulerDensity = row[this.XRulerDensity];
            cells.XRulerOrigin = row[this.XRulerOrigin];
            cells.YGridDensity = row[this.YGridDensity];
            cells.YGridOrigin = row[this.YGridOrigin];
            cells.YGridSpacing = row[this.YGridSpacing];
            cells.YRulerDensity = row[this.YRulerDensity];
            cells.YRulerOrigin = row[this.YRulerOrigin];
            cells.AvenueSizeX = row[this.AvenueSizeX];
            cells.AvenueSizeY = row[this.AvenueSizeY];
            cells.BlockSizeX = row[this.BlockSizeX];
            cells.BlockSizeY = row[this.BlockSizeY];
            cells.CtrlAsInput = Extensions.CellDataMethods.ToInt(row[this.CtrlAsInput]);
            cells.DynamicsOff = Extensions.CellDataMethods.ToInt(row[this.DynamicsOff]);
            cells.EnableGrid = Extensions.CellDataMethods.ToInt(row[this.EnableGrid]);
            cells.LineAdjustFrom = Extensions.CellDataMethods.ToInt(row[this.LineAdjustFrom]);
            cells.LineAdjustTo = row[this.LineAdjustTo];
            cells.LineJumpCode = row[this.LineJumpCode];
            cells.LineJumpFactorX = row[this.LineJumpFactorX];
            cells.LineJumpFactorY = row[this.LineJumpFactorY];
            cells.LineJumpStyle = Extensions.CellDataMethods.ToInt(row[this.LineJumpStyle]);
            cells.LineRouteExt = row[this.LineRouteExt];
            cells.LineToLineX = row[this.LineToLineX];
            cells.LineToLineY = row[this.LineToLineY];
            cells.LineToNodeX = row[this.LineToNodeX];
            cells.LineToNodeY = row[this.LineToNodeY];
            cells.PageLineJumpDirX = row[this.PageLineJumpDirX];
            cells.PageLineJumpDirY = row[this.PageLineJumpDirY];
            cells.PageShapeSplit = Extensions.CellDataMethods.ToInt(row[this.PageShapeSplit]);
            cells.PlaceDepth = Extensions.CellDataMethods.ToInt(row[this.PlaceDepth]);
            cells.PlaceFlip = Extensions.CellDataMethods.ToInt(row[this.PlaceFlip]);
            cells.PlaceStyle = Extensions.CellDataMethods.ToInt(row[this.PlaceStyle]);
            cells.PlowCode = Extensions.CellDataMethods.ToInt(row[this.PlowCode]);
            cells.ResizePage = Extensions.CellDataMethods.ToInt(row[this.ResizePage]);
            cells.RouteStyle = Extensions.CellDataMethods.ToInt(row[this.RouteStyle]);
            cells.AvoidPageBreaks = Extensions.CellDataMethods.ToInt(row[this.AvoidPageBreaks]);
            cells.DrawingResizeType = Extensions.CellDataMethods.ToInt(row[this.DrawingResizeType]);
            return cells;
        }

    }
}