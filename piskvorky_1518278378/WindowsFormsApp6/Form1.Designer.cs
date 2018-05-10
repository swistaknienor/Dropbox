namespace WindowsFormsApp6
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
            this.dgwTicTacToe = new System.Windows.Forms.DataGridView();
            this.bApply = new System.Windows.Forms.Button();
            this.tbTicTacToe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTicTacToe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTicTacToe
            // 
            this.dgwTicTacToe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTicTacToe.Location = new System.Drawing.Point(118, 12);
            this.dgwTicTacToe.Name = "dgwTicTacToe";
            this.dgwTicTacToe.Size = new System.Drawing.Size(773, 435);
            this.dgwTicTacToe.TabIndex = 0;
            this.dgwTicTacToe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTicTacToe_CellClick);
            this.dgwTicTacToe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTicTacToe_CellContentClick);
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(12, 38);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(100, 23);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // tbTicTacToe
            // 
            this.tbTicTacToe.Location = new System.Drawing.Point(12, 12);
            this.tbTicTacToe.Name = "tbTicTacToe";
            this.tbTicTacToe.Size = new System.Drawing.Size(100, 20);
            this.tbTicTacToe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 456);
            this.Controls.Add(this.tbTicTacToe);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.dgwTicTacToe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTicTacToe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTicTacToe;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.TextBox tbTicTacToe;
    }
}

