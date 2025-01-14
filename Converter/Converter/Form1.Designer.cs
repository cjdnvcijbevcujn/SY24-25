namespace Converter
{
    partial class Form1
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
            this.bit5 = new System.Windows.Forms.TextBox();
            this.bit1 = new System.Windows.Forms.TextBox();
            this.bit2 = new System.Windows.Forms.TextBox();
            this.bit3 = new System.Windows.Forms.TextBox();
            this.bit4 = new System.Windows.Forms.TextBox();
            this.Totallabel = new System.Windows.Forms.Label();
            this.bit8 = new System.Windows.Forms.TextBox();
            this.bit7 = new System.Windows.Forms.TextBox();
            this.bit6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bit5
            // 
            this.bit5.Location = new System.Drawing.Point(182, 119);
            this.bit5.Name = "bit5";
            this.bit5.Size = new System.Drawing.Size(41, 22);
            this.bit5.TabIndex = 0;
            this.bit5.TextChanged += new System.EventHandler(this.bit4_TextChanged);
            // 
            // bit1
            // 
            this.bit1.Location = new System.Drawing.Point(333, 119);
            this.bit1.Name = "bit1";
            this.bit1.Size = new System.Drawing.Size(41, 22);
            this.bit1.TabIndex = 1;
            this.bit1.TextChanged += new System.EventHandler(this.bit4_TextChanged);
            // 
            // bit2
            // 
            this.bit2.Location = new System.Drawing.Point(295, 119);
            this.bit2.Name = "bit2";
            this.bit2.Size = new System.Drawing.Size(41, 22);
            this.bit2.TabIndex = 2;
            this.bit2.TextChanged += new System.EventHandler(this.bit4_TextChanged);
            // 
            // bit3
            // 
            this.bit3.Location = new System.Drawing.Point(258, 119);
            this.bit3.Name = "bit3";
            this.bit3.Size = new System.Drawing.Size(41, 22);
            this.bit3.TabIndex = 3;
            this.bit3.TextChanged += new System.EventHandler(this.bit4_TextChanged);
            // 
            // bit4
            // 
            this.bit4.Location = new System.Drawing.Point(220, 119);
            this.bit4.Name = "bit4";
            this.bit4.Size = new System.Drawing.Size(41, 22);
            this.bit4.TabIndex = 4;
            this.bit4.TextChanged += new System.EventHandler(this.bit4_TextChanged);
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Location = new System.Drawing.Point(220, 254);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(44, 16);
            this.Totallabel.TabIndex = 5;
            this.Totallabel.Text = "label1";
            // 
            // bit8
            // 
            this.bit8.Location = new System.Drawing.Point(66, 119);
            this.bit8.Name = "bit8";
            this.bit8.Size = new System.Drawing.Size(41, 22);
            this.bit8.TabIndex = 8;
            // 
            // bit7
            // 
            this.bit7.Location = new System.Drawing.Point(103, 119);
            this.bit7.Name = "bit7";
            this.bit7.Size = new System.Drawing.Size(41, 22);
            this.bit7.TabIndex = 7;
            // 
            // bit6
            // 
            this.bit6.Location = new System.Drawing.Point(141, 119);
            this.bit6.Name = "bit6";
            this.bit6.Size = new System.Drawing.Size(41, 22);
            this.bit6.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bit8);
            this.Controls.Add(this.bit7);
            this.Controls.Add(this.bit6);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.bit4);
            this.Controls.Add(this.bit3);
            this.Controls.Add(this.bit2);
            this.Controls.Add(this.bit1);
            this.Controls.Add(this.bit5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bit5;
        private System.Windows.Forms.TextBox bit1;
        private System.Windows.Forms.TextBox bit2;
        private System.Windows.Forms.TextBox bit3;
        private System.Windows.Forms.TextBox bit4;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox bit8;
        private System.Windows.Forms.TextBox bit7;
        private System.Windows.Forms.TextBox bit6;
    }
}

