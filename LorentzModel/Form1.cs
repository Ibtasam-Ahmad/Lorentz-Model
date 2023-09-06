using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LorentzModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eulerMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 1400;
            double[]x = new double[size];
            double[]y = new double[size];
            double[]z = new double[size];
            double[]t = new double [size];
            double r = 5.0, sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;
            x[0] = 1;
            y[0] = 1;
            z[0] = 1;
            for (int i = 0; i < size-1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int i = 0; i < size-1; i++)
            {
                gg.FillEllipse(sb, 300 + (float)t[i]*15, 200 - (float)z[i]*15, 3, 3);
            }


        }

        private void r10ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int size = 1400;
            double[] x = new double[size];
            double[] y = new double[size];
            double[] z = new double[size];
            double[] t = new double[size];
            double r = 10.0, sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;
            x[0] = 1;
            y[0] = 1;
            z[0] = 1;
            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 70 + (float)t[i] * 15, 250 - (float)z[i] * 15, 3, 3);
            }
        }

        private void r15ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int size = 1400;
            double[] x = new double[size];
            double[] y = new double[size];
            double[] z = new double[size];
            double[] t = new double[size];
            double r = 15.0, sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;
            x[0] = 1;
            y[0] = 1;
            z[0] = 1;
            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 600+ (float)t[i] * 15, 300 - (float)z[i] * 15, 3, 3);
            }
        }

        private void betweenXAndZToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int size = 1400;
            double[] x = new double[size];
            double[] y = new double[size];
            double[] z = new double[size];
            double[] t = new double[size];
            double r = 5.0, sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;
            x[0] = 1;
            y[0] = 1;
            z[0] = 1;
            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 100 + (float)x[i] * 15, 400 - (float)z[i] * 15, 3, 3);
            }
        }

        private void betweenYAndZToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int size = 1400;
            double[] x = new double[size];
            double[] y = new double[size];
            double[] z = new double[size];
            double[] t = new double[size];
            double r = 5.0, sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;
            x[0] = 1;
            y[0] = 1;
            z[0] = 1;
            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 300 + (float)y[i] * 15, 400 - (float)z[i] * 15, 3, 3);
            }
        }

        private void r10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int size = 1400;
            double[] x = new double[size];
            double[] y = new double[size];
            double[] z = new double[size];
            double[] t = new double[size];
            double r = 10.0, sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;
            x[0] = 1;
            y[0] = 1;
            z[0] = 1;
            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 500 + (float)x[i] * 15, 400- (float)z[i] * 15, 3, 3);
            }
        }

        private void r15ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int size = 2000;
            double[] x = new double[size];
            double[] y = new double[size];
            double[] z = new double[size];
            double[] t = new double[size];
            double r = 15.0, sigma = 10.0, b = 8.0 / 3.0, dt = 0.01;
            x[0] = 1;
            y[0] = 1;
            z[0] = 1;
            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (sigma * (y[i] - x[i])) * dt;
                y[i + 1] = y[i] - (x[i] * z[i] - r * x[i] + y[i]) * dt;
                z[i + 1] = z[i] + (x[i] * y[i] - b * z[i]) * dt;
                t[i + 1] = t[i] + dt;
            }
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            for (int i = 0; i < size - 1; i++)
            {
                gg.FillEllipse(sb, 600 + (float)y[i] * 15, 800- (float)z[i] * 15, 3, 3);
            }
        }
    }
}
