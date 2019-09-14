using MaterialSkin.Controls;
using ReliefAnalyze.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReliefAnalyze.UI
{
    public partial class CriteriaForm : MaterialForm
    {
        public CriteriaForm()
        {
            InitializeComponent();
        }


        private void setDataGridView()
        {
            var criteries = CriteriaObject.GetInstance().CriteriaDict;
            //var currentRow = 0;
            //var currentRow = criteriaGridView.Rows.Add();
            var currentRow = 0;
            foreach (var criteria in criteries)
            {
                currentRow = criteriaGridView.Rows.Add();
                var buildingName = criteria.Key;
                var row = criteriaGridView.Rows[currentRow];
                row.Cells["Building"].Value = buildingName;
                foreach (var mapObject in criteria.Value)
                {
                    var objectName = mapObject.Key;
                    var priority = mapObject.Value;
                    var cell = row.Cells[objectName];
                    cell.Value = priority;
                }
            }
            //criteriaGridView.Rows.RemoveAt(currentRow + 1);
        }

        private void CriteriaForm_Load(object sender, EventArgs e)
        {
            setDataGridView();
        }
    }
}
