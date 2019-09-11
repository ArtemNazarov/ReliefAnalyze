using MaterialSkin.Controls;
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
    public partial class MainColorsForm : MaterialForm
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

            foreach (var elem in mapObjectColors.ColorsDict)
            {
                var colors = elem.Value;
                AddMissingRows(colors.Count);
                for (int i = 0; i < colors.Count; i++)
                {
                    var row = colorGridView.Rows[i];
                    row.Cells[elem.Key].Style.BackColor = colors[i].Color;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var mapObjectColors = MapObjectsColors.GetInstance();
            var row = colorGridView.Rows[0];
            foreach (var elem in mapObjectColors.ColorsDict)
            {
                var colorName = elem.Key;
                var selectedColor = row.Cells[colorName].Style.BackColor;
                //var near = ColorHelper.GetNearestColorName(ColorHelper.GetSystemDrawingColorFromHexString("#" + selectedColor.Name.Substring(2)));
                elem.Value.Clear();
                elem.Value.Add(new ColorInfo { Color = selectedColor, NearColor = selectedColor.Name });
            }
        }

        private void MainColorsForm_Load(object sender, EventArgs e)
        {
            DrawMaincolors();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
