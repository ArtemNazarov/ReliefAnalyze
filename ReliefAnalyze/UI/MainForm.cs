using System;
using System.Numerics;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using ReliefAnalyze.UI;
using Accord.Imaging;
using Image = System.Drawing.Image;
using Accord.Imaging.Filters;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ReliefAnalyze
{
    public partial class MainForm : Form
    {
        private Image MyImage { get; set; }
        private string MyFileName { get; set; }
        private System.Drawing.Point coordinatesAnalyze { get; set; }
        private int RectSide { get; set; }

        private string ProjectDir { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private Bitmap HoughTransform(Bitmap originalImage)
        {
            var imgBitmap = new Bitmap(originalImage);
            var lineTransform = new Accord.Imaging.HoughLineTransformation();
            // Convert it to binary and mark the possible lines 
            // in white so it can be processed by the transform
            var sequence = new FiltersSequence(
                Grayscale.CommonAlgorithms.BT709,
                new NiblackThreshold(),
                new Invert()
            );
            var contoursBitmap = ImageFilter.PrewittFilter(imgBitmap, true);
            // Apply the sequence of filters above:
            Bitmap binaryImage = sequence.Apply(contoursBitmap);
            lineTransform.ProcessImage(binaryImage);
            // Now, let's say we would like to retrieve the lines and use them
            // for further processing. First, the lines can be ordered by their
            // relative intensity using
            HoughLine[] lines = lineTransform.GetLinesByRelativeIntensity(1);

            // Then, let's plot them on top of the input image. Since we will
            // apply many operations to a single image, it is better to first
            // convert it to an UnmanagedImage object to avoid having to lock
            // the image into memory multiple times.

            UnmanagedImage unmanagedImage = UnmanagedImage.FromManagedImage(binaryImage);

            // Finally, plot them in order:
            foreach (HoughLine line in lines)
            {
                line.Draw(unmanagedImage, color: Color.Red);
            }

            return unmanagedImage.ToManagedImage();
        }

        private void Hough()
        {
            var houghBitmap = HoughTransform(new Bitmap(MyImage));
            ContoursForm contoursForm = new ContoursForm();
            contoursForm.Image = houghBitmap;
            contoursForm.Show();
        }

        private Bitmap CannyFilter(Bitmap originalBitmap)
        {
            var originalMat = BitmapConverter.ToMat(originalBitmap);
            var cannyMat = new Mat();
            Cv2.Canny(originalMat, cannyMat, 50, 100);
            return BitmapConverter.ToBitmap(cannyMat);
        }

        private void FragmentContours()
        {
            var imageBitmap = new Bitmap(MyImage);
            if (!coordinatesAnalyze.IsEmpty)
            {
                var contoursBitmap = FragmentBitmap(imageBitmap);

                contoursBitmap = ImageFilter.PrewittFilter(contoursBitmap, false);
                FilteredImageForm filteredImageForm = new FilteredImageForm();
                filteredImageForm.Image = contoursBitmap;
                filteredImageForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите участок карты!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Contours()
        {
            var originalBitmap = new Bitmap(MyImage);
            var contoursBitmap = ImageFilter.PrewittFilter(originalBitmap, false);
            ContoursForm contoursForm = new ContoursForm();
            contoursForm.Image = contoursBitmap;
            contoursForm.Show();
        }

        private void Analyze()
        {
            var imageBitmap = new Bitmap(MyImage);
            var colorDictionary = new Dictionary<string, ColorInfo>();
            var Width = MyImage.Width;
            var Height = MyImage.Height;
            if (!coordinatesAnalyze.IsEmpty)
            {
                var xstart = coordinatesAnalyze.X - RectSide / 2;
                var ystart = coordinatesAnalyze.Y - RectSide / 2;
                var xend = coordinatesAnalyze.X + RectSide / 2;
                var yend = coordinatesAnalyze.Y + RectSide / 2;
                var xmin = xstart > 0 ? xstart : 0;
                var ymin = ystart > 0 ? ystart : 0;
                var xmax = xend < Width ? xend : Width;
                var ymax = yend < Height ? yend : Height;


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
                MessageBox.Show("Вы не выбрали фрагмент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var allColors = colorDictionary.OrderByDescending(elem => elem.Value.ColorCount).ToList();
            var mainColors = allColors.Take(20).ToList();



            using (StreamWriter writer = new StreamWriter($@"{ProjectDir}\imageinfo.txt"))
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

        private string AnalyzeColors(List<KeyValuePair<string, ColorInfo>> allColors)
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
            ProjectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            if (File.Exists($@"{ProjectDir}\map (6).png"))
            {
                MyImage = Image.FromFile($@"{ProjectDir}\map (6).png");
                MyFileName = $@"{ProjectDir}\map (6).png";
                mainPictureBox.Image = MyImage;
            }

        }

        private void ContoursButton_Click(object sender, EventArgs e)
        {
            Contours();
        }

        private void FragmentControursButton_Click(object sender, EventArgs e)
        {
            FragmentContours();

        }

        private void HoughButton_Click(object sender, EventArgs e)
        {
            Hough();
        }

        private void Opencvbutton_Click(object sender, EventArgs e)
        {
            FindContours();
        }

        private void FindContours()
        {
            var originalBitmap = new Bitmap(MyImage);
            //var houghBitmap = HoughTransform(originalBitmap);
            //var invertedHoughBitmap = InvertImage(houghBitmap);
            var originalMat = FindContoursAndDraw(originalBitmap);
            var contoursBitmap = BitmapConverter.ToBitmap(originalMat);
            ContoursForm contoursForm = new ContoursForm();
            contoursForm.Image = contoursBitmap;
            contoursForm.Show();
        }

        private Bitmap FragmentBitmap(Bitmap imageBitmap)
        {
            var fragmentBitmap = new Bitmap(RectSide, RectSide);
            var xstart = coordinatesAnalyze.X - RectSide / 2;
            var ystart = coordinatesAnalyze.Y - RectSide / 2;
            var xend = coordinatesAnalyze.X + RectSide / 2;
            var yend = coordinatesAnalyze.Y + RectSide / 2;
            var xmin = xstart > 0 ? xstart : 0;
            var ymin = ystart > 0 ? ystart : 0;
            var xmax = xend < Width ? xend : Width;
            var ymax = yend < Height ? yend : Height;
            var newWidth = xmax - xmin;
            var newHeight = ymax - ymin;
            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    if (!(i == 0 || j == 0 || i == newWidth - 1 || j == newHeight - 1))
                    {
                        var medium = imageBitmap.GetPixel(i + xmin - 1, j + ymin - 1);
                        fragmentBitmap.SetPixel(i, j, medium);
                    }
                }
            }
            return fragmentBitmap;
        }

        private Bitmap InvertImage(Bitmap originalMap)
        {
            var invertedMap = new Bitmap(originalMap);
            for (int y = 0; (y <= (originalMap.Height - 1)); y++)
            {
                for (int x = 0; (x <= (originalMap.Width - 1)); x++)
                {
                    Color inv = originalMap.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    invertedMap.SetPixel(x, y, inv);
                }
            }
            return invertedMap;
        }

        private Bitmap FindColor(Bitmap originalMap, string nearColor)
        {
            var coloredMap = new Bitmap(originalMap);
            var colorDictionary = new Dictionary<string, ColorInfo>();
            var width = coloredMap.Width;
            var height = coloredMap.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < coloredMap.Height; j++)
                {
                    if (!(i == 0 || j == 0 || i == width - 1 || j == height - 1))
                    {
                        var medium = originalMap.GetPixel(i - 1, j - 1);
                        if (medium.ToArgb() != 0)
                        {
                            var colorValue = medium.ToArgb().ToString();

                            var near = ColorHelper.GetNearestColorName(ColorHelper.GetSystemDrawingColorFromHexString("#" + medium.Name.Substring(2)));
                            if (near != nearColor)
                            {
                                coloredMap.SetPixel(i - 1, j - 1, Color.Black);

                            }
                        }
                    }
                }
            }
            return coloredMap;
        }

        private Mat FindContoursAndDraw(Bitmap originalMap, int minArea = 500, int maxArea = 10000)
        {
            //var houghBitmap = HoughTransform(originalMap);
            //var invertedHoughBitmap = InvertImage(houghBitmap);
            Mat originalMat = BitmapConverter.ToMat(originalMap);
            //Mat invertedHoughMat = BitmapConverter.ToMat(invertedHoughBitmap);
            Mat blackWhiteMat = new Mat();
            Mat edgesMat = new Mat();

            Cv2.CvtColor(originalMat, blackWhiteMat, ColorConversionCodes.BGRA2GRAY);
            Cv2.Canny(blackWhiteMat, edgesMat, 50, 100);
            //Bitmap edgesMap = BitmapConverter.ToBitmap(edgesMat);
            //edgesMap = ImageFilter.SobelFilter(edgesMap, true);
            //edgesMat = BitmapConverter.ToMat(edgesMap);

            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchyIndexes;
            Cv2.FindContours(
                edgesMat,
                out contours,
                out hierarchyIndexes,
                mode: RetrievalModes.CComp,
                method: ContourApproximationModes.ApproxSimple);
            var markers = new Mat(edgesMat.Size(), MatType.CV_8U, s: Scalar.All(0));
            var componentCount = 0;
            var contourIndex = 0;
            while ((contourIndex >= 0))
            {
                var contour = contours[contourIndex];
                var boundingRect = Cv2.BoundingRect(contour);
                var boundingRectArea = boundingRect.Width * boundingRect.Height;
                var ca = Cv2.ContourArea(contour);
                var cal = Cv2.ArcLength(contour, closed: true);
                if (boundingRectArea > minArea)
                {
                    //Cv2.Rectangle(originalMat,
                    //new OpenCvSharp.Point(boundingRect.X, boundingRect.Y),
                    //new OpenCvSharp.Point(boundingRect.Right, boundingRect.Bottom),
                    //Scalar.White, 2);
                    Cv2.PutText(originalMat, $"{ca} a", new OpenCvSharp.Point(boundingRect.X - 15, boundingRect.Y - 10), HersheyFonts.HersheyPlain, 1, Scalar.White, 2);
                    Cv2.PutText(originalMat, $"{cal} l", new OpenCvSharp.Point(boundingRect.X + 10, boundingRect.Y), HersheyFonts.HersheyPlain, 1, Scalar.White, 2);

                    //Cv2.PutText(originalMat, $"{ boundingRect.Width}in", new OpenCvSharp.Point(boundingRect.X - 15, boundingRect.Y - 10), HersheyFonts.HersheyPlain, 0.65, Scalar.White, 2);
                    //Cv2.PutText(originalMat, $"{ boundingRect.Height}in", new OpenCvSharp.Point(boundingRect.X + 10, boundingRect.Y), HersheyFonts.HersheyPlain, 0.65, Scalar.White, 2);

                }


                Cv2.DrawContours(
                    originalMat,
                    contours,
                    contourIndex,
                    color: Scalar.All(componentCount + 1),
                    thickness: -1,
                    lineType: LineTypes.Link8,
                    hierarchy: hierarchyIndexes,
                    maxLevel: int.MaxValue);

                componentCount++;


                contourIndex = hierarchyIndexes[contourIndex].Next;
            }
            return originalMat;
        }

        private void FragmentFindContours_Click(object sender, EventArgs e)
        {
            var imageBitmap = new Bitmap(MyImage);
            if (!coordinatesAnalyze.IsEmpty)
            {
                var fragmentBitmap = FragmentBitmap(imageBitmap);
                var contoursMat = FindContoursAndDraw(fragmentBitmap);
                var contoursBitmap = BitmapConverter.ToBitmap(contoursMat);
                FilteredImageForm filteredImageForm = new FilteredImageForm();
                filteredImageForm.Image = contoursBitmap;
                filteredImageForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите участок карты!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void DetectColors_Click(object sender, EventArgs e)
        {
            var imageBitmap = new Bitmap(MyImage);
            var contoursBitmap = new Bitmap(imageBitmap);
            if (!coordinatesAnalyze.IsEmpty)
            {
                var xstart = coordinatesAnalyze.X - RectSide / 2;
                var ystart = coordinatesAnalyze.Y - RectSide / 2;
                var xend = coordinatesAnalyze.X + RectSide / 2;
                var yend = coordinatesAnalyze.Y + RectSide / 2;
                var xmin = xstart > 0 ? xstart : 0;
                var ymin = ystart > 0 ? ystart : 0;
                var xmax = xend < Width ? xend : Width;
                var ymax = yend < Height ? yend : Height;
                var newWidth = xmax - xmin;
                var newHeight = ymax - ymin;
                for (int i = 0; i < newWidth; i++)
                {
                    for (int j = 0; j < newHeight; j++)
                    {
                        if (!(i == 0 || j == 0 || i == newWidth - 1 || j == newHeight - 1))
                        {
                            var medium = imageBitmap.GetPixel(i + xmin - 1, j + ymin - 1);
                            contoursBitmap.SetPixel(i, j, medium);
                        }
                    }
                }


                contoursBitmap = ImageFilter.PrewittFilter(contoursBitmap, false);
                var colorDictionary = new Dictionary<string, ColorInfo>();

                for (int i = 0; i < newWidth; i++)
                {
                    for (int j = 0; j < newHeight; j++)
                    {
                        if (!(i == 0 || j == 0 || i == newWidth - 1 || j == newHeight - 1))
                        {
                            var medium = contoursBitmap.GetPixel(i - 1, j - 1);
                            if (medium.ToArgb() != 0)
                            {
                                var colorValue = medium.ToArgb().ToString();

                                var near = ColorHelper.GetNearestColorName(ColorHelper.GetSystemDrawingColorFromHexString("#" + medium.Name.Substring(2)));
                                if (near != "Black")
                                {

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
                }

                using (StreamWriter writer = new StreamWriter($@"{ProjectDir}\fragmentColors.txt"))
                {
                    foreach (KeyValuePair<string, ColorInfo> keyValue in colorDictionary.OrderByDescending(elem => elem.Value.ColorCount))
                    {
                        Color col = Color.FromArgb(Convert.ToInt32(keyValue.Key));
                        var near = ColorHelper.GetNearestColorName(ColorHelper.GetSystemDrawingColorFromHexString("#" + col.Name.Substring(2)));

                        writer.WriteLine($"{keyValue.Key} : {keyValue.Value.ColorCount} , near color = {keyValue.Value.NearColor}");
                        writer.WriteLine(near);
                    }
                }

                FilteredImageForm filteredImageForm = new FilteredImageForm();
                filteredImageForm.Image = contoursBitmap;
                filteredImageForm.Show();
            }
        }

        private void FindColorbutton_Click(object sender, EventArgs e)
        {
            var imageBitmap = new Bitmap(MyImage);
            var waterBitmap = FindColor(imageBitmap, "LightSteelBlue");
            var riversBitmap = FindColor(imageBitmap, "Navy");
            var contoursBitmap = BitmapConverter.ToBitmap(FindContoursAndDraw(riversBitmap));

            ContoursForm contoursForm = new ContoursForm();
            contoursForm.Image = contoursBitmap;
            contoursForm.Show();
        }

        private void FragmentColorsButton_Click(object sender, EventArgs e)
        {

            var imageBitmap = new Bitmap(MyImage);
            if (!coordinatesAnalyze.IsEmpty)
            {
                var fragmentBitmap = FragmentBitmap(imageBitmap);
                var waterBitmap = FindColor(fragmentBitmap, "LightSteelBlue");
                var riversBitmap = FindColor(fragmentBitmap, "Navy");
                var contoursBitmap = BitmapConverter.ToBitmap(FindContoursAndDraw(riversBitmap));
                FilteredImageForm filteredImageForm = new FilteredImageForm();
                filteredImageForm.Image = contoursBitmap;
                filteredImageForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите участок карты!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChooseMainColorsButton_Click(object sender, EventArgs e)
        {
            MainColorsForm mainColorsForm = new MainColorsForm();
            mainColorsForm.Show();
        }
    }
}
