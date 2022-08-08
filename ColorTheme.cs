/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 23.07.2022
 * Time: 23:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Tetris
{
	/// <summary>
	/// Description of ColorTheme.
	/// </summary>
	public class ColorTheme
	{
		public Color backgroundColor;
		public Color textColor;
		public Color gridColor;
		public Brush[] brushes;

		public static ColorTheme DefaultTheme()
		{
			return Light();
		}
				
		public static ColorTheme Light()
		{
			var theme = new ColorTheme();
			
			theme.backgroundColor = Color.FromArgb(250, 250, 230);
			theme.textColor = Color.Black;
			theme.gridColor = Color.FromArgb(175, 175, 175);
			
			theme.brushes = new Brush[9];
			theme.brushes[0] = new SolidBrush(theme.backgroundColor);
			theme.brushes[1] = Brushes.DeepPink;
			theme.brushes[2] = Brushes.OrangeRed;
			theme.brushes[3] = Brushes.Brown;
			theme.brushes[4] = Brushes.LimeGreen;
			theme.brushes[5] = Brushes.Purple;
			theme.brushes[6] = Brushes.RoyalBlue;
			theme.brushes[7] = Brushes.Orange;
			theme.brushes[8] = Brushes.DarkGray; // shadow
			
			return theme;
		}
		
		public static ColorTheme Dark()
		{
			var theme = new ColorTheme();
			
			theme.backgroundColor = Color.FromArgb(45, 45, 45);
			theme.textColor = Color.LightGray;
			theme.gridColor = Color.FromArgb(85, 85, 85);
			
			theme.brushes = new Brush[9];
			theme.brushes[0] = new SolidBrush(theme.backgroundColor);
			theme.brushes[1] = Brushes.DeepPink;
			theme.brushes[2] = Brushes.OrangeRed;
			theme.brushes[3] = Brushes.Brown;
			theme.brushes[4] = Brushes.LawnGreen;
			theme.brushes[5] = Brushes.Green;
			theme.brushes[6] = Brushes.DodgerBlue;
			theme.brushes[7] = Brushes.Gold;
			theme.brushes[8] = Brushes.DarkGray; // shadow			
			
			return theme;
		}		
	}
}
