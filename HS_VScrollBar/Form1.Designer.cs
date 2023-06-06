namespace HS_VScrollBar
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
			this.txtBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
			this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
			this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
			this.txtRed = new System.Windows.Forms.TextBox();
			this.txtBlue = new System.Windows.Forms.TextBox();
			this.txtGreen = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBox
			// 
			this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox.Location = new System.Drawing.Point(0, 0);
			this.txtBox.Multiline = true;
			this.txtBox.Name = "txtBox";
			this.txtBox.ReadOnly = true;
			this.txtBox.Size = new System.Drawing.Size(991, 450);
			this.txtBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(26, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Red";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(26, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Blue";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SpringGreen;
			this.label3.Location = new System.Drawing.Point(26, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Green";
			// 
			// hScrollBarRed
			// 
			this.hScrollBarRed.Location = new System.Drawing.Point(104, 50);
			this.hScrollBarRed.Maximum = 255;
			this.hScrollBarRed.Name = "hScrollBarRed";
			this.hScrollBarRed.Size = new System.Drawing.Size(774, 32);
			this.hScrollBarRed.TabIndex = 4;
			this.hScrollBarRed.ValueChanged += new System.EventHandler(this.hScrollBarRed_ValueChanged);
			// 
			// hScrollBarBlue
			// 
			this.hScrollBarBlue.Location = new System.Drawing.Point(104, 155);
			this.hScrollBarBlue.Maximum = 255;
			this.hScrollBarBlue.Name = "hScrollBarBlue";
			this.hScrollBarBlue.Size = new System.Drawing.Size(774, 32);
			this.hScrollBarBlue.TabIndex = 5;
			this.hScrollBarBlue.ValueChanged += new System.EventHandler(this.hScrollBarRed_ValueChanged);
			// 
			// hScrollBarGreen
			// 
			this.hScrollBarGreen.Location = new System.Drawing.Point(104, 102);
			this.hScrollBarGreen.Maximum = 255;
			this.hScrollBarGreen.Name = "hScrollBarGreen";
			this.hScrollBarGreen.Size = new System.Drawing.Size(774, 32);
			this.hScrollBarGreen.TabIndex = 6;
			this.hScrollBarGreen.ValueChanged += new System.EventHandler(this.hScrollBarRed_ValueChanged);
			// 
			// txtRed
			// 
			this.txtRed.ForeColor = System.Drawing.Color.Red;
			this.txtRed.Location = new System.Drawing.Point(896, 61);
			this.txtRed.Name = "txtRed";
			this.txtRed.ReadOnly = true;
			this.txtRed.Size = new System.Drawing.Size(83, 22);
			this.txtRed.TabIndex = 7;
			// 
			// txtBlue
			// 
			this.txtBlue.ForeColor = System.Drawing.Color.Blue;
			this.txtBlue.Location = new System.Drawing.Point(896, 166);
			this.txtBlue.Name = "txtBlue";
			this.txtBlue.ReadOnly = true;
			this.txtBlue.Size = new System.Drawing.Size(83, 22);
			this.txtBlue.TabIndex = 8;
			// 
			// txtGreen
			// 
			this.txtGreen.ForeColor = System.Drawing.Color.Lime;
			this.txtGreen.Location = new System.Drawing.Point(896, 113);
			this.txtGreen.Name = "txtGreen";
			this.txtGreen.ReadOnly = true;
			this.txtGreen.Size = new System.Drawing.Size(83, 22);
			this.txtGreen.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtGreen);
			this.groupBox1.Controls.Add(this.txtBlue);
			this.groupBox1.Controls.Add(this.txtRed);
			this.groupBox1.Controls.Add(this.hScrollBarGreen);
			this.groupBox1.Controls.Add(this.hScrollBarBlue);
			this.groupBox1.Controls.Add(this.hScrollBarRed);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 210);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(991, 240);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtBox);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HS VS croll bar";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

