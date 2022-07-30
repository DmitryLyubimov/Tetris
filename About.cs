/*
 * Created by SharpDevelop.
 * User: likehood
 * Date: 30.07.2022
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class AboutForm : Form
	{
		public AboutForm()
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
			this.Close();
		}
	}
}
