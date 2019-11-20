using System;

namespace Fractals.Templates
{
    public abstract class Fractal
    {
        protected static readonly Random R = new Random();

        public int PointCount { get; set; }
        protected int CurrentPointNum { get; set; }

        public double X { get; set; }
        public double Y { get; set; }

        public abstract (double x, double y) GetNextPoint();
        public bool HasNext() => CurrentPointNum < PointCount;
        public void Reset() => CurrentPointNum = 0;
    }
}
