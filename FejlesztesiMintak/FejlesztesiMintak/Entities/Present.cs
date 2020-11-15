using FejlesztesiMintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlesztesiMintak.Entities
{
    class Present : Toy
    {
        public SolidBrush Ribbon { get; private set; }
        public SolidBrush Box { get; private set; }
        public Present(Color ribbon, Color box)
        {
            Ribbon = new SolidBrush(ribbon);
            Box = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(Box, 0, 0, Width, Height);
            g.FillRectangle(Ribbon, (Width-Width/5)/2, 0, Width / 5, Height);
            g.FillRectangle(Ribbon, 0, (Height-Height/5)/2, Width, Height / 5);
        }
    }
}
