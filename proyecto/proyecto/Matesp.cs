/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 29/10/2024
 * Time: 08:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Matesp.
	/// </summary>
	public partial class Matesp : Form
	{
		public Matesp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnvClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtncClick(object sender, EventArgs e)
		{
			double s, n, r;
			s = double.Parse(txts.Text);
			n = double.Parse(txtc.Text);
			r = s/n;
			txtp.Text = r.ToString();
		}
	}
}
