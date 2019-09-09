using ReliefAnalyze.Logic.ColorDetect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReliefAnalyze
{
    public partial class MainColorsForm : Form
    {
        public MainColorsForm()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = colorGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cell.Style.BackColor = colorDialog1.Color;
            }
        }

        private void ResetColorsButton_Click(object sender, EventArgs e)
        {
            var mapObjectColors = MapObjectsColors.GetInstance();
            mapObjectColors.SetDefaultColors();
            DrawMaincolors();
        }

        private void AddMissingRows(int count)
        {
            var rowsCount = colorGridView.Rows.Count;
            if (rowsCount < count)
            {
                colorGridView.Rows.Add(count - rowsCount);


                for (int j = 0; j < colorGridView.Columns.Count; j++)
                {
                    colorGridView.Rows[rowsCount - 1].Cells[j].Style.BackColor = colorGridView.Rows[count - 1].Cells[j].Style.BackColor;
                    colorGridView.Rows[count - 1].Cells[j].Style.BackColor = Color.White;

                }
            }
        }

        private void DrawMaincolors()
        {
            var mapObjectColors = MapObjectsColors.GetInstance();


            foreach (PropertyInfo propertyInfo in mapObjectColors.GetType().GetProperties())
            {
                var colors = (List<ColorInfo>)propertyInfo.GetValue(mapObjectColors, null);
                var propName = propertyInfo.Name;
                var colorName = propName.Substring(0, propName.IndexOf("Color"));
                AddMissingRows(colors.Count);
                for (int i = 0; i < colors.Count; i++)
                {
                    var row = colorGridView.Rows[i];
                    row.Cells[colorName].Style.BackColor = colors[i].Color;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var mapObjectColors = MapObjectsColors.GetInstance();
            var row = colorGridView.Rows[0];
            foreach (PropertyInfo propertyInfo in mapObjectColors.GetType().GetProperties())
            {
                var colors = (List<ColorInfo>)propertyInfo.GetValue(mapObjectColors, null);
                var propName = propertyInfo.Name;
                var colorName = propName.Substring(0, propName.IndexOf("Color"));
                var selectedColor = row.Cells[colorName].Style.BackColor;
                var near = ColorHelper.GetNearestColorName(ColorHelper.GetSystemDrawingColorFromHexString("#" + selectedColor.Name.Substring(2)));
                colors.Clear();
                colors.Add(new ColorInfo { Color = selectedColor, NearColor = near} );
            }
            //mapObjectColors.HillsColor.Clear();
            //mapObjectColors.HillsColor.Add(row.Cells["Hills"].Style.BackColor);
            //mapObjectColors.MountainsColor.Clear();
            //mapObjectColors.MountainsColor.Add(row.Cells["Mountains"].Style.BackColor);
            //mapObjectColors.SandColor.Clear();
            //mapObjectColors.SandColor.Add(row.Cells["Sand"].Style.BackColor);
            //mapObjectColors.RiversColor.Clear();
            //mapObjectColors.RiversColor.Add(row.Cells["Rivers"].Style.BackColor);
            //mapObjectColors.ForestsColor.Clear();
            //mapObjectColors.ForestsColor.Add(row.Cells["Forests"].Style.BackColor);
            //mapObjectColors.PlainColor.Clear();
            //mapObjectColors.PlainColor.Add(row.Cells["Plain"].Style.BackColor);
            //mapObjectColors.CultureColor.Clear();
            //mapObjectColors.CultureColor.Add(row.Cells["Culture"].Style.BackColor);
            //mapObjectColors.IceColor.Clear();
            //mapObjectColors.IceColor.Add(row.Cells["Ice"].Style.BackColor);
            //mapObjectColors.PondsColor.Clear();
            //mapObjectColors.PondsColor.Add(row.Cells["Ponds"].Style.BackColor);
        }

        private void MainColorsForm_Load(object sender, EventArgs e)
        {
            DrawMaincolors();
        }
    }
}
