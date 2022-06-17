using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab_Form.Form3;

namespace lab_Form
{
    public partial class Form000 : Form
    {
        public Form000()
        {
            InitializeComponent();
        }

        private void zzz_Click(object sender, EventArgs e)
        {
           play mc = new play();
            MessageBox.Show(mc);
        }
    }
}
