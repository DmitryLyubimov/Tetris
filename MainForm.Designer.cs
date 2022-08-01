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
		private System.Windows.Forms.Label linesLabel;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.PictureBox nextFigurePicture;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.ToolStripMenuItem pauseResumeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Label elapsedTimeLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem bestResultsToolStripMenuItem1;
		
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
			this.elapsedTimeLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.infoLabel = new System.Windows.Forms.Label();
			this.nextFigurePicture = new System.Windows.Forms.PictureBox();
			this.levelLabel = new System.Windows.Forms.Label();
			this.linesLabel = new System.Windows.Forms.Label();
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
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bestResultsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nextFigurePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.elapsedTimeLabel);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.infoLabel);
			this.panel1.Controls.Add(this.nextFigurePicture);
			this.panel1.Controls.Add(this.levelLabel);
			this.panel1.Controls.Add(this.linesLabel);
			this.panel1.Controls.Add(this.scoreLabel);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(169, 432);
			this.panel1.TabIndex = 0;
			// 
			// elapsedTimeLabel
			// 
			this.elapsedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.elapsedTimeLabel.Location = new System.Drawing.Point(74, 357);
			this.elapsedTimeLabel.Name = "elapsedTimeLabel";
			this.elapsedTimeLabel.Size = new System.Drawing.Size(82, 23);
			this.elapsedTimeLabel.TabIndex = 10;
			this.elapsedTimeLabel.Text = "0";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 357);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Time";
			// 
			// infoLabel
			// 
			this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.infoLabel.Location = new System.Drawing.Point(37, 159);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(115, 23);
			this.infoLabel.TabIndex = 8;
			this.infoLabel.Text = "Info label";
			// 
			// nextFigurePicture
			// 
			this.nextFigurePicture.Location = new System.Drawing.Point(74, 221);
			this.nextFigurePicture.Name = "nextFigurePicture";
			this.nextFigurePicture.Size = new System.Drawing.Size(82, 87);
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
			// linesLabel
			// 
			this.linesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linesLabel.Location = new System.Drawing.Point(74, 68);
			this.linesLabel.Name = "linesLabel";
			this.linesLabel.Size = new System.Drawing.Size(82, 23);
			this.linesLabel.TabIndex = 5;
			this.linesLabel.Text = "0";
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
			this.label4.Location = new System.Drawing.Point(3, 245);
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
			this.mainPicture.Location = new System.Drawing.Point(190, 38);
			this.mainPicture.Name = "mainPicture";
			this.mainPicture.Size = new System.Drawing.Size(279, 432);
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
			this.optionsToolStripMenuItem,
			this.aboutToolStripMenuItem,
			this.bestResultsToolStripMenuItem1,
			this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.ShortcutKeyDisplayString = "F2";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItemClick);
			// 
			// pauseResumeToolStripMenuItem
			// 
			this.pauseResumeToolStripMenuItem.Name = "pauseResumeToolStripMenuItem";
			this.pauseResumeToolStripMenuItem.ShortcutKeyDisplayString = "P";
			this.pauseResumeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.pauseResumeToolStripMenuItem.Text = "Pause/resume";
			this.pauseResumeToolStripMenuItem.Click += new System.EventHandler(this.PauseResumeToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.optionsToolStripMenuItem.Text = "Options...";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// bestResultsToolStripMenuItem1
			// 
			this.bestResultsToolStripMenuItem1.Name = "bestResultsToolStripMenuItem1";
			this.bestResultsToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
			this.bestResultsToolStripMenuItem1.Text = "Best results...";
			this.bestResultsToolStripMenuItem1.Click += new System.EventHandler(this.BestResultsToolStripMenuItem1Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
