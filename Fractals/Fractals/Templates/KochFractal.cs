using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Templates
{
    public class KochFractal : Fractal
    {
        public double Angle { get; private set; }

        public double[] Sectors { get; private set; }

        List<(double x, double)> Points = new List<(double x, double)>();

        public KochFractal(int pointCount, double angle, double a, double b, double c, 
                           double x1, double y1, double x2, double y2)
        {
            Angle = angle;
            Sectors = new double[3] { a, b, c };
            Points = new List<(double x, double)>() { (x1, y2), (x2, y2) };

            for(int i = 0; i < pointCount - 1; i++)
            {
                for (int j = 0; j < Points.Count - 1; j++)
                {
                    (double x, double y) P1 = Points[j];
                    (double x, double y) P2 = Points[j + 1];

                    double dxl = Math.Abs(P2.x - P1.x);
                    double dyl = Math.Abs(P2.y - P1.y);

                    (double x, double y) A = (P1.x + Sectors[0] * dxl, P1.y + Sectors[0] * dyl);
                    (double x, double y) B = (P2.x - Sectors[2] * dxl, P2.y - Sectors[2] * dyl);

                    double L = Math.Sqrt(Math.Pow(B.x - A.x, 2.0) + Math.Pow(B.y - A.y, 2.0));
                    (double x, double y) M = ((A.x + B.x) / 2, (A.y + B.y) / 2);
                    double tan = Math.Tan(Angle);

                    double sqrt = Math.Sqrt(L * L * L / (4 * tan));
                    double bot = L * L / 2;
                    double Y = (2 * A.x * A.x * M.y
                                - 4 * A.y * M.y * M.y
                                + 2 * A.y * A.y * M.y
                                + 2 * M.x * M.x * M.y
                                + 2 * M.y * M.y * M.y
                                - 4 * A.x * M.x * M.y
                                + sqrt * (A.x - M.x)) / bot;

                    double X = M.x - (M.y * M.y + Y * A.y - Y * M.y - A.y * M.y) / (A.x - M.x);

                    Points.Insert(++j, A);
                    Points.Insert(++j, (X, Y));
                    Points.Insert(++j, B);
                }
            }

            PointCount = Points.Count;
        }

        public override (double x, double y) GetNextPoint() =>
            Points[CurrentPointNum++];
    }
}
