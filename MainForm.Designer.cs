/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 28.07.2022
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tetris
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox mainPicture;
		private System.Windows.Forms.Label levelLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.PictureBox nextFigurePicture;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.ToolStripMenuItem pauseResumeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boardSizeToolStripMenuItem;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.infoLabel = new System.Windows.Forms.Label();
			this.nextFigurePicture = new System.Windows.Forms.PictureBox();
			this.levelLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mainPicture = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pauseResumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boardSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nextFigurePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.infoLabel);
			this.panel1.Controls.Add(this.nextFigurePicture);
			this.panel1.Controls.Add(this.levelLabel);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.scoreLabel);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 432);
			this.panel1.TabIndex = 0;
			// 
			// infoLabel
			// 
			this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.infoLabel.Location = new System.Drawing.Point(41, 159);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(131, 23);
			this.infoLabel.TabIndex = 8;
			this.infoLabel.Text = "Info label";
			// 
			// nextFigurePicture
			// 
			this.nextFigurePicture.Location = new System.Drawing.Point(56, 221);
			this.nextFigurePicture.Name = "nextFigurePicture";
			this.nextFigurePicture.Size = new System.Drawing.Size(100, 100);
			this.nextFigurePicture.TabIndex = 7;
			this.nextFigurePicture.TabStop = false;
			// 
			// levelLabel
			// 
			this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.levelLabel.Location = new System.Drawing.Point(74, 101);
			this.levelLabel.Name = "levelLabel";
			this.levelLabel.Size = new System.Drawing.Size(82, 23);
			this.levelLabel.TabIndex = 6;
			this.levelLabel.Text = "1";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(74, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "0";
			// 
			// scoreLabel
			// 
			this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.scoreLabel.Location = new System.Drawing.Point(74, 35);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(82, 23);
			this.scoreLabel.TabIndex = 4;
			this.scoreLabel.Text = "0";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(3, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Next";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Lines";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Level";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Score";
			// 
			// mainPicture
			// 
			this.mainPicture.Location = new System.Drawing.Point(222, 38);
			this.mainPicture.Name = "mainPicture";
			this.mainPicture.Size = new System.Drawing.Size(247, 432);
			this.mainPicture.TabIndex = 1;
			this.mainPicture.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(481, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newGameToolStripMenuItem,
			this.pauseResumeToolStripMenuItem,
			this.boardSizeToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			// 
			// pauseResumeToolStripMenuItem
			// 
			this.pauseResumeToolStripMenuItem.Name = "pauseResumeToolStripMenuItem";
			this.pauseResumeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.pauseResumeToolStripMenuItem.Text = "Pause";
			// 
			// boardSizeToolStripMenuItem
			// 
			this.boardSizeToolStripMenuItem.Name = "boardSizeToolStripMenuItem";
			this.boardSizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.boardSizeToolStripMenuItem.Text = "Options...";
			this.boardSizeToolStripMenuItem.Click += new System.EventHandler(this.BoardSizeToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(481, 482);
			this.Controls.Add(this.mainPicture);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Tetris";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nextFigurePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
