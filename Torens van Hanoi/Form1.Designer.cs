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
            this.Ring6 = new System.Windows.Forms.PictureBox();
            this.Ring1 = new System.Windows.Forms.PictureBox();
            this.Ring2 = new System.Windows.Forms.PictureBox();
            this.Ring3 = new System.Windows.Forms.PictureBox();
            this.Ring4 = new System.Windows.Forms.PictureBox();
            this.Ring5 = new System.Windows.Forms.PictureBox();
            this.Ring8 = new System.Windows.Forms.PictureBox();
            this.Toren1 = new System.Windows.Forms.PictureBox();
            this.Ring7 = new System.Windows.Forms.PictureBox();
            this.LabelMovesDisplay = new System.Windows.Forms.Label();
            this.Btn_ResetGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Toren3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring7)).BeginInit();
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
            this.Toren3.Click += new System.EventHandler(this.Toren3_Click);
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
            // Ring6
            // 
            this.Ring6.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring6.Location = new System.Drawing.Point(120, 270);
            this.Ring6.Name = "Ring6";
            this.Ring6.Size = new System.Drawing.Size(80, 7);
            this.Ring6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring6.TabIndex = 10;
            this.Ring6.TabStop = false;
            this.Ring6.Tag = "6";
            this.Ring6.Click += new System.EventHandler(this.Select);
            // 
            // Ring1
            // 
            this.Ring1.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring1.Location = new System.Drawing.Point(150, 230);
            this.Ring1.Name = "Ring1";
            this.Ring1.Size = new System.Drawing.Size(30, 7);
            this.Ring1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring1.TabIndex = 9;
            this.Ring1.TabStop = false;
            this.Ring1.Tag = "1";
            this.Ring1.Click += new System.EventHandler(this.Select);
            // 
            // Ring2
            // 
            this.Ring2.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring2.Location = new System.Drawing.Point(144, 238);
            this.Ring2.Name = "Ring2";
            this.Ring2.Size = new System.Drawing.Size(40, 7);
            this.Ring2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring2.TabIndex = 8;
            this.Ring2.TabStop = false;
            this.Ring2.Tag = "2";
            this.Ring2.Click += new System.EventHandler(this.Select);
            // 
            // Ring3
            // 
            this.Ring3.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring3.Location = new System.Drawing.Point(138, 246);
            this.Ring3.Name = "Ring3";
            this.Ring3.Size = new System.Drawing.Size(50, 7);
            this.Ring3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring3.TabIndex = 7;
            this.Ring3.TabStop = false;
            this.Ring3.Tag = "3";
            this.Ring3.Click += new System.EventHandler(this.Select);
            // 
            // Ring4
            // 
            this.Ring4.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring4.Location = new System.Drawing.Point(132, 254);
            this.Ring4.Name = "Ring4";
            this.Ring4.Size = new System.Drawing.Size(60, 7);
            this.Ring4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring4.TabIndex = 6;
            this.Ring4.TabStop = false;
            this.Ring4.Tag = "4";
            this.Ring4.Click += new System.EventHandler(this.Select);
            // 
            // Ring5
            // 
            this.Ring5.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring5.Location = new System.Drawing.Point(126, 262);
            this.Ring5.Name = "Ring5";
            this.Ring5.Size = new System.Drawing.Size(70, 7);
            this.Ring5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring5.TabIndex = 5;
            this.Ring5.TabStop = false;
            this.Ring5.Tag = "5";
            this.Ring5.Click += new System.EventHandler(this.Select);
            // 
            // Ring8
            // 
            this.Ring8.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring8.Location = new System.Drawing.Point(108, 286);
            this.Ring8.Name = "Ring8";
            this.Ring8.Size = new System.Drawing.Size(100, 7);
            this.Ring8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring8.TabIndex = 4;
            this.Ring8.TabStop = false;
            this.Ring8.Tag = "8";
            this.Ring8.Click += new System.EventHandler(this.Select);
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
            // Ring7
            // 
            this.Ring7.BackColor = System.Drawing.SystemColors.Control;
            this.Ring7.Image = global::Torens_van_Hanoi.Properties.Resources.Ring8;
            this.Ring7.Location = new System.Drawing.Point(114, 278);
            this.Ring7.Name = "Ring7";
            this.Ring7.Size = new System.Drawing.Size(90, 7);
            this.Ring7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ring7.TabIndex = 15;
            this.Ring7.TabStop = false;
            this.Ring7.Tag = "7";
            this.Ring7.Click += new System.EventHandler(this.Select);
            // 
            // LabelMovesDisplay
            // 
            this.LabelMovesDisplay.AutoSize = true;
            this.LabelMovesDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMovesDisplay.Location = new System.Drawing.Point(12, 9);
            this.LabelMovesDisplay.Name = "LabelMovesDisplay";
            this.LabelMovesDisplay.Size = new System.Drawing.Size(86, 24);
            this.LabelMovesDisplay.TabIndex = 16;
            this.LabelMovesDisplay.Text = "Moves: 0";
            // 
            // Btn_ResetGame
            // 
            this.Btn_ResetGame.Location = new System.Drawing.Point(12, 36);
            this.Btn_ResetGame.Name = "Btn_ResetGame";
            this.Btn_ResetGame.Size = new System.Drawing.Size(75, 23);
            this.Btn_ResetGame.TabIndex = 17;
            this.Btn_ResetGame.Text = "Reset";
            this.Btn_ResetGame.UseVisualStyleBackColor = true;
            this.Btn_ResetGame.Click += new System.EventHandler(this.Btn_ResetGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 292);
            this.Controls.Add(this.Btn_ResetGame);
            this.Controls.Add(this.LabelMovesDisplay);
            this.Controls.Add(this.Ring7);
            this.Controls.Add(this.Ring6);
            this.Controls.Add(this.Ring1);
            this.Controls.Add(this.Ring2);
            this.Controls.Add(this.Ring3);
            this.Controls.Add(this.Ring4);
            this.Controls.Add(this.Ring5);
            this.Controls.Add(this.Ring8);
            this.Controls.Add(this.Toren1);
            this.Controls.Add(this.Toren2);
            this.Controls.Add(this.Toren3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Torens van Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.Toren3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ring7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ring8;
        private System.Windows.Forms.PictureBox Ring5;
        private System.Windows.Forms.PictureBox Ring4;
        private System.Windows.Forms.PictureBox Ring3;
        private System.Windows.Forms.PictureBox Ring2;
        private System.Windows.Forms.PictureBox Ring1;
        private System.Windows.Forms.PictureBox Ring6;
        private System.Windows.Forms.PictureBox Toren1;
        private System.Windows.Forms.PictureBox Toren2;
        private System.Windows.Forms.PictureBox Toren3;
        private System.Windows.Forms.PictureBox Ring7;
        private System.Windows.Forms.Label LabelMovesDisplay;
        private System.Windows.Forms.Button Btn_ResetGame;
    }
}

