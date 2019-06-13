using System;
using System.Numerics;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using OpenCvSharp;

namespace ReliefAnalyze
{
    public partial class MainForm : Form
    {
        private Image MyImage { get; set; }
        private string MyFileName { get; set; }

        private System.Drawing.Point coordinatesAnalyze { get; set; }
        private int RectSide { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyFileName = openFileDialog1.FileName;
                MyImage = Image.FromFile(openFileDialog1.FileName);
                mainPictureBox.Image = MyImage;
            }
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            if (mainPictureBox.Image != null)
            {
                Analyze();
            }
            else
            {
                MessageBox.Show("Вы не открыли изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Analyze()
        {
            var imageBitmap = new Bitmap(MyImage);
            var colorDictionary = new Dictionary<string, ColorInfo>();
            var Width = MyImage.Width;
            var Height = MyImage.Height;
            var xstart = coordinatesAnalyze.X - RectSide / 2;
            var ystart = coordinatesAnalyze.Y - RectSide / 2;
            var xend = coordinatesAnalyze.X + RectSide / 2;
            var yend = coordinatesAnalyze.Y + RectSide / 2;
            var xmin = xstart > 0 ? xstart : 0;
            var ymin = ystart > 0 ? ystart : 0;
            var xmax = xend < Width ? xend : Width;
            var ymax = yend < Height ? yend : Height;
            if (coordinatesAnalyze != null)
            {

                for (int i = xmin; i < xmax; i++)
                {
                    for (int j = ymin; j < ymax; j++)
                    {
                        if (!(i == 0 || j == 0 || i == Width - 1 || j == Height - 1))
                        {
                            var medium = imageBitmap.GetPixel(i - 1, j - 1);
                            var colorValue = medium.ToArgb().ToString();
                            var near = ColorHelper.GetNearestColorName(ColorHelper.GetSystemDrawingColorFromHexString("#" + medium.Name.Substring(2)));

                            if (!colorDictionary.ContainsKey(colorValue))
                            {
                                colorDictionary.Add(colorValue, new ColorInfo { Color = medium, ColorCount = 1, NearColor = near });
                            }
                            else
                            {
                                colorDictionary[colorValue].ColorCount += 1;
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не открыли изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var allColors = colorDictionary.OrderByDescending(elem => elem.Value.ColorCount).ToList();
            var mainColors = allColors.Take(20).ToList();
            

            using (StreamWriter writer = new StreamWriter(@"E:\dev\C#\ReliefAnalyze\imageinfo.txt"))
            {
                foreach (KeyValuePair<string, ColorInfo> keyValue in colorDictionary.OrderByDescending(elem => elem.Value.ColorCount))
                {
                    Color col = Color.FromArgb(Convert.ToInt32(keyValue.Key));
                    var near = ColorHelper.GetNearestColorName(ColorHelper.GetSystemDrawingColorFromHexString("#" + col.Name.Substring(2)));

                    writer.WriteLine($"{keyValue.Key} : {keyValue.Value.ColorCount} , near color = {keyValue.Value.NearColor}");
                    writer.WriteLine(near);
                }
            }

            MessageBox.Show("Анализ проведён!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            AnalyzeForm analyzeForm = new AnalyzeForm();
            analyzeForm.SetDataGridView(mainColors);
            
            analyzeForm.Show();
        }

        private string AnalyzeColors(List<KeyValuePair<string,ColorInfo>> allColors)
        {
            StringBuilder analyze = new StringBuilder("");
            var midBlue = allColors.Take(30).Where(clr => clr.Value.NearColor == Color.MidnightBlue.ToString());
            
            if (midBlue != null)
            {
                analyze.Append("Есть река");
            }
            //switch (mainColors.First().Value.NearColor)
            //{
                
            //}
            return analyze.ToString();
        }

        private void HistogramMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mainPictureBox.Image != null)
            {
                HistogramForm form = new HistogramForm();
                form.MyImage = new Bitmap(this.mainPictureBox.Image);
                form.Show();
            }
            else
            {
                MessageBox.Show("Вы не открыли изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {
            //MouseEventArgs me = (MouseEventArgs)e;
            //Point coordinates = me.Location;
            //var imageBitmap = new Bitmap(MyImage);
            //int rectSide = imageBitmap.Height > imageBitmap.Width ? Convert.ToInt32(imageBitmap.Width * 0.1) : Convert.ToInt32((int)imageBitmap.Height * 0.1);
            //var diag = Math.Sqrt(2 * rectSide);
            //Graphics g = Graphics.FromImage(imageBitmap);
            //g.DrawRectangle(new Pen(Color.Gray, 3), coordinates.X, coordinates.Y, coordinates.X + rectSide / 2 , coordinates.Y + rectSide / 2);
            //g.Save();
            //mainPictureBox.Image = imageBitmap;
        }

        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.mainPictureBox.Image != null)
            {
                var coordinates = e.Location;
                coordinatesAnalyze = coordinates;
                var imageBitmap = new Bitmap(MyImage);
                var rectSide = imageBitmap.Height > imageBitmap.Width ? Convert.ToInt32(imageBitmap.Width * 0.1) : Convert.ToInt32((int)imageBitmap.Height * 0.1);
                var gr = Graphics.FromImage(imageBitmap);
                var rect = new Rectangle(e.Location.X - rectSide / 2, e.Location.Y - rectSide / 2, rectSide, rectSide);
                gr.DrawRectangle(new Pen(Color.Gray, 3), rect);
                gr.Save();
                mainPictureBox.Image = imageBitmap;
                RectSide = rectSide;
            }
            else
            {
                MessageBox.Show("Вы не открыли изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MyImage = Image.FromFile(Environment.CurrentDirectory + "\\..\\..\\..\\map (4).png");
            mainPictureBox.Image = MyImage;
        }

        private void ControursButton_Click(object sender, EventArgs e)
        {

        }
    }
}
