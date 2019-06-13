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
    public partial class AnalyzeForm : Form
    {
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        public void SetDataGridView(List<KeyValuePair<string,ColorInfo>> colors)
        {
            for (int i = 0; i < colors.Count; i++)
            {
                this.colorGridView.Columns.Add("Color" + (i + 1).ToString(), (i + 1).ToString());
                Color color = Color.FromArgb(Convert.ToInt32(colors[i].Key));
                this.colorGridView.Rows[0].Cells[i].Style.BackColor = color;
            }
        }

        public void AddAnalyze(string analyze)
        {
            this.analyzeLabel.Text = analyze;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
