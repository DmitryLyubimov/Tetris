/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 24.07.2022
 * Time: 10:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tetris
{
	public class Board
	{
		public int[,] matrix;
		
		public Board(int nx, int ny)
		{
			matrix = new int[ny, nx];
		}
		
		public int nx {
			get { return matrix.GetLength(1); }
		}
		
		public int ny {
			get { return matrix.GetLength(0); }
		}
		
		public bool OutOfBoard(int x, int y)
		{
			if (x < 0 || x >= nx) return true;
			if (y < 0 || y >= ny) return true;
			return false;			
		}
		
		public bool OutOfBoard(Figure figure)
		{
			for (int ix = 0; ix < figure.nx; ix++)
				for (int iy = 0; iy < figure.ny; iy++)
				{
					if (figure.shape[iy, ix] > 0)
					{
						if ( OutOfBoard(figure.AbsX(ix), figure.AbsY(iy)) )
							return true;
					}
				}
			
			return false;
		}
		
		public bool Overlaps(Figure figure)
		{
			for (int ix = 0; ix < figure.nx; ix++)
				for (int iy = 0; iy < figure.ny; iy++)
				{
					if (figure.shape[iy, ix] > 0 && matrix[figure.AbsY(iy), figure.AbsX(ix)] > 0)
						return true;
				}
			
			return false;
		}
		
		public bool ValidFigure(Figure figure)
		{
			return ! OutOfBoard(figure) && ! Overlaps(figure);
		}
		
		public void Attach(Figure figure)
		{
			for (int ix = 0; ix < figure.nx; ix++)
				for (int iy = 0; iy < figure.ny; iy++)
				{
					if (figure.shape[iy, ix] > 0)
					{
						int x = figure.x + ix;
						int y = figure.y + iy;
						matrix[y, x] = figure.typeId;
					}
				}
		}
		
		public int DropFullRows()
		{
			int x;
			int drops = 0;
			
			for (int y = 0; y < ny; y++)
			{
				bool fullRow = true;
				
				for (x = 0; x < nx; x++)
				{
					if (matrix[y, x] == 0) {
						fullRow = false;
						break;
					}
				}
				
				if (fullRow)
				{
					++drops;
					
					for (int z = y; z >= 1; z--)
						for (x = 0; x < nx; x++)
							matrix[z, x] = matrix[z-1, x];
				}
			}
			
			return drops;
		}
		
		public void Clear()
		{
			for (int x = 0; x < nx; x++)
				for (int y = 0; y < ny; y++)
					matrix[y, x] = 0;
		}
		
		public void FillRandom(int filledRows, int freeSpace, Random rng)
		{
			for (int k = 0; k < filledRows; k++)
			{
				int y = ny-1-k;
				for (int x = 0; x < nx; x++)
				{
					int z = rng.Next(12);
					if (z <= freeSpace) matrix[y, x] = 0;
					else {
						int id = rng.Next(7) + 1;
						matrix[y, x] = id;
					}
				}
			}
		}
	}
}
