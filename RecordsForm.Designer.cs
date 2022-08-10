/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 01.08.2022
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tetris
{
	partial class RecordsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnRank;
		private System.Windows.Forms.ColumnHeader columnDate;
		private System.Windows.Forms.ColumnHeader columnScore;
		private System.Windows.Forms.ColumnHeader columnDuration;
		private System.Windows.Forms.ColumnHeader columnBoardSize;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader columnTime;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnRank = new System.Windows.Forms.ColumnHeader();
			this.columnScore = new System.Windows.Forms.ColumnHeader();
			this.columnDuration = new System.Windows.Forms.ColumnHeader();
			this.columnBoardSize = new System.Windows.Forms.ColumnHeader();
			this.columnDate = new System.Windows.Forms.ColumnHeader();
			this.columnTime = new System.Windows.Forms.ColumnHeader();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnRank,
			this.columnScore,
			this.columnDuration,
			this.columnBoardSize,
			this.columnDate,
			this.columnTime});
			this.listView1.Location = new System.Drawing.Point(12, 50);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(407, 250);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnRank
			// 
			this.columnRank.Text = "#";
			this.columnRank.Width = 35;
			// 
			// columnScore
			// 
			this.columnScore.Text = "Score";
			this.columnScore.Width = 68;
			// 
			// columnDuration
			// 
			this.columnDuration.Text = "Duration";
			this.columnDuration.Width = 70;
			// 
			// columnBoardSize
			// 
			this.columnBoardSize.Text = "Board size";
			this.columnBoardSize.Width = 74;
			// 
			// columnDate
			// 
			this.columnDate.Text = "Date";
			this.columnDate.Width = 71;
			// 
			// columnTime
			// 
			this.columnTime.Text = "Time";
			this.columnTime.Width = 65;
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "0";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"All",
			"Small",
			"Medium",
			"Large"});
			this.comboBox1.Location = new System.Drawing.Point(77, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Board size";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(177, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// RecordsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 360);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.listView1);
			this.MaximizeBox = false;
			this.Name = "RecordsForm";
			this.Text = "Best results";
			this.Load += new System.EventHandler(this.RecordsFormLoad);
			this.ResumeLayout(false);

		}
	}
}
