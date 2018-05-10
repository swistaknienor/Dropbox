namespace WindowsFormsApp1_interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
       
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lhumanIQ = new System.Windows.Forms.Label();
            this.ldolphinIQ = new System.Windows.Forms.Label();
            this.leagleIQ = new System.Windows.Forms.Label();
            this.CalcIQ = new System.Windows.Forms.Button();
            this.MakeBetterIQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "human";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(183, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "dolphin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(333, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "eagle";
            // 
            // lhumanIQ
            // 
            this.lhumanIQ.AutoSize = true;
            this.lhumanIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lhumanIQ.Location = new System.Drawing.Point(45, 134);
            this.lhumanIQ.Name = "lhumanIQ";
            this.lhumanIQ.Size = new System.Drawing.Size(60, 24);
            this.lhumanIQ.TabIndex = 3;
            this.lhumanIQ.Text = "label4";
            // 
            // ldolphinIQ
            // 
            this.ldolphinIQ.AutoSize = true;
            this.ldolphinIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldolphinIQ.Location = new System.Drawing.Point(198, 134);
            this.ldolphinIQ.Name = "ldolphinIQ";
            this.ldolphinIQ.Size = new System.Drawing.Size(60, 24);
            this.ldolphinIQ.TabIndex = 4;
            this.ldolphinIQ.Text = "label5";
            // 
            // leagleIQ
            // 
            this.leagleIQ.AutoSize = true;
            this.leagleIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leagleIQ.Location = new System.Drawing.Point(345, 134);
            this.leagleIQ.Name = "leagleIQ";
            this.leagleIQ.Size = new System.Drawing.Size(60, 24);
            this.leagleIQ.TabIndex = 5;
            this.leagleIQ.Text = "label6";
            // 
            // CalcIQ
            // 
            this.CalcIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalcIQ.Location = new System.Drawing.Point(64, 210);
            this.CalcIQ.Name = "CalcIQ";
            this.CalcIQ.Size = new System.Drawing.Size(96, 39);
            this.CalcIQ.TabIndex = 6;
            this.CalcIQ.Text = "Calc IQ";
            this.CalcIQ.UseVisualStyleBackColor = true;
            this.CalcIQ.Click += new System.EventHandler(this.CalcIQ_Click);
            // 
            // MakeBetterIQ
            // 
            this.MakeBetterIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MakeBetterIQ.Location = new System.Drawing.Point(282, 210);
            this.MakeBetterIQ.Name = "MakeBetterIQ";
            this.MakeBetterIQ.Size = new System.Drawing.Size(169, 39);
            this.MakeBetterIQ.TabIndex = 7;
            this.MakeBetterIQ.Text = "Make better IQ";
            this.MakeBetterIQ.UseVisualStyleBackColor = true;
            this.MakeBetterIQ.Click += new System.EventHandler(this.MakeBetterIQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 275);
            this.Controls.Add(this.MakeBetterIQ);
            this.Controls.Add(this.CalcIQ);
            this.Controls.Add(this.leagleIQ);
            this.Controls.Add(this.ldolphinIQ);
            this.Controls.Add(this.lhumanIQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lhumanIQ;
        private System.Windows.Forms.Label ldolphinIQ;
        private System.Windows.Forms.Label leagleIQ;
        private System.Windows.Forms.Button CalcIQ;
        private System.Windows.Forms.Button MakeBetterIQ;
    }
}

