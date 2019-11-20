using System;
using System.Linq;
using System.Windows.Forms;

using Fractals.Templates;

namespace Fractals
{
    public partial class BransleyParamsForm : Form
    {
        public BransleyFractal Result { get; private set; }

        public BransleyParamsForm(int pointCount)
        {
            InitializeComponent();
            Result = new BransleyFractal(pointCount, 0, 0);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            BransleyParams bransleyParams = new BransleyParams(Convert.ToDouble(A.Value), Convert.ToDouble(B.Value),
                                                               Convert.ToDouble(C.Value), Convert.ToDouble(D.Value),
                                                               Convert.ToDouble(E.Value), Convert.ToDouble(F.Value),
                                                               Convert.ToDouble(Probability.Value));

            Result.Parameters.Add(bransleyParams);

            if (MessageBox.Show("Do you want to add one more parameter?", "Bransley fractal settings",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                bransleyParams.P = Convert.ToDouble(Probability.Maximum);
                this.Close();
            }

            Probability.Maximum = 1 - (decimal)Result.Parameters.Sum(P => P.P);
        }
    }
}
