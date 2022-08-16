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
		
		List<GameResult> recordsList;
		
		public RecordsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
		}
				
		void ShowRecords(string boardSizeSelector)
		{			
			if (recordsList == null)
				return;
			
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
			var rf = new RecordsFile("results.txt");
			recordsList = rf.Load();
			comboBox1.SelectedIndex = 0;
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
