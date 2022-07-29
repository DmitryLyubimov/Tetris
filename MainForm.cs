/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 28.07.2022
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Game game;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			int nx = 12;
			int ny = 24;
			int cellSize = 20;
			game = new Game(mainPicture, nextFigurePicture, nx, ny, cellSize);
			game.ScoreChanged += this.ScoreChanged;
			game.ShowGrid = false;
			
			var clientWidth = mainPicture.Left + mainPicture.Width + 12;
			var clientHeight = mainPicture.Top + mainPicture.Height + 12;
			this.ClientSize = new Size(clientWidth, clientHeight);
			
			SetColorTheme(ColorTheme.DarkTheme());
			game.StartNewGame();
		}
		
		void SetColorTheme(ColorTheme theme)
		{
			game.Theme = theme;
			this.ForeColor = theme.textColor;
			this.BackColor = theme.backgroundColor;
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Right: game.MoveRight(); break;
				case Keys.Left:  game.MoveLeft(); break;
				case Keys.Down:  game.MoveDown(); break;
				case Keys.Up:	 game.Rotate(); break;
				case Keys.Space: game.DropDown(); break;
				case Keys.F2:	 game.StartNewGame(); break;
			}
		}
		
		void ScoreChanged()
		{
			scoreLabel.Text = game.Score.ToString();
			levelLabel.Text = game.Level.ToString();
		}
			
	}
}
