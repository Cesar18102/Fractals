using System.Collections.Generic;
using System.Linq;

namespace Fractals.Templates
{
    public class BransleyFractal : Fractal
    {
        public List<BransleyParams> Parameters { get; private set; }

        public BransleyFractal(int pointCount, double x, double y)
        {
            Parameters = new List<BransleyParams>();
            PointCount = pointCount;

            X = x;
            Y = y;
        }

        public override (double x, double y) GetNextPoint()
        {
            CurrentPointNum++;

            if (Parameters.Count == 0)
                return (0, 0);

            int i = 0;
            double sum = 0;
            double rand = R.NextDouble();  
            
            for(; i < Parameters.Count; i++)
            {
                sum += Parameters[i].P;
                if (rand <= sum)
                    break;
            }

            BransleyParams P = Parameters[i];

            X = P.A * X + P.B * Y + P.E;
            Y = P.C * X + P.D * Y + P.F;

            return (X, Y);
        }
    }
}
