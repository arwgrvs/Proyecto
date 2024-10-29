/*
 * Created by SharpDevelop.
 * User: CC2_PC12
 * Date: 29/10/2024
 * Time: 07:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Fisica3.
	/// </summary>
	public partial class Fisica3 : Form
	{
		public Fisica3()
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
			Fisica4 Fisica4=new Fisica4();
			Fisica4.Show();
		}
	}
}
