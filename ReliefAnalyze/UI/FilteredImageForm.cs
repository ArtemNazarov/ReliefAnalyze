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
    public partial class FilteredImageForm : Form
    {
        public Bitmap Image { get; set; }
        public FilteredImageForm()
        {
            InitializeComponent();
        }

        private void FilteredImageForm_Load(object sender, EventArgs e)
        {
            imageBox.Image = Image;
        }
    }
}
