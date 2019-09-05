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
    }
}
