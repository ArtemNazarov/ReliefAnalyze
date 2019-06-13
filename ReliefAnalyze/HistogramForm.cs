using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReliefAnalyze
{
    public partial class HistogramForm : Form
    {
        public Image MyImage { get; set; }

        public HistogramForm()
        {
            InitializeComponent();
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            this.histChart.Series.Clear();
            this.histChart.Titles.Add("Гистограмма");
            Series redSeries = this.histChart.Series.Add("Red");
            redSeries.Color = Color.Red;
            Series greenSeries = this.histChart.Series.Add("Green");
            greenSeries.Color = Color.Green;
            Series blueSeries = this.histChart.Series.Add("Blue");
            blueSeries.Color = Color.Blue;
            redSeries.ChartType = SeriesChartType.Spline;
            greenSeries.ChartType = SeriesChartType.Spline;
            blueSeries.ChartType = SeriesChartType.Spline;
            var red = new int[256];
            var green = new int[256];
            var blue = new int[256];
            int Width = MyImage.Width;
            int Height = MyImage.Height;
            var imageBitmap = new Bitmap(MyImage);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (!(i == 0 || j == 0 || i == Width - 1 || j == Height - 1))
                    {
                        Color medium = imageBitmap.GetPixel(i - 1, j - 1);
                        int R = medium.R;
                        int G = medium.G;
                        int B = medium.B;
                        red[R] += 1;
                        green[G] += 1;
                        blue[B] += 1;
                    }
                }
            }
            for (int i = 0; i < 256; i++)
            {
                redSeries.Points.AddXY(i, red[i]);
                greenSeries.Points.AddXY(i, green[i]);
                blueSeries.Points.AddXY(i, blue[i]);
            }
        }
    }
}
