/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 11.08.2022
 * Time: 2:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Tetris
{
	public class RecordsFile
	{
		string fileName;
		
		public RecordsFile(string fileName)
		{
			this.fileName = fileName;
		}
		
		public void Save(int score, int playTime, int size)
		{
			using (var file = new StreamWriter(fileName, true))
			{
				var date = DateTime.Now.ToString("d");
				var time = DateTime.Now.ToString("t");
				var playTimeString = Helpers.HumanReadTime(playTime);
				var sizeName = Helpers.BoardSizeAsString(size);
				
				file.WriteLine("{0} {1} {2} {3} {4}", date, time, score, playTimeString, sizeName);
			}
		}
		
		public List<GameResult> Load()
		{
			IEnumerable<string> lines;
			try {
				lines = File.ReadLines(fileName);
			}
			catch (Exception) {
				return null;
			}
			
			var recordsList = new List<GameResult>();
			
			foreach (var line in lines)
			{
				var v = line.Split(' ');
				var date = v[0];
				var time = v[1];
				var score = int.Parse(v[2]);
				var duration = v[3];
				var size = v[4];
				
				var record = new GameResult {
					date = date, time = time, score = score,
					duration = duration, size = size };
				
				recordsList.Add(record);
			}
			
			return recordsList;
		}		
	}
}
