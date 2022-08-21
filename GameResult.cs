/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 01.08.2022
 * Time: 15:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tetris
{
	public struct GameResult
	{
		public string date;
		public string time;
		public int score;
		public string duration;
		public string size;
		
		public bool EqualsTo(GameResult r)
		{
			return (date == r.date) &&
				(time == r.time) &&
				(score == r.score) &&
				(duration == r.duration) &&
				(size == r.size);
		}
	}
}
