
namespace lab_Form
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bbb = new System.Windows.Forms.Button();
            this.bbb2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "物件初始化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "註冊事件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bbb
            // 
            this.bbb.Location = new System.Drawing.Point(151, 134);
            this.bbb.Name = "bbb";
            this.bbb.Size = new System.Drawing.Size(175, 23);
            this.bbb.TabIndex = 2;
            this.bbb.Text = "觸發事件後可點選";
            this.bbb.UseVisualStyleBackColor = true;
            // 
            // bbb2
            // 
            this.bbb2.Location = new System.Drawing.Point(151, 163);
            this.bbb2.Name = "bbb2";
            this.bbb2.Size = new System.Drawing.Size(175, 23);
            this.bbb2.TabIndex = 3;
            this.bbb2.Text = "觸發事件後可點選2";
            this.bbb2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "取消註冊";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bbb2);
            this.Controls.Add(this.bbb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bbb;
        private System.Windows.Forms.Button bbb2;
        private System.Windows.Forms.Button button4;
    }
}