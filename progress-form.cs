using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpxHeatmap
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void logtext_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void logtext_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instance.DestroyLogForm();
        }

        private void ProgressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.Instance.DestroyLogForm();
        }
    }
}
