﻿/*
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
		bool paused;
		OptionsForm optionsForm;
		
		int boardSize = 1;
		int nx = 10, ny = 20;
		int cellSize = 20;
		
		bool showGrid = true;
		bool showShadow = true;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			InitGame();
			
			game.Render();
		}
		
		void InitGame()
		{
			game = new Game(mainPicture, nextFigurePicture, nx, ny, cellSize);
			game.ScoreChangedEvent += this.ScoreChanged;
			game.GameOverEvent += this.GameOver;
			game.ShowGrid = this.showGrid;
			game.ShowShadow = this.showShadow;

			var clientWidth = mainPicture.Left + mainPicture.Width + 12;
			var clientHeight = mainPicture.Top + mainPicture.Height + 12;
			this.ClientSize = new Size(clientWidth, clientHeight);

			infoLabel.Text = "";
			SetColorTheme(ColorTheme.Light());
		}
		
		void StartNewGame()
		{
			infoLabel.Text = "";
			paused = false;
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
				case Keys.Q:
				case Keys.C:	 game.SwapCurrentAndNext(); break;
				case Keys.F2:	 this.StartNewGame(); break;
				case Keys.P:	 this.Pause(); break;
			}
		}

		void Pause()
		{
			if (!paused)
			{
				game.Pause();
				infoLabel.Text = "   P A U S E";
				paused = true;
			}
			else
			{
				game.Resume();
				infoLabel.Text = "";
				paused = false;
			}
		}
		
		void ScoreChanged()
		{
			scoreLabel.Text = game.Score.ToString();
			linesLabel.Text = game.Lines.ToString();
			levelLabel.Text = game.Level.ToString();
		}
		
		void GameOver()
		{
			infoLabel.Text = "GAME OVER";
		}
		
		void OptionsToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (optionsForm == null)
				optionsForm = new OptionsForm();
			
			var result = optionsForm.ShowDialog();
			if (result == DialogResult.Cancel)
				return;
			
			switch (optionsForm.BoardSize)
			{
				case 1:
					nx = 10; ny = 20; cellSize = 20;
					break;
				case 2:
					nx = 12; ny = 24; cellSize = 20;
					break;
				case 3:
					nx = 15; ny = 30; cellSize = 18;
					break;
			}
			
			if (optionsForm.BoardSize != this.boardSize)
			{
				game.Pause();
				InitGame();
			}
			
			this.boardSize = optionsForm.BoardSize;
			
			if (optionsForm.ColorTheme == 1)
				SetColorTheme(ColorTheme.Light());
			else
				SetColorTheme(ColorTheme.Dark());
			
			game.ShowGrid = optionsForm.ShowGrid;
			game.ShowShadow = optionsForm.ShowShadow;
			game.BoardFilledRows = optionsForm.FilledRows;
			game.BoardFreeSpace = optionsForm.FreeSpace;
			
			game.Render();
			game.ShowNextFigure();
			
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void NewGameToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.StartNewGame();
		}
		void PauseResumeToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Pause();
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			var form = new AboutForm();
			form.ShowDialog();
		}
	}
}
