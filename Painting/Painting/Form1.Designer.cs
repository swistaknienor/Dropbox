namespace Painting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.clearCanvasbtn = new System.Windows.Forms.Button();
            this.eraserbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tberaser = new System.Windows.Forms.TextBox();
            this.pictureBox1_yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox2_orange = new System.Windows.Forms.PictureBox();
            this.pictureBox3_red = new System.Windows.Forms.PictureBox();
            this.pictureBox4_gray = new System.Windows.Forms.PictureBox();
            this.pictureBox5_green = new System.Windows.Forms.PictureBox();
            this.pictureBox6_blue = new System.Windows.Forms.PictureBox();
            this.pictureBox7_purple = new System.Windows.Forms.PictureBox();
            this.pictureBox8_pink = new System.Windows.Forms.PictureBox();
            this.pictureBox9_brown = new System.Windows.Forms.PictureBox();
            this.pictureBox10_black = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.palette = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7_purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8_pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9_brown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(2, 91);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1000, 551);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Click += new System.EventHandler(this.pictureBox1_Click);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brush size :";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(116, 17);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(44, 20);
            this.tbSize.TabIndex = 2;
            this.tbSize.Text = "10";
            this.tbSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSize.TextChanged += new System.EventHandler(this.tbSize_TextChanged);
            // 
            // clearCanvasbtn
            // 
            this.clearCanvasbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearCanvasbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearCanvasbtn.Location = new System.Drawing.Point(16, 49);
            this.clearCanvasbtn.Name = "clearCanvasbtn";
            this.clearCanvasbtn.Size = new System.Drawing.Size(144, 33);
            this.clearCanvasbtn.TabIndex = 3;
            this.clearCanvasbtn.Text = "Clear canvas";
            this.clearCanvasbtn.UseVisualStyleBackColor = false;
            this.clearCanvasbtn.Click += new System.EventHandler(this.clearCanvasbtn_Click);
            // 
            // eraserbtn
            // 
            this.eraserbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eraserbtn.Location = new System.Drawing.Point(166, 49);
            this.eraserbtn.Name = "eraserbtn";
            this.eraserbtn.Size = new System.Drawing.Size(165, 33);
            this.eraserbtn.TabIndex = 4;
            this.eraserbtn.Text = "Eraser";
            this.eraserbtn.UseVisualStyleBackColor = true;
            this.eraserbtn.Click += new System.EventHandler(this.eraserbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(163, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eraser size :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tberaser
            // 
            this.tberaser.Location = new System.Drawing.Point(269, 18);
            this.tberaser.Name = "tberaser";
            this.tberaser.Size = new System.Drawing.Size(62, 20);
            this.tberaser.TabIndex = 6;
            this.tberaser.Text = "10";
            this.tberaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tberaser.TextChanged += new System.EventHandler(this.tberaser_TextChanged);
            // 
            // pictureBox1_yellow
            // 
            this.pictureBox1_yellow.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1_yellow.Location = new System.Drawing.Point(376, 4);
            this.pictureBox1_yellow.Name = "pictureBox1_yellow";
            this.pictureBox1_yellow.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1_yellow.TabIndex = 7;
            this.pictureBox1_yellow.TabStop = false;
            // 
            // pictureBox2_orange
            // 
            this.pictureBox2_orange.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2_orange.Location = new System.Drawing.Point(376, 51);
            this.pictureBox2_orange.Name = "pictureBox2_orange";
            this.pictureBox2_orange.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2_orange.TabIndex = 8;
            this.pictureBox2_orange.TabStop = false;
            // 
            // pictureBox3_red
            // 
            this.pictureBox3_red.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox3_red.Location = new System.Drawing.Point(435, 4);
            this.pictureBox3_red.Name = "pictureBox3_red";
            this.pictureBox3_red.Size = new System.Drawing.Size(38, 31);
            this.pictureBox3_red.TabIndex = 9;
            this.pictureBox3_red.TabStop = false;
            // 
            // pictureBox4_gray
            // 
            this.pictureBox4_gray.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox4_gray.Location = new System.Drawing.Point(435, 51);
            this.pictureBox4_gray.Name = "pictureBox4_gray";
            this.pictureBox4_gray.Size = new System.Drawing.Size(38, 31);
            this.pictureBox4_gray.TabIndex = 10;
            this.pictureBox4_gray.TabStop = false;
            // 
            // pictureBox5_green
            // 
            this.pictureBox5_green.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox5_green.Location = new System.Drawing.Point(490, 4);
            this.pictureBox5_green.Name = "pictureBox5_green";
            this.pictureBox5_green.Size = new System.Drawing.Size(38, 31);
            this.pictureBox5_green.TabIndex = 11;
            this.pictureBox5_green.TabStop = false;
            // 
            // pictureBox6_blue
            // 
            this.pictureBox6_blue.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox6_blue.Location = new System.Drawing.Point(490, 51);
            this.pictureBox6_blue.Name = "pictureBox6_blue";
            this.pictureBox6_blue.Size = new System.Drawing.Size(38, 31);
            this.pictureBox6_blue.TabIndex = 12;
            this.pictureBox6_blue.TabStop = false;
            // 
            // pictureBox7_purple
            // 
            this.pictureBox7_purple.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox7_purple.Location = new System.Drawing.Point(546, 4);
            this.pictureBox7_purple.Name = "pictureBox7_purple";
            this.pictureBox7_purple.Size = new System.Drawing.Size(38, 31);
            this.pictureBox7_purple.TabIndex = 13;
            this.pictureBox7_purple.TabStop = false;
            // 
            // pictureBox8_pink
            // 
            this.pictureBox8_pink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox8_pink.Location = new System.Drawing.Point(546, 51);
            this.pictureBox8_pink.Name = "pictureBox8_pink";
            this.pictureBox8_pink.Size = new System.Drawing.Size(38, 31);
            this.pictureBox8_pink.TabIndex = 14;
            this.pictureBox8_pink.TabStop = false;
            // 
            // pictureBox9_brown
            // 
            this.pictureBox9_brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox9_brown.Location = new System.Drawing.Point(600, 4);
            this.pictureBox9_brown.Name = "pictureBox9_brown";
            this.pictureBox9_brown.Size = new System.Drawing.Size(38, 31);
            this.pictureBox9_brown.TabIndex = 15;
            this.pictureBox9_brown.TabStop = false;
            // 
            // pictureBox10_black
            // 
            this.pictureBox10_black.BackColor = System.Drawing.Color.Black;
            this.pictureBox10_black.Location = new System.Drawing.Point(600, 51);
            this.pictureBox10_black.Name = "pictureBox10_black";
            this.pictureBox10_black.Size = new System.Drawing.Size(38, 31);
            this.pictureBox10_black.TabIndex = 16;
            this.pictureBox10_black.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(376, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Location = new System.Drawing.Point(376, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox3.Location = new System.Drawing.Point(435, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 31);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox4.Location = new System.Drawing.Point(435, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 31);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox5.Location = new System.Drawing.Point(490, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 31);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox6.Location = new System.Drawing.Point(490, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 31);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox7.Location = new System.Drawing.Point(546, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 31);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox8.Location = new System.Drawing.Point(546, 54);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(38, 31);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox9.Location = new System.Drawing.Point(600, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(38, 31);
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.Location = new System.Drawing.Point(600, 54);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(38, 31);
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // palette
            // 
            this.palette.BackColor = System.Drawing.Color.Transparent;
            this.palette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.palette.Image = ((System.Drawing.Image)(resources.GetObject("palette.Image")));
            this.palette.Location = new System.Drawing.Point(1008, 4);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(205, 203);
            this.palette.TabIndex = 17;
            this.palette.TabStop = false;
            this.palette.Click += new System.EventHandler(this.palette_Click);
            this.palette.MouseDown += new System.Windows.Forms.MouseEventHandler(this.palette_MouseDown);
            this.palette.MouseMove += new System.Windows.Forms.MouseEventHandler(this.palette_MouseMove);
            this.palette.MouseUp += new System.Windows.Forms.MouseEventHandler(this.palette_MouseUp);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(1008, 213);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(205, 194);
            this.pictureBox11.TabIndex = 18;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1214, 643);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.palette);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox10_black);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox9_brown);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox8_pink);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox7_purple);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox6_blue);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox5_green);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox4_gray);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox3_red);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox2_orange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox1_yellow);
            this.Controls.Add(this.tberaser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eraserbtn);
            this.Controls.Add(this.clearCanvasbtn);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7_purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8_pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9_brown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button clearCanvasbtn;
        private System.Windows.Forms.Button eraserbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tberaser;
        private System.Windows.Forms.PictureBox pictureBox1_yellow;
        private System.Windows.Forms.PictureBox pictureBox2_orange;
        private System.Windows.Forms.PictureBox pictureBox3_red;
        private System.Windows.Forms.PictureBox pictureBox4_gray;
        private System.Windows.Forms.PictureBox pictureBox5_green;
        private System.Windows.Forms.PictureBox pictureBox6_blue;
        private System.Windows.Forms.PictureBox pictureBox7_purple;
        private System.Windows.Forms.PictureBox pictureBox8_pink;
        private System.Windows.Forms.PictureBox pictureBox9_brown;
        private System.Windows.Forms.PictureBox pictureBox10_black;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox palette;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}

