using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          memmem mmm = new memmem(); // 先建立在設值
             mmm.name = "游芳季";  
             mmm.age = 29;
            MessageBox.Show("姓名:" + mmm.name + ",年齡" + mmm.age);
//--------------------------------------------------------------------------------------
            memmem mmm2 = new memmem()  // 建完就有值
            {
                name = "油坊季2",
                age = 29
            };
            MessageBox.Show("姓名:" + mmm2.name + ",年齡" + mmm2.age);
        }
//---------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            // this.button1.Click += new System.EventHandler(this.button1_Click);
            bbb.Click += new EventHandler(bbbclick);
            bbb2.Click += Bbb_Click_2;
        }

        private void Bbb_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("觸發成功2");
        }

        private void bbbclick(object sender, EventArgs e)
        {
            MessageBox.Show("觸發成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bbb.Click -= new EventHandler(bbbclick);
        }
    }
    }

