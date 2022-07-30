/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 28.07.2022
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris
{
	/// <summary>
	/// Description of Game.
	/// </summary>
	public class Game
	{
		Painter painter;
		Painter nextPainter;
		Board board;
		Figure figure;
		Figure nextFigure;
		Figure shadow;
		Random rng;
		Timer timer;
		Timer gameDurationTimer;
		int gamePlayTime;

		int droppedRows;
		
		enum State { Intro, Running, Paused, GameOver };
		State state;
		
		public event Action ScoreChangedEvent;
		public event Action GameOverEvent;
		public event Action<int> GameDurationTimerEvent;
		
		public bool ShowShadow { get; set; }
		public bool ShowGrid { get; set; }
		public int BoardFilledRows { get; set; }
		public int BoardFreeSpace { get; set; }
		
		public int Score { get; set; }
		public int Lines { get; set; }
		public int Level { get; set; }
		
		public ColorTheme Theme {
			set {
				painter.Theme = value;
				nextPainter.Theme = value;
			}
		}
			
		public Game( PictureBox mainPicture, PictureBox nextPicture,
		             int nx=10, int ny=20, int cellSize=20 )
		{
			AdjustNewPicture(mainPicture, ref painter, nx, ny, cellSize);				
			board = new Board(nx, ny);
			AdjustNewPicture(nextPicture, ref nextPainter, 4, 4, cellSize);
			
			rng = new Random();
			
			timer = new Timer();
			timer.Tick += new System.EventHandler(this.TimerTick);
			gameDurationTimer = new Timer();
			gameDurationTimer.Interval = 1000;
			gameDurationTimer.Tick += new System.EventHandler(this.DurationTick);
			
			ShowShadow = true;
			ShowGrid = true;
			BoardFilledRows = 0;
			BoardFreeSpace = 4;
			state = State.Intro;
		}

		public void StartNewGame()
		{
			droppedRows = 0;
			Level = 1;
			Score = 0;
			state = State.Running;
			
			board.Clear();
			board.FillRandom(BoardFilledRows, BoardFreeSpace, rng);
			
			nextFigure = GetRandomFigure();
			PutNewFigure();
			
			timer.Interval = 1000;
			timer.Start();
			gameDurationTimer.Start();
			gamePlayTime = 0;
			
			Render();
		}
		
		static public void AdjustNewPicture(PictureBox picture, ref Painter painter, int nx, int ny, int cellSize)
		{
			painter = new Painter(nx, ny, cellSize, cellSize, 5, 5);
			picture.Size = painter.CalcOptimalPictrueSize();
			painter.SetPicture(picture);
		}		
	
		public void Render()
		{
			if (state == State.Intro)
			{
				board.FillRandom(board.ny, 1, rng);
				painter.DrawBoard(board);
				painter.Update();
			}
			else
			{
				painter.Clear();
				painter.DrawFrameAroundPicture();
				
				if (ShowGrid)
					painter.DrawGrid();
				
				painter.DrawBoard(board);
				painter.DrawFigure(figure);
				
				if (shadow != null)
					painter.DrawFigure(shadow);
				
				painter.Update();
			}
		}

		public void ShowNextFigure()
		{
			nextPainter.Clear();
			if (nextFigure != null)
				nextPainter.DrawFigure(nextFigure);
			nextPainter.Update();
		}
		
		Figure GetRandomFigure()
		{
			int id = 1 + rng.Next(7);
			var fig = Figure.CreateFigure(id);
			return fig;
		}

		void GameOver()
		{
			if (GameOverEvent != null)
				GameOverEvent();
			timer.Stop();
			gameDurationTimer.Stop();
			state = State.GameOver;
		}
		
		void PutNewFigure()
		{
			figure = nextFigure;
			figure.MoveTo(board.nx / 2, 0);
			
			if (board.ValidFigure(figure) == false) {
				GameOver();
				return;
			}
			
			UpdateShadow();
			
			nextFigure = GetRandomFigure();
			ShowNextFigure();
		}

		void TimerTick(object sender, EventArgs e)
		{
			MoveDown();
		}

		void DurationTick(object sender, EventArgs e)
		{
			gamePlayTime++;
			if (GameDurationTimerEvent != null)
				GameDurationTimerEvent(gamePlayTime);
		}
		
		void UpdateScore(int rows)
		{
			switch (rows)
			{
				case 0: return;
				case 1: Score += 10*Level; break;
				case 2: Score += 30*Level; break;
				case 3: Score += 50*Level; break;
				case 4: Score += 80*Level; break;
			}	
			
			Lines += rows;
			droppedRows += rows;
			if (droppedRows >= 10)
			{
				droppedRows = 0;
				Level++;
				timer.Interval -= 40;
				if (timer.Interval < 60)
					timer.Interval = 60;
			}
			
			if (ScoreChangedEvent != null)
				ScoreChangedEvent();
		}
		
		void UpdateShadow()
		{
			if (!ShowShadow) {
				shadow = null;
				return;
			}
			
			shadow = figure.Copy();
			shadow.typeId = Figure.ShadowId;
			
			int k = 0;
			while (MoveFigure(shadow, 0, 1))
				k++;
			
			// don't show shadow if figure too low
			if (k <= 4)
				shadow = null;
		}
		
		bool MoveFigure(Figure fig, int dx, int dy)
		{
			fig.Move(dx, dy);
			bool success = board.ValidFigure(fig);
			if (!success)
				fig.Move(-dx, -dy);
			
			return success;
		}

		bool RotateFigure()
		{
			var rotatedFigure = figure.Rotate();
			bool success = board.ValidFigure(rotatedFigure);
			if (success)
				figure = rotatedFigure;
			
			return success;
		}
		
		public void MoveRight()
		{
			if (state != State.Running)
				return;
			
			bool success = MoveFigure(figure, 1, 0);
			if (success) {
				UpdateShadow();
				Render();
			}
		}

		public void MoveLeft()
		{
			if (state != State.Running)
				return;

			bool success = MoveFigure(figure, -1, 0);
			if (success) {
				UpdateShadow();
				Render();
			}
				
		}
		
		public void MoveDown()
		{
			if (state != State.Running)
				return;

			bool success = MoveFigure(figure, 0, 1);
			if (success) {
				UpdateShadow();
			}
			else {
				board.Attach(figure);
				int rows = board.DropFullRows();
				UpdateScore(rows);				
				PutNewFigure();
			}
			
			Render();
		}

		public void Rotate()
		{
			if (state != State.Running)
				return;

			bool success = RotateFigure();
			if (success) {
				UpdateShadow();
				Render();
			}
		}

		public void DropDown()
		{
			if (state != State.Running)
				return;

			while (MoveFigure(figure, 0, 1)) { }
			MoveDown();			              
		}

		public void SwapCurrentAndNext()
		{
			if (state != State.Running)
				return;
			
			var t = figure;
			figure = nextFigure;
			nextFigure = t;
			
			figure.MoveTo(board.nx / 2, 0);
			nextFigure.MoveTo(0, 0);
			
			Render();
			ShowNextFigure();
		}
		
		public void Pause()
		{
			if (state == State.Running)
			{
				timer.Stop();
				gameDurationTimer.Stop();
				state = State.Paused;
			}
		}
		
		public void Resume()
		{
			if (state == State.Paused)
			{
				timer.Start();
				gameDurationTimer.Start();
				state = State.Running;
			}
		}
	}
}
