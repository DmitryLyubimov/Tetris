/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 28.07.2022
 * Time: 10:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Tetris
{
	public class Painter
	{
		PictureBox picture;
		Bitmap canvas;
		Graphics graphics;

		int nx;
		int ny;
		int dx;
		int dy;
		int padx;
		int pady;
		
		public ColorTheme Theme { get; set; }
		
		public Graphics Graphics {
			get { return graphics; }
		}

		public int GridWidth { get; set; }
		
		public Painter(int nx, int ny, int dx, int dy, int padx, int pady)
		{		
			Theme = ColorTheme.DefaultTheme();
			
			this.nx = nx;
			this.ny = ny;
			this.dx = dx;
			this.dy = dy;
			this.padx = padx;
			this.pady = pady;
			this.GridWidth = 1;
		}
		
		public void SetPicture(PictureBox pic)
		{
			this.picture = pic;
			this.canvas = new Bitmap(picture.Width, picture.Height);
			this.graphics = Graphics.FromImage(canvas);			
		}
		
		public Size CalcOptimalPictrueSize()
		{
			int w = 2*padx + nx*dx;
			int h = 2*pady + ny*dy;
			return new Size(w, h);
		}
		
		public int GridX(int ix)
		{
			return padx + ix*dx;
		}
		
		public int GridY(int iy)
		{
			return pady + iy*dy;
		}
		
		public void Update()
		{
			picture.Image = canvas;
		}

		public void Clear()
		{
			graphics.Clear(Theme.backgroundColor);
		}
		
		public void DrawFrameAroundPicture()
		{
			var pen = new Pen(Theme.gridColor, GridWidth);
			graphics.DrawRectangle(pen, GridWidth-1, GridWidth-1, canvas.Width-GridWidth, canvas.Height-GridWidth);
		}
		
		public void DrawGrid()
		{
			var gridPen = new Pen(Theme.gridColor, GridWidth);
			
			for (int ix = 0; ix <= nx; ix++)
			{
				int x = GridX(ix);
				int y1 = GridY(0);
				int y2 = GridY(ny);
				graphics.DrawLine(gridPen, x, y1, x, y2);
			}
			
			for (int iy = 0; iy <= ny; iy++)
			{
				int y = GridY(iy);
				int x1 = GridX(0);
				int x2 = GridX(nx);
				graphics.DrawLine(gridPen, x1, y, x2, y);
			}
		}
		
		public void DrawCell(int ix, int iy, int id)
		{
			int x = GridX(ix) + 1;
			int y = GridY(iy) + 1;
			graphics.FillRectangle(Theme.brushes[id], x, y, dx-GridWidth, dy-GridWidth);
		}
		
		public void DrawFigure(Figure figure)
		{		
			for (int x = 0; x < figure.nx; x++)
				for (int y = 0; y < figure.ny; y++)
				{
					if (figure.shape[y,x] > 0)
						DrawCell(figure.AbsX(x), figure.AbsY(y), figure.typeId);
				}		
		}

		public void DrawBoard(Board board)
		{				
			for (int x = 0; x < board.nx; x++)
				for (int y = 0; y < board.ny; y++)
				{
					DrawCell(x, y, board.matrix[y, x]);
				}
		}		
		
	}
}
