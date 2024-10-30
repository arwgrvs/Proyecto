/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 04:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Fisica.
	/// </summary>
	public partial class Fisica : Form
	{
		public Fisica()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Fisica2 Fisica2=new Fisica2();
			Fisica2.Show();
		}
	}
}
