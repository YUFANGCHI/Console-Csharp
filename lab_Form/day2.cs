﻿using System;
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
    public partial class day2 : Form
    {
        public day2()
        {
            InitializeComponent();
        }

        private void openform1_Click(object sender, EventArgs e)
        {
            day1 form01 = new day1();   // Form1 為表單1 form01為自設名稱 = new 為實作 Form1(表單1)
            form01.Show();   // form01 自設名稱 show 顯示變數
                             //---------------------------------------------------------------------------------------------------------------------------              
        }
        void firstplay()  // 設定呼叫不回傳值 firstplay 自訂名稱()
        {
            MessageBox.Show("完成play");
        }


        private void button1_Click(object sender, EventArgs e)  // 本行為first01 botton 按鈕
        {
            firstplay();   // 呼叫上方設定好的類別

        }

        //---------------------------------------------------------------------------------------------------------------------------
        string birthday_return(int age)  //沒有回傳值void 直接變數再設定內容
        {
            int birthday_return = DateTime.Now.Year - age;  //int 整數 = 後方為計算公式
            string ageday = "出生年為" + birthday_return + "年";  //字串 自訂詞 = ""+""
            return ageday;  //需回傳值 自訂計算
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string age = birthday_return(99);  //需用字串接住=回傳值
            MessageBox.Show(age);    //最後須顯示跳出視窗(年)
        }
        //---------------------------------------------------------------------------------------------------------------------------
        private void button1_Click_1(object sender, EventArgs e)
        {
            Class02 mc = new Class02();

            // mc.play01(); 安全性無法執行
            // mc.play02(); 安全性無法執行
            mc.play03();
            mc.play04();
        }
        //---------------------------------------------------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            Class02 mc = new Class02(); // 實作class01 設為mc
            mc.play05();   // 執行mc.play05
        }
        //---------------------------------------------------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            Class02 mc = new Class02();
            mc.play06();
        }
    }
}