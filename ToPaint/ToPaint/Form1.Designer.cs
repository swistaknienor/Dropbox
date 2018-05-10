namespace ToPaint
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
            this.ColourSelection = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_orange = new System.Windows.Forms.PictureBox();
            this.pictureBox_green = new System.Windows.Forms.PictureBox();
            this.pictureBox_pink = new System.Windows.Forms.PictureBox();
            this.pictureBox_red = new System.Windows.Forms.PictureBox();
            this.pictureBox_gray = new System.Windows.Forms.PictureBox();
            this.pictureBox_black = new System.Windows.Forms.PictureBox();
            this.pictureBox_lightblue = new System.Windows.Forms.PictureBox();
            this.ColourSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lightblue)).BeginInit();
            this.SuspendLayout();
            // 
            // ColourSelection
            // 
            this.ColourSelection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColourSelection.Controls.Add(this.pictureBox_lightblue);
            this.ColourSelection.Controls.Add(this.pictureBox_black);
            this.ColourSelection.Controls.Add(this.pictureBox_gray);
            this.ColourSelection.Controls.Add(this.pictureBox_red);
            this.ColourSelection.Controls.Add(this.pictureBox_pink);
            this.ColourSelection.Controls.Add(this.pictureBox_green);
            this.ColourSelection.Controls.Add(this.pictureBox_orange);
            this.ColourSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColourSelection.Location = new System.Drawing.Point(0, 0);
            this.ColourSelection.Name = "ColourSelection";
            this.ColourSelection.Size = new System.Drawing.Size(749, 100);
            this.ColourSelection.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 472);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox_orange
            // 
            this.pictureBox_orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox_orange.Location = new System.Drawing.Point(22, 23);
            this.pictureBox_orange.Name = "pictureBox_orange";
            this.pictureBox_orange.Size = new System.Drawing.Size(52, 50);
            this.pictureBox_orange.TabIndex = 0;
            this.pictureBox_orange.TabStop = false;
            this.pictureBox_orange.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox_green
            // 
            this.pictureBox_green.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_green.Location = new System.Drawing.Point(196, 23);
            this.pictureBox_green.Name = "pictureBox_green";
            this.pictureBox_green.Size = new System.Drawing.Size(52, 50);
            this.pictureBox_green.TabIndex = 1;
            this.pictureBox_green.TabStop = false;
            this.pictureBox_green.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox_pink
            // 
            this.pictureBox_pink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox_pink.Location = new System.Drawing.Point(80, 23);
            this.pictureBox_pink.Name = "pictureBox_pink";
            this.pictureBox_pink.Size = new System.Drawing.Size(52, 50);
            this.pictureBox_pink.TabIndex = 2;
            this.pictureBox_pink.TabStop = false;
            this.pictureBox_pink.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox_red
            // 
            this.pictureBox_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox_red.Location = new System.Drawing.Point(138, 23);
            this.pictureBox_red.Name = "pictureBox_red";
            this.pictureBox_red.Size = new System.Drawing.Size(52, 50);
            this.pictureBox_red.TabIndex = 3;
            this.pictureBox_red.TabStop = false;
            this.pictureBox_red.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox_gray
            // 
            this.pictureBox_gray.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_gray.Location = new System.Drawing.Point(312, 23);
            this.pictureBox_gray.Name = "pictureBox_gray";
            this.pictureBox_gray.Size = new System.Drawing.Size(52, 50);
            this.pictureBox_gray.TabIndex = 4;
            this.pictureBox_gray.TabStop = false;
            this.pictureBox_gray.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox_black
            // 
            this.pictureBox_black.BackColor = System.Drawing.Color.Black;
            this.pictureBox_black.Location = new System.Drawing.Point(370, 23);
            this.pictureBox_black.Name = "pictureBox_black";
            this.pictureBox_black.Size = new System.Drawing.Size(52, 50);
            this.pictureBox_black.TabIndex = 5;
            this.pictureBox_black.TabStop = false;
            this.pictureBox_black.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox_lightblue
            // 
            this.pictureBox_lightblue.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox_lightblue.Location = new System.Drawing.Point(254, 23);
            this.pictureBox_lightblue.Name = "pictureBox_lightblue";
            this.pictureBox_lightblue.Size = new System.Drawing.Size(52, 50);
            this.pictureBox_lightblue.TabIndex = 6;
            this.pictureBox_lightblue.TabStop = false;
            this.pictureBox_lightblue.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(749, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColourSelection);
            this.Name = "Form1";
            this.Text = "Painting Canvas";
            this.ColourSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lightblue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ColourSelection;
        private System.Windows.Forms.PictureBox pictureBox_lightblue;
        private System.Windows.Forms.PictureBox pictureBox_black;
        private System.Windows.Forms.PictureBox pictureBox_gray;
        private System.Windows.Forms.PictureBox pictureBox_red;
        private System.Windows.Forms.PictureBox pictureBox_pink;
        private System.Windows.Forms.PictureBox pictureBox_green;
        private System.Windows.Forms.PictureBox pictureBox_orange;
        private System.Windows.Forms.Panel panel1;
    }
}

