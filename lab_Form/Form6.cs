﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab_Form.day2;

namespace lab_Form
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nnn = 50; //實質型別設定完值後下方重新設立的變數不會改變

            MessageBox.Show(nnn.ToString());

            vistps(nnn); 

            MessageBox.Show(nnn.ToString());
        }
        void vistps(decimal p)
        {
            p = 1000;
        }
//-----------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            member mmm = new member();//  在day2 之前定義的資料

            mmm.age = 30;

            mmm.name = "哈哈";

            viciviv(mmm);  //把方法帶入(上方變數)

            MessageBox.Show(mmm.age + ","+mmm.name);

        }
        void viciviv(member zzz)
        {
            zzz.age = 50;
        }
//--------------------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            decimal cc = 10;//  先定義cc

            bybyby(ref cc);// 用下列方法帶入上方值 ref會強制更改傳址

            MessageBox.Show(cc.ToString());
        }
        void bybyby(ref decimal x)
        {
            x = 1000;
        }
//--------------------------------------------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            int a;  // 先定義a

            int b;  // 一樣先定義一個b

            outtt(out a,out b); // 在把a帶入下方參考中  out會強制帶入傳址


            MessageBox.Show(a.ToString());
            MessageBox.Show(b.ToString());
        }
        void outtt(out int x,out int y)
        {
            x = 10;
            y = 20;
        }
    }
}
