using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer
{
    public class HighlightedBounds
    {
        public IList<PdfRectangle> Bounds { get; set; }
        public string Text { get; set; }

        public HighlightedBounds(IList<PdfRectangle> bounds, string refText)
        {
            Bounds = bounds;
            Text = refText;
        }
    }
}
