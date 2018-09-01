namespace Shutdown {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tabCtrl = new System.Windows.Forms.TabControl();
			this.tab1 = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.specifiedTime = new System.Windows.Forms.DateTimePicker();
			this.tab2 = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.countDownHour = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.countDownMinute = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.rbHibernate = new System.Windows.Forms.RadioButton();
			this.rbShutdown = new System.Windows.Forms.RadioButton();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabCtrl.SuspendLayout();
			this.tab1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tab2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.countDownHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.countDownMinute)).BeginInit();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
			this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(394, 133);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(394, 180);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(394, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			// 
			// tsslStatus
			// 
			this.tsslStatus.ForeColor = System.Drawing.Color.Red;
			this.tsslStatus.Name = "tsslStatus";
			this.tsslStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tabCtrl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 133);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// tabCtrl
			// 
			this.tabCtrl.Controls.Add(this.tab1);
			this.tabCtrl.Controls.Add(this.tab2);
			this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtrl.Location = new System.Drawing.Point(4, 5);
			this.tabCtrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabCtrl.Name = "tabCtrl";
			this.tabCtrl.SelectedIndex = 0;
			this.tabCtrl.Size = new System.Drawing.Size(386, 90);
			this.tabCtrl.TabIndex = 0;
			// 
			// tab1
			// 
			this.tab1.Controls.Add(this.flowLayoutPanel1);
			this.tab1.Location = new System.Drawing.Point(4, 29);
			this.tab1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tab1.Name = "tab1";
			this.tab1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tab1.Size = new System.Drawing.Size(378, 52);
			this.tab1.TabIndex = 0;
			this.tab1.Text = "Specific Time";
			this.tab1.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.specifiedTime);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 5);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 42);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Time";
			// 
			// specifiedTime
			// 
			this.specifiedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.specifiedTime.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
			this.specifiedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.specifiedTime.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.specifiedTime.Location = new System.Drawing.Point(55, 5);
			this.specifiedTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.specifiedTime.Name = "specifiedTime";
			this.specifiedTime.ShowUpDown = true;
			this.specifiedTime.Size = new System.Drawing.Size(245, 26);
			this.specifiedTime.TabIndex = 4;
			// 
			// tab2
			// 
			this.tab2.Controls.Add(this.flowLayoutPanel3);
			this.tab2.Location = new System.Drawing.Point(4, 29);
			this.tab2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tab2.Name = "tab2";
			this.tab2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tab2.Size = new System.Drawing.Size(378, 57);
			this.tab2.TabIndex = 1;
			this.tab2.Text = "Count Down";
			this.tab2.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.label2);
			this.flowLayoutPanel3.Controls.Add(this.countDownHour);
			this.flowLayoutPanel3.Controls.Add(this.label3);
			this.flowLayoutPanel3.Controls.Add(this.countDownMinute);
			this.flowLayoutPanel3.Controls.Add(this.label4);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 5);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(370, 47);
			this.flowLayoutPanel3.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 8);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Count down";
			// 
			// countDownHour
			// 
			this.countDownHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.countDownHour.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.countDownHour.Location = new System.Drawing.Point(106, 5);
			this.countDownHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.countDownHour.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.countDownHour.Name = "countDownHour";
			this.countDownHour.Size = new System.Drawing.Size(60, 26);
			this.countDownHour.TabIndex = 10;
			this.countDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(174, 8);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Hours";
			// 
			// countDownMinute
			// 
			this.countDownMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.countDownMinute.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.countDownMinute.Location = new System.Drawing.Point(234, 5);
			this.countDownMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.countDownMinute.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.countDownMinute.Name = "countDownMinute";
			this.countDownMinute.Size = new System.Drawing.Size(60, 26);
			this.countDownMinute.TabIndex = 9;
			this.countDownMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(302, 8);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Mins";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.rbHibernate);
			this.flowLayoutPanel2.Controls.Add(this.rbShutdown);
			this.flowLayoutPanel2.Controls.Add(this.btnConfirm);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 103);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(388, 33);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// rbHibernate
			// 
			this.rbHibernate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.rbHibernate.AutoSize = true;
			this.rbHibernate.Checked = true;
			this.rbHibernate.Location = new System.Drawing.Point(4, 10);
			this.rbHibernate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbHibernate.Name = "rbHibernate";
			this.rbHibernate.Size = new System.Drawing.Size(104, 24);
			this.rbHibernate.TabIndex = 3;
			this.rbHibernate.TabStop = true;
			this.rbHibernate.Text = "Hibernate";
			this.rbHibernate.UseVisualStyleBackColor = true;
			// 
			// rbShutdown
			// 
			this.rbShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.rbShutdown.AutoSize = true;
			this.rbShutdown.Location = new System.Drawing.Point(116, 10);
			this.rbShutdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbShutdown.Name = "rbShutdown";
			this.rbShutdown.Size = new System.Drawing.Size(106, 24);
			this.rbShutdown.TabIndex = 4;
			this.rbShutdown.Text = "Shutdown";
			this.rbShutdown.UseVisualStyleBackColor = true;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConfirm.Location = new System.Drawing.Point(230, 5);
			this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(58, 35);
			this.btnConfirm.TabIndex = 5;
			this.btnConfirm.Text = "OK";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 180);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shutdown";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabCtrl.ResumeLayout(false);
			this.tab1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tab2.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.countDownHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.countDownMinute)).EndInit();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.TabControl tabCtrl;
		private System.Windows.Forms.TabPage tab1;
		private System.Windows.Forms.TabPage tab2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker specifiedTime;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown countDownHour;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown countDownMinute;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.RadioButton rbHibernate;
		private System.Windows.Forms.RadioButton rbShutdown;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
	}
}

