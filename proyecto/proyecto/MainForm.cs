/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 03:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			About About=new About();
			About.Show();
		}
		
		void ComboBox3SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox3.Text=="Matematicas")
			{
				Mates Mates=new Mates();
				Mates.Show();
			}
			else if(comboBox3.Text=="Ingles")
			{
				Ingles Ingles=new Ingles();
				Ingles.Show();
			}
			else if(comboBox3.Text=="Humanidades")
			{
				Humani Humani=new Humani();
				Humani.Show();
			}
			else if(comboBox3.Text=="Ecosistemas")
			{
				Eco Eco=new Eco();
				Eco.Show();
			}
			else if(comboBox3.Text=="Fisica")
			{
				Fisica Fisica=new Fisica();
				Fisica.Show();
			}
		}
	}
}
