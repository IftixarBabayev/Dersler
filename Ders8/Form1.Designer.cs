
namespace Ders8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(73, 50);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(271, 23);
            this.nametxt.TabIndex = 1;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(73, 140);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(271, 23);
            this.agetxt.TabIndex = 3;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(73, 90);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(271, 23);
            this.surnametxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox surnametxt;
    }
}

