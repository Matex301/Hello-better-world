using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hello_better_world_
{
    public partial class Form1 : Form
    {
        Bitmap Map = new Bitmap(842, 560);
        Bitmap Metric;
        private Color[] MetricColor;
        private Graphics GTX;
        bool Started = false;
        int Type = 0;
        int Seed = 123456;
        int Octaves = 12;
        int x = 0;
        int y = 0;
        float zoom = 0.001f;
        float frequence = 6;
        int jump = 100;
        bool MetricRender = true;

        double White = 0.5;
        double Grey = 0.4;
        double LightGrey = 0.3;
        double Green = 0.2;
        double LightGreen = 0.005;
        double Yellow = 0;
        double Blue = -0.35;
        double DarkBlue = -1;

        public Form1()
        {
            InitializeComponent();
            GTX = Graphics.FromImage(Map);
            NoiseType.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             Metric = new Bitmap(this.GetType().Assembly.GetManifestResourceStream("Hello_better_world_.EarthLookupTable.png"));
             for (int i = 0; i < Metric.Width; i++)
                 MetricColor[i] = Metric.GetPixel(i, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generate();
            Started = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Started)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        x = x + jump;
                        break;
                    case Keys.W:
                        x = x - jump;
                        break;
                    case Keys.A:
                        y = y - jump;
                        break;
                    case Keys.D:
                        y = y + jump;
                        break;
                    default:
                        return;
                }

                x_cords.Text = "X: " + x;
                y_cords.Text = "Y: " + y;

                Generate();
            }
        }

        private void Generate()
        {
            FastNoise World = new FastNoise();
            World.SetFractalOctaves(Octaves);
            World.SetFrequency(frequence);
            World.SetSeed(Seed);

            LoadingBar.Value = 1;
            LoadingBar.Visible = true;
            LoadingBar.Step = 1;
            LoadingBar.Minimum = 0;
            LoadingBar.Maximum = 842 * 560;

            World.SetCellularReturnType(FastNoise.CellularReturnType.CellValue);

            double value = 0;
            for (int a = 0; a < 842; a++)
            {
                for (int b = 0; b < 560; b++)
                {

                    if (Type == 0) { value = World.GetPerlinFractal((x + b) * zoom, (y + a) * zoom, 10); }
                    else if (Type == 1) { value = World.GetPerlin((x + b) * zoom, (y + a) * zoom, 10); }

                    else if (Type == 2) { value = World.GetSimplexFractal((x + b) * zoom, (y + a) * zoom, 10); }
                    else if (Type == 3) { value = World.GetSimplex((x + b) * zoom, (y + a) * zoom, 10); }

                    else if(Type == 4) { value = World.GetCubicFractal((x + b) * zoom, (y + a) * zoom, 10); }
                    else if (Type == 5) { value = World.GetCubic((x + b) * zoom, (y + a) * zoom, 10); }

                    else if(Type == 6) { value = World.GetCubicFractal((x + b) * zoom, (y + a) * zoom, 10); }
                    else if (Type == 7) { value = World.GetCellular((x + b) * zoom, (y + a) * zoom, 10); }

                    else if (Type == 8) { value = World.GetWhiteNoise((x + b) * zoom, (y + a) * zoom, 10); }

                    if (!MetricRender)
                    {
                        if (value > White)
                        {
                            GTX.FillRectangle(Brushes.White, a, b, 1, 1);
                        }
                        else if (value > Grey)
                        {
                            GTX.FillRectangle(Brushes.Gray, a, b, 1, 1);
                        }
                        else if (value > LightGrey)
                        {
                            GTX.FillRectangle(Brushes.LightGray, a, b, 1, 1);
                        }
                        else if (value > Green)
                        {
                            GTX.FillRectangle(Brushes.Green, a, b, 1, 1);
                        }
                        else if (value > LightGreen)
                        {
                            GTX.FillRectangle(Brushes.LightGreen, a, b, 1, 1);
                        }
                        else if (value > Yellow)
                        {
                            GTX.FillRectangle(Brushes.Yellow, a, b, 1, 1);
                        }
                        else if (value > Blue)
                        {
                            GTX.FillRectangle(Brushes.Blue, a, b, 1, 1);
                        }
                        else if (value > DarkBlue)
                        {
                            GTX.FillRectangle(Brushes.DarkBlue, a, b, 1, 1);
                        }
                        else
                        {
                            GTX.FillRectangle(Brushes.Black, a, b, 1, 1);
                        }
                    }
                    else
                    {
                        if (value < -1) value = -1;
                        else if (value > 1) value = 1.0;
                        if (value < 0) value += 1;
                        value /= 2;
                        //0 <= value <= 1
                        int index = (int)(value * MetricColor.Length);
                        Map.SetPixel(a, b,MetricColor[index]);

                    }

                    LoadingBar.PerformStep();
                }
                pictureBox1.Image = Map;
            }
            LoadingBar.Visible = false;
            LoadingBar.Value = 842 * 560;
            pictureBox1.Image = Map;
        }

        private void NumericSeed_ValueChanged(object sender, EventArgs e)
        {
            Seed = Convert.ToInt32(NumericSeed.Value);
        }

        private void NumericOctaves_ValueChanged(object sender, EventArgs e)
        {
            Octaves = Convert.ToInt32(NumericOctaves.Value);
        }

        private void NumericZoom_ValueChanged(object sender, EventArgs e)
        {
            zoom = (float)NumericZoom.Value;
        }

        private void NumericJump_ValueChanged(object sender, EventArgs e)
        {
            jump = Convert.ToInt32(NumericJump.Value);
        }

        private void NoiseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type = NoiseType.SelectedIndex;
        }

        private void NumericLight_ValueChanged(object sender, EventArgs e)
        {

            NumericLight.Maximum = 1;
            White = Convert.ToDouble(NumericLight.Value);

            NumericGrey.Maximum = NumericLight.Value;
            Grey = Convert.ToDouble(NumericGrey.Value);

            NumericLightGrey.Maximum = NumericGrey.Value;
            LightGrey = Convert.ToDouble(NumericLightGrey.Value);

            NumericGreen.Maximum = NumericLightGrey.Value;
            Green = Convert.ToDouble(NumericGreen.Value);

            NumericLightGreen.Maximum = NumericGreen.Value;
            LightGreen = Convert.ToDouble(NumericLightGreen.Value);

            NumericYellow.Maximum = NumericLightGreen.Value;
            Yellow = Convert.ToDouble(NumericYellow.Value);

            NumericBlue.Maximum = NumericYellow.Value;
            Blue = Convert.ToDouble(NumericBlue.Value);

            NumericDarkBlue.Maximum = NumericBlue.Value;
            DarkBlue = Convert.ToDouble(NumericDarkBlue.Value);

            NumericDarkBlue.Minimum = -1;
        }

        private void NumericFrequence_ValueChanged(object sender, EventArgs e)
        {
            frequence = (float)NumericFrequence.Value;
        }
    }
}
