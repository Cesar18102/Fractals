using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Fractals.Templates;
using System.Drawing.Drawing2D;

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
                Draw(LastFractal, LineChecker.Checked);
            };

            lengthUI[0].YInput.ValueChanged += (ctx, args) =>
            {
                UpdateLastFractal(LastFractal);
                Draw(LastFractal, LineChecker.Checked);
            };
        }

        private void FractalsForm_Load(object sender, EventArgs e) =>
            UpdateCoeffsUI(Convert.ToInt32(SidesCount.Value));

        private void SidesCount_ValueChanged(object sender, EventArgs e) =>
            UpdateCoeffsUI(Convert.ToInt32(SidesCount.Value));

        private void Scale_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal, LineChecker.Checked);
        }

        private void PointCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal, LineChecker.Checked);
        }

        private void DX_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal, LineChecker.Checked);
        }

        private void DY_ValueChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal, LineChecker.Checked);
        }

        private void LineChecker_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLastFractal(LastFractal);
            Draw(LastFractal, LineChecker.Checked);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            SimpleFractal fractal = new SimpleFractal(lengthUI.Select(UI => (Convert.ToDouble(UI.XInput.Value), 
                                                                             Convert.ToDouble(UI.YInput.Value))).ToArray(),
                                                      Convert.ToDouble(FractalCoeff.Value), Convert.ToInt32(PointCount.Value));
            LastFractal = fractal;
            Draw(fractal, LineChecker.Checked);
        }

        private void BransleyFractal_Click(object sender, EventArgs e)
        {
            BransleyParamsForm bransleyParams = new BransleyParamsForm(Convert.ToInt32(PointCount.Value));
            bransleyParams.ShowDialog();

            LastFractal = bransleyParams.Result;
            Draw(LastFractal, LineChecker.Checked);
        }

        private void UpdateLastFractal(Fractal fractal)
        {
            if (fractal == null)
                return;

            fractal.Reset();
            fractal.PointCount = Convert.ToInt32(PointCount.Value);
        }

        private void Draw(Fractal fractal, bool line)
        {
            if (fractal == null)
                return;

            Pen pen = new Pen(Color.Green, 1.0f);
            float dx = Convert.ToSingle(DX.Value);
            float dy = Convert.ToSingle(DY.Value);
            float scale = Convert.ToSingle(Scale.Value);
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
            (int x, int y) prev = ((int)(fractal.X * scale + dx), (int)(fractal.Y * scale + dy));

            using (Graphics G = Graphics.FromImage(bmp))
            {
                int i = -1;
                PathData path = new PathData();
                path.Points = new PointF[fractal.PointCount];
                path.Types = new byte[fractal.PointCount];
                path.Types[0] = (byte)PathPointType.Start;

                while (fractal.HasNext())
                {
                    (double x, double y) p = fractal.GetNextPoint();
                    (int xr, int yr) = ((int)(p.x * scale + dx), (int)(p.y * scale + dy));

                    if (xr < 0 || xr >= bmp.Width || yr < 0 || yr >= bmp.Height)
                        continue;

                    prev = (xr, yr);

                    if (line)
                    {
                        path.Points[++i] = new PointF(xr, yr);
                        path.Types[i] = (byte)PathPointType.Line;
                    }
                    else
                        bmp.SetPixel(xr, yr, Color.Green);
                }

                if (line && i > 0)
                {
                    PointF[] pts = new PointF[i];
                    byte[] types = new byte[i];

                    Array.Copy(path.Points, pts, i);
                    Array.Copy(path.Types, types, i);

                    G.DrawPath(pen, new GraphicsPath(pts, types));
                    G.Save();
                    bmp.Save(Environment.CurrentDirectory + "/koch.png");
                }
            }

            Canvas.Image = bmp;
        }

        private void KochFractal_Click(object sender, EventArgs e)
        {
            LastFractal = new KochFractal(Convert.ToInt32(PointCount.Value), Math.PI / 4, 0.0, 1, 0.0, 0, 200, 300, 200);
            Draw(LastFractal, true);
        }
    }
}
