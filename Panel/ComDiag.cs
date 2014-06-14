using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class ComDiag : Form
    {
        public ComDiag()
        {
            InitializeComponent();
            //richTextBoxComDiag.ReadOnly = true;
            richTextBoxComDiag.Text = "Connection Failed.";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBoxComDiag_TextChanged(object sender, EventArgs e)
        {
            richTextBoxComDiag.Text = "Connection Failed.";
        }
    }
}
