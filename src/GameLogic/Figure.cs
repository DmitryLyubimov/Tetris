/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 23.07.2022
 * Time: 22:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tetris
{
	public class Figure
	{
		public int x, y;
		public int[,] shape;
		public int typeId;
		
		public const int ShadowId = 8;
		
		public int nx {
			get { return shape.GetLength(1); }
		}
		
		public int ny {
			get { return shape.GetLength(0); }
		}
		
		public int AbsX(int ix) {
			return x + ix;
		}
		
		public int AbsY(int iy) {
			return y + iy;
		}

		private Figure(int x, int y, int[,] matrix, int id)
		{
			this.x = x;
			this.y = y;
			this.shape = matrix;
			this.typeId = id;
		}

		static readonly int[,] m1 = { {1, 1, 1}, {0, 1, 0} }; // T
		static readonly int[,] m2 = { {1, 1}, {1, 0}, {1, 0} }; // J
		static readonly int[,] m3 = { {1, 1}, {0, 1}, {0, 1} }; // L
		static readonly int[,] m4 = { {1, 0}, {1, 1}, {0, 1} }; // S
		static readonly int[,] m5 = { {0, 1}, {1, 1}, {1, 0} }; // Z
		static readonly int[,] m6 = { {1, 1}, {1, 1} }; // O
		static readonly int[,] m7 = { {0, 1, 0}, {0, 1, 0}, {0, 1, 0}, {0, 1, 0} }; // I
		
		static public Figure CreateFigure(int id)
		{
			int [,] m;
			
			switch (id)
			{
				case 1: m = m1; break;
				case 2: m = m2; break;
				case 3: m = m3; break;
				case 4: m = m4; break;
				case 5: m = m5; break;
				case 6: m = m6; break;
				case 7: m = m7; break;
				default:
					throw new Exception("Wrong figure id");
			}
			
			return new Figure(0, 0, m, id);
		}

		public Figure Copy()
		{
			int[,] matr = (int[,]) this.shape.Clone();
			return new Figure(x, y, matr, typeId);
		}
		
		public Figure Rotate()
		{
			var newFigure = new Figure(x, y, new int[nx, ny], typeId);
			for (int i = 0; i < ny; i++)
				for (int j = 0; j < nx; j++)
					newFigure.shape[j, ny-1-i] = shape[i, j];
			
			return newFigure;
		}
		
		public void Move(int dx, int dy)
		{
			x += dx;
			y += dy;
		}

		public void MoveTo(int newX, int newY)
		{
			x = newX;
			y = newY;
		}
	}
}
