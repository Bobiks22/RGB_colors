namespace RGB_colors
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
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.chbPercent = new System.Windows.Forms.CheckBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.lblGreen = new System.Windows.Forms.Label();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.scrollRed = new System.Windows.Forms.TrackBar();
            this.scrollGreen = new System.Windows.Forms.TrackBar();
            this.scrollBlue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(126, 27);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(230, 68);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // chbPercent
            // 
            this.chbPercent.AutoSize = true;
            this.chbPercent.Location = new System.Drawing.Point(126, 102);
            this.chbPercent.Name = "chbPercent";
            this.chbPercent.Size = new System.Drawing.Size(105, 17);
            this.chbPercent.TabIndex = 4;
            this.chbPercent.Text = "Color in percents";
            this.chbPercent.UseVisualStyleBackColor = true;
            this.chbPercent.CheckStateChanged += new System.EventHandler(this.chbPercent_CheckStateChanged);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(11, 266);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "Red";
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(53, 266);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(45, 20);
            this.tbRed.TabIndex = 6;
            this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(245, 266);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(45, 20);
            this.tbGreen.TabIndex = 8;
            this.tbGreen.TextChanged += new System.EventHandler(this.tbGreen_TextChanged);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(194, 266);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "Green";
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(437, 263);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(45, 20);
            this.tbBlue.TabIndex = 10;
            this.tbBlue.TextChanged += new System.EventHandler(this.tbBlue_TextChanged);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(391, 269);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 9;
            this.lblBlue.Text = "Blue";
            // 
            // scrollRed
            // 
            this.scrollRed.Location = new System.Drawing.Point(5, 125);
            this.scrollRed.Name = "scrollRed";
            this.scrollRed.Size = new System.Drawing.Size(479, 45);
            this.scrollRed.TabIndex = 12;
            this.scrollRed.Scroll += new System.EventHandler(this.scrollRed_Scroll);
            // 
            // scrollGreen
            // 
            this.scrollGreen.Location = new System.Drawing.Point(5, 176);
            this.scrollGreen.Name = "scrollGreen";
            this.scrollGreen.Size = new System.Drawing.Size(479, 45);
            this.scrollGreen.TabIndex = 13;
            this.scrollGreen.Scroll += new System.EventHandler(this.scrollGreen_Scroll);
            // 
            // scrollBlue
            // 
            this.scrollBlue.Location = new System.Drawing.Point(5, 215);
            this.scrollBlue.Name = "scrollBlue";
            this.scrollBlue.Size = new System.Drawing.Size(479, 45);
            this.scrollBlue.TabIndex = 14;
            this.scrollBlue.Scroll += new System.EventHandler(this.scrollBlue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 299);
            this.Controls.Add(this.scrollBlue);
            this.Controls.Add(this.scrollGreen);
            this.Controls.Add(this.scrollRed);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.chbPercent);
            this.Controls.Add(this.colorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.CheckBox chbPercent;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar scrollRed;
        private System.Windows.Forms.TrackBar scrollGreen;
        private System.Windows.Forms.TrackBar scrollBlue;
    }
}

