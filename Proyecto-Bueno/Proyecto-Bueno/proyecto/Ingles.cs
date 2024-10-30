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
using System.Speech.Synthesis;

namespace proyecto
{
	/// <summary>
	/// Description of Ingles.
	/// </summary>
	public partial class Ingles : Form
	{
		//numero de verbos
			int n = 14;
			//verbos
			
			
			String[] verb_present = {"Accept", "Answer", "Arrive", "Ask",
				"Belong", "Change", "Clean", "Close", 
				"Consider", "Cook", "Count", "Dance", 
				"Go", "Take", };
			String[] verb_tense = {"Accepted", "Answered", "Arrived", "Asked", 
			"Belonged", "Changed", "Cleaned", "Closed", 
			"Considered", "Cooked", "Counted", "Danced",
			"Went", "Took"};
			String[] verb_participle = {"Accepted", "Answered", "Arrived", "Asked",
					"Belonged", "Changed", "Cleaned", "Closed", 
					"Considered", "Cooked", "Counted", "Danced",
				"Gone", "Taken"};
			String[] verb_gerund = {"Accepting", "Answering", "Arriving", "Asking",
			"Belonging", "Changing", "Cleaning", "Closing", 
			"Considering", "Cooking", "Counting", "Dancing",
			"Going", "Taking"};
			//Declarar i aniadir oqziones a somvobos
			
		//Declarar i aniadir oqziones a somvobos
			private String[] verb_spanish = {
			"Aceptar", "Contestar", "Llegar", "Preguntar",
			"Pertenecer", "Cambiar", "Limpiar", "Cerrar", 
			"Considerar", "Cocinar", "Contar", "Bailar", 
			"Ir", "Tomar"};
		public Ingles()
		{
			
			 
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
			
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					unos = verb_present[i];
				}
			}
			SpeechSynthesizer uno = new SpeechSynthesizer();
			uno.SpeakAsync(unos);
			//obtener y saber cual es de "numero"
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			//obtener y saber cual es de "numero"
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					label5.Text = verb_present[i];
					label6.Text = verb_tense[i];
					label7.Text = verb_participle[i];
					label8.Text = verb_gerund[i];
				}
			}
			//para evitar que no ponga nada jijijiji, soy tan listo
			panel1.Visible = true;
		}
		
		void InglesLoad(object sender, EventArgs e)
		{
			comboBox1.Items.AddRange(verb_spanish);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					unos = verb_tense[i];
				}
			}
			SpeechSynthesizer uno = new SpeechSynthesizer();
			uno.SpeakAsync(unos);
			//obtener y saber cual es de "numero"
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					unos = verb_participle[i];
				}
			}
			SpeechSynthesizer uno = new SpeechSynthesizer();
			uno.SpeakAsync(unos);
			//obtener y saber cual es de "numero"
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
			{
				unos = verb_gerund[i];
			}
				
			}
			
			SpeechSynthesizer uno = new SpeechSynthesizer();
			//obtener y saber cual es de "numero"
			uno.SpeakAsync(unos);
		}
	}
}
