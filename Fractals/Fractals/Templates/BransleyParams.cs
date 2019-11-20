namespace Fractals.Templates
{
    public class BransleyParams
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double D { get; private set; }
        public double E { get; private set; }
        public double F { get; private set; }

        public double P { get; set; }

        public BransleyParams(double a, double b, double c, double d, double e, double f, double p)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
            F = f;
            P = p;
        }
    }
}
