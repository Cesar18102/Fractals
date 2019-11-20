namespace Fractals.Templates
{
    public class SimpleFractal : Fractal
    {
        private (double X, double Y)[] Vertices { get; set; }
        private double Coeff { get; set; }

        public SimpleFractal((double X, double Y)[] vertices, double coeff, int pointCount)
        {
            Coeff = coeff;
            Vertices = vertices;
            PointCount = pointCount;

            X = vertices[0].X;
            Y = vertices[0].Y;
        }

        public override (double x, double y) GetNextPoint()
        {
            CurrentPointNum++;
            int vert = R.Next(0, Vertices.Length);

            X = (X + Vertices[vert].X) * Coeff;
            Y = (Y + Vertices[vert].Y) * Coeff;

            return (X, Y);
        }
    }
}
