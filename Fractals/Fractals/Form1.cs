using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Fractals.Templates;

namespace Fractals
{
    public partial class FractalsForm : Form
    {
        private Fractal LastFractal { get; set; }

        private const int MIN_LEN = 0;
        private const int MAX_LEN = 9999;

        private const int INPUT_MARGIN = 10;

        private List<(Label XLabel, NumericUpDown XInput, Label YLabel, NumericUpDown YInput)> lengthUI =
            new List<(Label XLabel, NumericUpDown XInput, Label YLabel, NumericUpDown YInput)>();

        public FractalsForm()
        {
            InitializeComponent();
        }

        private void UpdateCoeffsUI(int count)
        {
            int toDelete = lengthUI.Count - count;
            for (int i = 0; i < toDelete; i++)
            {
                var ui = lengthUI.Last();

                SettingsPanel.Controls.Remove(ui.XLabel);
                SettingsPanel.Controls.Remove(ui.XInput);
                SettingsPanel.Controls.Remove(ui.YLabel);
                SettingsPanel.Controls.Remove(ui.YInput);

                lengthUI.RemoveAt(lengthUI.Count - 1);
            }

            Control last = lengthUI.Count == 0 ? SidesCount : lengthUI.Last().YInput;
            for (int i = lengthUI.Count; i < count; i++)
            {
                int top = last.Location.Y + last.Height + INPUT_MARGIN;
                Label XLabel = new Label()
                {
                    AutoSize = true,
                    Text = $"X {i + 1}: ",
                    Location = new Point(SideCountLabel.Location.X, top)
                };

                NumericUpDown XInput = new NumericUpDown()
                {
                    Minimum = MIN_LEN,
                    Maximum = MAX_LEN,
                    Size = SidesCount.Size,
                    Location = new Point(SidesCount.Location.X, top)
                };

                Label YLabel = new Label()
                {
                    AutoSize = true,
                    Text = $"Y {i + 1}: ",
                    Location = new Point(SideCountLabel.Location.X, top + XInput.Height + INPUT_MARGIN)
                };

                NumericUpDown YInput = new NumericUpDown()
                {
                    Minimum = MIN_LEN,
                    Maximum = MAX_LEN,
                    Size = SidesCount.Size,
                    Location = new Point(SidesCount.Location.X, top + XInput.Height + INPUT_MARGIN)
                };

                SettingsPanel.Controls.Add(XLabel);
                SettingsPanel.Controls.Add(XInput);
                SettingsPanel.Controls.Add(YLabel);
                SettingsPanel.Controls.Add(YInput);

                lengthUI.Add((XLabel, XInput, YLabel, YInput));
                last = YInput;
            }

            lengthUI[0].XInput.ValueChanged += (ctx, args) => 
            {
                UpdateLastFractal(LastFractal);
                Draw(LastFractal);
            };

            lengthUI[0].YInput.ValueChanged += (ctx, args) =>
            {
                UpdateLastFractal(LastFractal);
                Draw(LastFractal);
            };
        }

        private void FractalsForm_Load(object sender, EventArgs e) =>
            UpdateCoeffsUI(Convert.ToInt32(SidesCount.Value));

        private void SidesCount_ValueChanged(object sender, EventArgs e) =>
            UpdateCoeffsUI(Convert.ToInt32(SidesCount.Value));

        private void Scale_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal);
        }

        private void PointCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal);
        }

        private void DX_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal);
        }

        private void DY_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            SimpleFractal fractal = new SimpleFractal(lengthUI.Select(UI => (Convert.ToDouble(UI.XInput.Value), 
                                                                             Convert.ToDouble(UI.YInput.Value))).ToArray(),
                                                      Convert.ToDouble(FractalCoeff.Value), Convert.ToInt32(PointCount.Value));
            LastFractal = fractal;
            Draw(fractal);
        }

        private void BransleyFractal_Click(object sender, EventArgs e)
        {
            BransleyParamsForm bransleyParams = new BransleyParamsForm(Convert.ToInt32(PointCount.Value),
                                                                       Convert.ToDouble(lengthUI[0].XInput.Value),
                                                                       Convert.ToDouble(lengthUI[0].YInput.Value));
            bransleyParams.ShowDialog();

            LastFractal = bransleyParams.Result;
            Draw(LastFractal);
        }

        private void UpdateLastFractal(Fractal fractal)
        {
            fractal.Reset();
            fractal.PointCount = Convert.ToInt32(PointCount.Value);
        }

        private void Draw(Fractal fractal)
        {
            if (fractal == null)
                return;

            float dx = Convert.ToSingle(DX.Value);
            float dy = Convert.ToSingle(DY.Value);
            float scale = Convert.ToSingle(Scale.Value);
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);

            while (fractal.HasNext())
            {
                (double x, double y) = fractal.GetNextPoint();
                (int xr, int yr) = ((int)(x * scale + dx), (int)(y * scale + dy));

                if (xr < 0 || xr >= bmp.Width || yr < 0 || yr >= bmp.Height)
                    continue;

                bmp.SetPixel(xr, yr, Color.Green);
            }

            Canvas.Image = bmp;
        }
    }
}
