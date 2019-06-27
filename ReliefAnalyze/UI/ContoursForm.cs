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
    public partial class ContoursForm : Form
    {
        public Bitmap Image { get; set; }
        public ContoursForm()
        {
            InitializeComponent();
        }

        private void ContoursForm_Load(object sender, EventArgs e)
        {
            imageBox.Image = Image;
        }
    }
}
