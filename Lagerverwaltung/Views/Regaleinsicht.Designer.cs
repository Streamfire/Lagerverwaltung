namespace Lagerverwaltung.Views
{
	partial class Regaleinsicht
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
<<<<<<< HEAD
            this.SuspendLayout();
            // 
            // Regaleinsicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Regaleinsicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regaleinsicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegalFormClosing);
            this.ResumeLayout(false);
=======
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(12, 41);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(894, 405);
			this.dataGridView1.TabIndex = 0;
			// 
			// A
			// 
			this.A.HeaderText = "A";
			this.A.Name = "A";
			// 
			// B
			// 
			this.B.HeaderText = "B";
			this.B.Name = "B";
			// 
			// C
			// 
			this.C.HeaderText = "C";
			this.C.Name = "C";
			// 
			// D
			// 
			this.D.HeaderText = "D";
			this.D.Name = "D";
			// 
			// E
			// 
			this.E.HeaderText = "E";
			this.E.Name = "E";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(594, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ansicht Regal ";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Regalitem"});
			this.comboBox1.Location = new System.Drawing.Point(712, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(194, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Regalitem"});
			this.comboBox2.Location = new System.Drawing.Point(395, 12);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(194, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(339, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lager";
			// 
			// Regaleinsicht
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 458);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Regaleinsicht";
			this.Text = "Regaleinsicht";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegalFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
>>>>>>> 676a6dcf445f4153e76d7f7e45cd25419fe80c12

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn A;
		private System.Windows.Forms.DataGridViewTextBoxColumn B;
		private System.Windows.Forms.DataGridViewTextBoxColumn C;
		private System.Windows.Forms.DataGridViewTextBoxColumn D;
		private System.Windows.Forms.DataGridViewTextBoxColumn E;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
	}
}