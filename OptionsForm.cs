/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 29.07.2022
 * Time: 19:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Description of OptionsForm.
	/// </summary>
	public partial class OptionsForm : Form
	{		
		public int boardSize { get; set; }
		
		public OptionsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked) boardSize = 1;
			if (radioButton2.Checked) boardSize = 2;
			if (radioButton3.Checked) boardSize = 3;
		}
	}
}
