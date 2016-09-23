using System.Collections.Generic;
using System.Linq;
using VisioAutomation.Scripting.Layout;
using VisioAutomation.Scripting.Utilities;

namespace VisioAutomation.Scripting.Commands
{
    public class SnapCommands : CommandSet
    {
        internal SnapCommands(Client client) :
            base(client)
        {
        }

        public void SnapSize(TargetShapes targets, double w, double h)
        {
            this._client.Application.AssertApplicationAvailable();
            this._client.Document.AssertDocumentAvailable();

            var shapes = targets.ResolveShapes2DOnly(this._client);
            if (shapes.Count < 1)
            {
                return;
            }


            var shapeids = shapes.Select(s => s.ID).ToList();

            var application = this._client.Application.Get();
            var target_ids = targets.ToShapeIDs(application.ActivePage);
            using (var undoscope = this._client.Application.NewUndoScope("Snape Shape Sizes"))
            {
                var snapsize = new Drawing.Size(w, h);
                var minsize = new Drawing.Size(w, h);
                ArrangeHelper.SnapSize(target_ids, snapsize, minsize);
            }
        }

        public void SnapCorner(TargetShapes targets, double w, double h, SnapCornerPosition corner)
        {
            this._client.Application.AssertApplicationAvailable();
            this._client.Document.AssertDocumentAvailable();

            var shapes = targets.ResolveShapes2DOnly(this._client);

            if (shapes.Count < 1)
            {
                return;
            }

            var application = this._client.Application.Get();
            var target_ids = targets.ToShapeIDs(application.ActivePage);
            using (var undoscope = this._client.Application.NewUndoScope("SnapCorner"))
            {
                ArrangeHelper.SnapCorner(target_ids, new Drawing.Size(w, h), corner);
            }
        }

        public void SnapSize(TargetShapes targets, Drawing.Size snapsize, Drawing.Size minsize)
        {
            this._client.Application.AssertApplicationAvailable();
            this._client.Document.AssertDocumentAvailable();

            var shapes = targets.ResolveShapes2DOnly(this._client);

            if (shapes.Count < 1)
            {
                return;
            }

            var application = this._client.Application.Get();
            var target_ids = targets.ToShapeIDs(application.ActivePage);
            using (var undoscope = this._client.Application.NewUndoScope("SnapSize"))
            {
                ArrangeHelper.SnapSize(target_ids, snapsize, minsize);
            }
        }
    }
}