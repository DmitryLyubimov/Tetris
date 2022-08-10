/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 11.08.2022
 * Time: 2:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tetris
{
	/// <summary>
	/// Description of Helpers.
	/// </summary>
	public static class Helpers
	{
		public static string HumanReadTime(int totalSeconds)
		{
			int seconds = totalSeconds % 60;
			int minutes = totalSeconds / 60;
			return String.Format("{0:d2}:{1:d2}", minutes, seconds);
		}
	}
}
