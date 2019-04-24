namespace Torens_van_Hanoi
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
            this.Toren3 = new System.Windows.Forms.PictureBox();
            this.Toren2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Toren1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Toren3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toren3
            // 
            this.Toren3.Image = global::Torens_van_Hanoi.Properties.Resources.Pole;
            this.Toren3.Location = new System.Drawing.Point(555, 193);
            this.Toren3.Name = "Toren3";
            this.Toren3.Size = new System.Drawing.Size(20, 100);
            this.Toren3.TabIndex = 14;
            this.Toren3.TabStop = false;
            // 
            // Toren2
            // 
            this.Toren2.Image = global::Torens_van_Hanoi.Properties.Resources.Pole;
            this.Toren2.Location = new System.Drawing.Point(355, 193);
            this.Toren2.Name = "Toren2";
            this.Toren2.Size = new System.Drawing.Size(20, 100);
            this.Toren2.TabIndex = 13;
            this.Toren2.TabStop = false;
            this.Toren2.Click += new System.EventHandler(this.Toren2_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox10.Location = new System.Drawing.Point(120, 270);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(80, 7);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "6";
            this.pictureBox10.Click += new System.EventHandler(this.Select);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox9.Location = new System.Drawing.Point(150, 230);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 7);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "1";
            this.pictureBox9.Click += new System.EventHandler(this.Select);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox8.Location = new System.Drawing.Point(144, 238);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 7);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "2";
            this.pictureBox8.Click += new System.EventHandler(this.Select);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox7.Location = new System.Drawing.Point(138, 246);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 7);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "3";
            this.pictureBox7.Click += new System.EventHandler(this.Select);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox6.Location = new System.Drawing.Point(132, 254);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 7);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "4";
            this.pictureBox6.Click += new System.EventHandler(this.Select);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox5.Location = new System.Drawing.Point(126, 262);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 7);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "5";
            this.pictureBox5.Click += new System.EventHandler(this.Select);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox4.Location = new System.Drawing.Point(108, 286);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 7);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "8";
            this.pictureBox4.Click += new System.EventHandler(this.Select);
            // 
            // Toren1
            // 
            this.Toren1.Image = global::Torens_van_Hanoi.Properties.Resources.Pole;
            this.Toren1.Location = new System.Drawing.Point(155, 193);
            this.Toren1.Name = "Toren1";
            this.Toren1.Size = new System.Drawing.Size(20, 100);
            this.Toren1.TabIndex = 12;
            this.Toren1.TabStop = false;
            this.Toren1.Click += new System.EventHandler(this.Toren1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.pictureBox1.Location = new System.Drawing.Point(114, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 7);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "7";
            this.pictureBox1.Click += new System.EventHandler(this.Select);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Toren3);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Toren1);
            this.Controls.Add(this.Toren2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Toren3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox Toren1;
        private System.Windows.Forms.PictureBox Toren2;
        private System.Windows.Forms.PictureBox Toren3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

