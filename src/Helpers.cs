/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 11.08.2022
 * Time: 2:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Tetris
{
	/// <summary>
	/// Auxiliary functions.
	/// </summary>
	public static class Helpers
	{
		public static string HumanReadTime(int totalSeconds)
		{
			int seconds = totalSeconds % 60;
			int minutes = totalSeconds / 60;
			return String.Format("{0:d2}:{1:d2}", minutes, seconds);
		}
		
		public static string BoardSizeAsString(int boardSizeAsInt)
		{
			string sizeName = "";
			switch (boardSizeAsInt)
			{
				case 1: sizeName = "Small"; break;
				case 2: sizeName = "Medium"; break;
				case 3: sizeName = "Large"; break;
				default: throw new Exception("Wrong board size");
			}
			
			return sizeName;
		}	
	}
}
