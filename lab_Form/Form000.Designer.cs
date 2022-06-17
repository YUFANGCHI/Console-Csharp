
namespace lab_Form
{
    partial class Form000
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
            this.zzz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zzz
            // 
            this.zzz.Location = new System.Drawing.Point(589, 101);
            this.zzz.Name = "zzz";
            this.zzz.Size = new System.Drawing.Size(90, 51);
            this.zzz.TabIndex = 0;
            this.zzz.Text = "物件初始化";
            this.zzz.UseVisualStyleBackColor = true;
            this.zzz.Click += new System.EventHandler(this.zzz_Click);
            // 
            // Form000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zzz);
            this.Name = "Form000";
            this.Text = "Form000";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zzz;
    }
}