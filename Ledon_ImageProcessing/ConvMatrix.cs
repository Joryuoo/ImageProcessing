using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledon_ImageProcessing
{
    public class ConvMatrix
    {
        public int TopLeft = 0, TopMid = 0, TopRight = 0;              // 0 0 0
        public int MidLeft = 0, Pixel = 1, MidRight = 0;               // 0 1 0
        public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;     // 0 0 0
        public int Factor = 1;
        public int Offset = 0;

        public ConvMatrix() { }

        public ConvMatrix
        (
            int topLeft, int topMid, int topRight,
            int midLeft, int pixel, int midRight,
            int bottomLeft, int bottomMid, int bottomRight
        )
        {
            TopLeft = topLeft; TopMid = topMid; TopRight = topRight;
            MidLeft = midLeft; Pixel = pixel; MidRight = midRight;
            BottomLeft = bottomLeft; BottomMid = bottomMid; BottomRight = bottomRight;
        }

        
        public void SetAll(int nVal)
        {
            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
        }

    }
}
