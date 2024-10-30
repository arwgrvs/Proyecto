/*
 * Created by SharpDevelop.
 * User: CC2_PC12
 * Date: 29/10/2024
 * Time: 07:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Fisica2.
	/// </summary>
	public partial class Fisica2 : Form
	{
		public Fisica2()
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
			Fisica3 Fisica3=new Fisica3();
			Fisica3.Show();
		}
	}
}
