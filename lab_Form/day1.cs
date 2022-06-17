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
    public partial class day1 : Form
    {
        public day1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textbox1.Text;    // string 變數 name自訂名稱 = 空白方框name為text1 . 開啟屬性
            string englishname = english_name.Text;
            string sexsex = sex.Text;
            string mnbvc1 = mnbvc.Text;
            MessageBox.Show("星座"+mnbvc1,"性別"+sexsex,"英文名字"+englishname);    // MessageBox為彈出視窗 . show 為顯示變數 ("hello," + 自訂名稱 ) 
            
            

        }

      
    }
    }

