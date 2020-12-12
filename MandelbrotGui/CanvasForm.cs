using Mandelbrot.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MandelbrotGui
{
    public partial class CanvasForm : Form
    {
        public CanvasForm()
        {
            InitializeComponent();
        }

        private void kochCurveTab_Paint(object sender, PaintEventArgs e)
        {
            var start = new Point(10, 800);
            var drawFunc = getDrawFunc(e);
            Koch.Draw((int)numKochCurve.Value, start, 1900, drawFunc);
        }

        private void kochSnowflakeTab_Paint(object sender, PaintEventArgs e)
        {
            var start = new Point(150, 650);
            var drawFunc = getDrawFunc(e);
            Koch.DrawSnowflake((int)numKochSnowflake.Value, start, 600, drawFunc);
        }

        private void kochHexagonTab_Paint(object sender, PaintEventArgs e)
        {
            var start = new Point(150, 500);
            var drawFunc = getDrawFunc(e);
            Koch.DrawHexagon((int)numKochHexagon.Value, start, 400, drawFunc);
        }

        private void kochSquareTab_Paint(object sender, PaintEventArgs e)
        {
            var start = new Point(200, 800);
            var drawFunc = getDrawFunc(e);
            Koch.DrawSquare((int)numKochSquare.Value, start, 600, drawFunc);
        }

        private static Action<Point, Point> getDrawFunc(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            Action<Point, Point> drawFunc = (p1, p2) => e.Graphics.DrawLine(pen, p1, p2);
            return drawFunc;
        }

        private void numKochCurve_ValueChanged(object sender, EventArgs e)
        {
            kochCurveTab.Refresh();
        }

        private void numKochSnowflake_ValueChanged(object sender, EventArgs e)
        {
            kochSnowflakeTab.Refresh();
        }


        private void numKochHexagon_ValueChanged(object sender, EventArgs e)
        {
            kochHexagonTab.Refresh();
        }

        private void numKochSquare_ValueChanged_1(object sender, EventArgs e)
        {
            kochSquareTab.Refresh();
        }
    }
}
