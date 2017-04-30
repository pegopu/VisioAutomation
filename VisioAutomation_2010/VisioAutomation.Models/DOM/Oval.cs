﻿namespace VisioAutomation.Models.Dom
{
    public class Oval : BaseShape
    {
        public Geometry.Point P0 { get; private set; }
        public Geometry.Point P1 { get; private set; }

        public Oval(double x0, double y0, double x1, double y1)
        {
            this.P0 = new Geometry.Point(x0, y0);
            this.P1 = new Geometry.Point(x1, y1);
        }

        public Oval(Geometry.Point p0, Geometry.Point p1)
        {
            this.P0 = p0;
            this.P1 = p1;
        }

        public Oval(Geometry.Rectangle r0)
        {
            this.P0 = r0.LowerLeft;
            this.P1 = r0.UpperRight;
        }
    }
}
