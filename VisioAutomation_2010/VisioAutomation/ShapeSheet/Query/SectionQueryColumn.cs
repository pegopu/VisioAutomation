﻿namespace VisioAutomation.ShapeSheet.Query
{
    public class SectionQueryColumn : ColumnBase
    {
        public short CellIndex;

        internal SectionQueryColumn(int ordinal, short cell, string name) :
            base(ordinal, name)
        {
            this.CellIndex = cell;
        }
    }
}