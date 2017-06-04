using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManege
{
    public partial class DauSach : Form
    {
        public DauSach()
        {
            InitializeComponent();
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxX2_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxX2.Text.Equals(""))
            {
                MessageBox.Show("ddddd");
            }
        }
    }
}
