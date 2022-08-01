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
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
	/// <summary>
	/// Description of RecordsForm.
	/// </summary>
	public partial class RecordsForm : Form
	{
		public RecordsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LoadRecordsFile()
		{
			IEnumerable<string> lines;
			try {
				lines = File.ReadLines("results.txt");
			}
			catch (Exception) {
				return;
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
			
			var sortedList = recordsList.OrderByDescending(x => x.score);
			
			int rank = 1;
			foreach (var record in sortedList)
			{
				ListViewItem lvi = new ListViewItem(rank.ToString());
				lvi.SubItems.Add( new ListViewItem.ListViewSubItem(lvi, record.score.ToString()) );
				lvi.SubItems.Add( new ListViewItem.ListViewSubItem(lvi, record.duration) );
				lvi.SubItems.Add( new ListViewItem.ListViewSubItem(lvi, record.size) );
				lvi.SubItems.Add( new ListViewItem.ListViewSubItem(lvi, record.date) );
				lvi.SubItems.Add( new ListViewItem.ListViewSubItem(lvi, record.time) );
				listView1.Items.Add(lvi);
				
				rank++;				
			}
		}
		
		void RecordsFormLoad(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
			LoadRecordsFile();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
