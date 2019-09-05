using ReliefAnalyze.Logic.ColorDetect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            var mapObjectColors = MapObjectsColors.getInstance();
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
            var mapObjectColors = MapObjectsColors.getInstance();
            AddMissingRows(mapObjectColors.PondsColor.Count);
            for (int i = 0; i < mapObjectColors.PondsColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Ponds"].Style.BackColor = mapObjectColors.PondsColor[i];
            }
            AddMissingRows(mapObjectColors.HillsColor.Count);
            for (int i = 0; i < mapObjectColors.HillsColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Hills"].Style.BackColor = mapObjectColors.HillsColor[i];
            }
            AddMissingRows(mapObjectColors.RiversColor.Count);
            for (int i = 0; i < mapObjectColors.RiversColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Rivers"].Style.BackColor = mapObjectColors.RiversColor[i];
            }
            AddMissingRows(mapObjectColors.CultureColor.Count);
            for (int i = 0; i < mapObjectColors.CultureColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Culture"].Style.BackColor = mapObjectColors.CultureColor[i];
            }
            AddMissingRows(mapObjectColors.ForestsColor.Count);
            for (int i = 0; i < mapObjectColors.ForestsColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Forests"].Style.BackColor = mapObjectColors.ForestsColor[i];
            }
            AddMissingRows(mapObjectColors.IceColor.Count);
            for (int i = 0; i < mapObjectColors.IceColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Ice"].Style.BackColor = mapObjectColors.IceColor[i];
            }
            AddMissingRows(mapObjectColors.PlainColor.Count);
            for (int i = 0; i < mapObjectColors.PlainColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Plain"].Style.BackColor = mapObjectColors.PlainColor[i];
            }
            AddMissingRows(mapObjectColors.RoadsColor.Count);
            for (int i = 0; i < mapObjectColors.RoadsColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Roads"].Style.BackColor = mapObjectColors.RoadsColor[i];
            }
            AddMissingRows(mapObjectColors.SandColor.Count);
            for (int i = 0; i < mapObjectColors.SandColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Sand"].Style.BackColor = mapObjectColors.SandColor[i];
            }
            AddMissingRows(mapObjectColors.MountainsColor.Count);
            for (int i = 0; i < mapObjectColors.MountainsColor.Count; i++)
            {
                var row = colorGridView.Rows[i];
                row.Cells["Mountains"].Style.BackColor = mapObjectColors.MountainsColor[i];
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var mapObjectColors = MapObjectsColors.getInstance();
            var row = colorGridView.Rows[0];
            mapObjectColors.HillsColor.Clear();
            mapObjectColors.HillsColor.Add(row.Cells["Hills"].Style.BackColor);
            mapObjectColors.MountainsColor.Clear();
            mapObjectColors.MountainsColor.Add(row.Cells["Mountains"].Style.BackColor);
            mapObjectColors.SandColor.Clear();
            mapObjectColors.SandColor.Add(row.Cells["Sand"].Style.BackColor);
            mapObjectColors.RiversColor.Clear();
            mapObjectColors.RiversColor.Add(row.Cells["Rivers"].Style.BackColor);
            mapObjectColors.ForestsColor.Clear();
            mapObjectColors.ForestsColor.Add(row.Cells["Forests"].Style.BackColor);
            mapObjectColors.PlainColor.Clear();
            mapObjectColors.PlainColor.Add(row.Cells["Plain"].Style.BackColor);
            mapObjectColors.CultureColor.Clear();
            mapObjectColors.CultureColor.Add(row.Cells["Culture"].Style.BackColor);
            mapObjectColors.IceColor.Clear();
            mapObjectColors.IceColor.Add(row.Cells["Ice"].Style.BackColor);
            mapObjectColors.PondsColor.Clear();
            mapObjectColors.PondsColor.Add(row.Cells["Ponds"].Style.BackColor);
        }

        private void MainColorsForm_Load(object sender, EventArgs e)
        {
            DrawMaincolors();
        }
    }
}
