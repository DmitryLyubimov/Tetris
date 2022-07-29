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
		bool gameOver;
		int droppedRows;
		
		public event Action ScoreChanged;
		
		public bool ShowShadow { get; set; }
		public bool ShowGrid { get; set; }
		
		public int Score { get; set; }
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
			
			ShowShadow = true;
			ShowGrid = true;
		}

		public void StartNewGame()
		{
			gameOver = false;
			
			droppedRows = 0;
			Level = 1;
			Score = 0;
			
			board.Clear();
			
			nextFigure = GetRandomFigure();
			PutNewFigure();
			
			timer.Interval = 800;
			timer.Start();
			
			RedrawGameFrame();
		}
		
		static public void AdjustNewPicture(PictureBox picture, ref Painter painter, int nx, int ny, int cellSize)
		{
			painter = new Painter(nx, ny, cellSize, cellSize, 5, 5);
			picture.Size = painter.CalcOptimalPictrueSize();
			painter.SetPicture(picture);
		}		
	
		public void RedrawGameFrame()
		{
			if (gameOver)
			{
				var font = new Font(FontFamily.GenericSansSerif, 24);
				var brush = new SolidBrush(painter.Theme.textColor);
				painter.Graphics.DrawString("Game over", font, brush, 30, 100);
				painter.Update();
				return;
			}
			
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

		void ShowNextFigure()
		{
			nextPainter.Clear();
			nextPainter.DrawFigure(nextFigure);
			nextPainter.Update();
		}
		
		Figure GetRandomFigure()
		{
			int id = 1 + rng.Next(7);
			var fig = Figure.CreateFigure(id);
			return fig;
		}
	
		void PutNewFigure()
		{
			figure = nextFigure;
			figure.MoveTo(board.nx / 2, 0);
			
			if (board.ValidFigure(figure) == false) {
				gameOver = true;
				timer.Stop();
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
			
			droppedRows += rows;
			if (droppedRows >= 10)
			{
				droppedRows = 0;
				Level++;
				timer.Interval -= 40;
				if (timer.Interval < 60)
					timer.Interval = 60;
			}
			
			if (ScoreChanged != null)
				ScoreChanged();
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
			bool success = MoveFigure(figure, 1, 0);
			if (success) {
				UpdateShadow();
				RedrawGameFrame();
			}
		}

		public void MoveLeft()
		{
			bool success = MoveFigure(figure, -1, 0);
			if (success) {
				UpdateShadow();
				RedrawGameFrame();
			}
				
		}
		
		public void MoveDown()
		{
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
			
			RedrawGameFrame();
		}

		public void Rotate()
		{
			bool success = RotateFigure();
			if (success) {
				UpdateShadow();
				RedrawGameFrame();
			}
		}

		public void DropDown()
		{
			while (MoveFigure(figure, 0, 1)) { }
			MoveDown();			              
		}
	}
}
