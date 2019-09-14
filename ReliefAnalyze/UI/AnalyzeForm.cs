using MaterialSkin.Controls;
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
    public partial class AnalyzeForm : MaterialForm
    {
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        public void SetPointGridView(Dictionary<string,bool> mapObjects)
        {
            var row = this.pointsGridView.Rows[0];
            foreach (var elem in mapObjects)
            {
                row.Cells[elem.Key].Value = Convert.ToInt32(elem.Value); ;
            }
        }

        public void SetFragmentGridView(Dictionary<string, bool> mapObjects)
        {
            var row = this.fragmentGridView.Rows[0];
            foreach (var elem in mapObjects)
            {
                row.Cells[elem.Key + "Fragment"].Value = Convert.ToInt32(elem.Value);
            }

        }

        public void AddAnalyze(string analyze)
        {
            this.analyzeBox.Text = analyze;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnalyzeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
