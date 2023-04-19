using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9_OAIP_NEW
{
    public class Triangle : Polygon
    {


        public Triangle(int count = 6, int y1 = 0, int x1 = 0, int x2 = 0, int y2 = 0, int x3 = 0, int y3 = 0) : base(count)
        {
            pointFs = new PointF[count];
            pointFs[0].X = x1;
            pointFs[0].Y = y1;
            pointFs[1].X = x2;
            pointFs[1].Y = y2;
            pointFs[2].X = x3;
            pointFs[2].Y = y3;

        }

        public Triangle(PointF[] pointFs, int count = 6) : base(count)
        {
            this.pointFs = pointFs;
        }

    }
}
