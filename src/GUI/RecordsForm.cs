/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 01.08.2022
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
	public partial class RecordsForm : Form
	{
		List<GameResult> recordsList;
		public bool HighlightLastResult { get; set; }
		
		public RecordsForm()
		{
			InitializeComponent();
			
			HighlightLastResult = false;
			var recordsFile = new RecordsFile("results.txt");
			recordsList = recordsFile.Load();
			comboBox1.SelectedIndex = 0;			
		}
				
		void ShowRecords(string boardSizeSelector)
		{			
			if (recordsList == null)
				return;
			
			GameResult lastResult = recordsList.Last();
			
			IEnumerable<GameResult> sortedList;
			if (boardSizeSelector == "All")
				sortedList = recordsList.OrderByDescending(x => x.score).Take(30);
			else
			{
				sortedList = recordsList.
					Where(x => x.size == boardSizeSelector).
					OrderByDescending(x => x.score).Take(20);
			}
			
			listView1.Items.Clear();
			int rank = 1;
			
			foreach (var result in sortedList)
			{
				ListViewItem lvi = new ListViewItem(rank.ToString());
				lvi.UseItemStyleForSubItems = true;
				lvi.SubItems.Add( result.score.ToString() );
				lvi.SubItems.Add( result.duration );
				lvi.SubItems.Add( result.size );
				lvi.SubItems.Add( result.date + " " + result.time );
				listView1.Items.Add(lvi);
							
				if (HighlightLastResult && result.EqualsTo(lastResult)) {
					lvi.ForeColor = Color.Yellow;
					lvi.BackColor = Color.DarkBlue;
				}
				
				rank++;				
			}
		}
		
		public void SelectGameSize(int size)
		{
			comboBox1.SelectedIndex = size;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string boardSizeSelector = (string) comboBox1.SelectedItem;
			ShowRecords(boardSizeSelector);			
		}
	}
}
