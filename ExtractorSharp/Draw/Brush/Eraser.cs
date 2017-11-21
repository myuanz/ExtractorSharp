﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractorSharp.Draw.Brush {
    class Eraser : IBrush {
        public Cursor Cursor => Cursors.Hand;

        public int Radius { set; get; } = 10;
        public Point Location { set; get; }

        public void Draw(IPaint layer, Point point, decimal scale) {

        }
    }
}