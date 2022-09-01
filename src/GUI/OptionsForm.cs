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
	public partial class OptionsForm : Form
	{		
		public int BoardSize { get; set; }
		public int ColorTheme { get; set; }
		public int CellVisualStyle { get; set; }
		
		public bool ShowGrid {
			get { return checkBox1.Checked; }
		}

		public bool ShowShadow {
			get { return checkBox2.Checked; }
		}
		
		public int FilledRows {
			get { return (int) numericUpDown1.Value; }
		}
		
		Painter painter;
		Figure figure;
		
		public OptionsForm()
		{
			InitializeComponent();
			
			painter = new Painter(3, 3, 18, 18, 3, 3);
			painter.SetPicture(pictureBox1);
			figure = Figure.CreateFigure(4);
			DrawPreview(1);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked) BoardSize = 1;
			if (radioButton2.Checked) BoardSize = 2;
			if (radioButton3.Checked) BoardSize = 3;
			
			if (radioButton4.Checked) ColorTheme = 1;
			if (radioButton5.Checked) ColorTheme = 2;

			if (radioButton6.Checked) CellVisualStyle = 1;
			if (radioButton7.Checked) CellVisualStyle = 2;
			if (radioButton8.Checked) CellVisualStyle = 3;
			if (radioButton9.Checked) CellVisualStyle = 4;
		}
		
		void DrawPreview(int style)
		{
			painter.SetVisualStyle(style);
			painter.Clear();
			painter.DrawFigure(figure);
			painter.Update();
		}
		
		void RadioButton6CheckedChanged(object sender, EventArgs e)
		{
			DrawPreview(1);
		}
		void RadioButton7CheckedChanged(object sender, EventArgs e)
		{
			DrawPreview(2);
		}
		void RadioButton8CheckedChanged(object sender, EventArgs e)
		{
			DrawPreview(3);
		}
		void RadioButton9CheckedChanged(object sender, EventArgs e)
		{
			DrawPreview(4);
		}
	}
}
