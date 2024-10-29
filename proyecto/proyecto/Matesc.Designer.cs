/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 29/10/2024
 * Time: 07:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Matesc
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"SALON",
									"ALCALA LARA EDGAR",
									"ALCANTAR GONZALEZ MARTHA MELISA",
									"ALMANZA LOPEZ DAVID",
									"ALVAREZ CEJA JORGE LUIS",
									"BALLESTEROS DIAZ RAMSES",
									"BARRIENTOS VITAL ANGEL DAVID",
									"CALDERON MORA JUAN EMILIANO",
									"CAMARENA RAMIREZ JOSE MIGUEL",
									"CASTAÑEDA MARTINEZ JUAN ANTONIO",
									"CHAVEZ SAMANO CRISTOPHER ALEJANDRO",
									"DIEGO CHACON DULCE MARIA",
									"FERREYRA GUZMAN AMERICA JANETH",
									"FUENTES PEREZ DIEGO JAVIER",
									"GARCIA ALLYSEN",
									"GARCIA MARTINEZ JOSE JULIAN",
									"GARCIA MASCOTE MIGUEL ALEJANDRO",
									"GONZALEZ DIAZ JUAN RAFAEL",
									"GONZALEZ GONZALEZ JUAN PABLO",
									"GONZALEZ ZAVALA MARIANA MARGARITA",
									"GORDILLO AGUILAR LEONARDO",
									"GORDILLO BAUTISTA ANGEL ISAAC",
									"GUTIERREZ MARTINEZ YUREM",
									"GUZMAN MARTINEZ FRANCISCO EMILIANO",
									"JUAREZ CUEVAS KAROL",
									"LOPEZ GARCIA YAEL",
									"LOPEZ YAÑEZ CINTIA GUADALUPE",
									"MARTINEZ GUZMAN HUGO ANTONIO",
									"MASCOTE REYES EMMANUEL",
									"MORALES ALARCON JESSICA SARAI",
									"MORENO DOMINGUEZ VICTOR HUGO",
									"NIETO OROZCO DANA CAMILA",
									"NUÑEZ HERRERA MIGUEL ANGEL",
									"OROZCO PEREZ VICTOR MANUEL",
									"PEREZ MENDEZ MIGUEL ALEJANDRO",
									"PEREZ VAZQUEZ KEVIN DANIEL",
									"PIEDRA GARCIA ISRAEL",
									"QUINTINO GUZMAN ARIANA",
									"RAMIREZ LOPEZ GERARDO ISAAC",
									"RAYMUNDO RODRIGUEZ JIMENA",
									"ROCHA GARNICA JOCELIN",
									"ROMERO AVILA MICHELLE",
									"RUIZ DAMIAN YADHIRA",
									"RUIZ JIMENEZ ALAN JOSUE",
									"SANCHEZ RODRIGUEZ GERARDO",
									"SOLIS MOJICA JUAN DAVID",
									"TAPIA ALCANTAR FATIMA AVRIL",
									"TENORIO IZQUIERDO VICTOR ANTHUAN",
									"VILLAGOMEZ ESPINOZA JOSHUA CESAR",
									"ZAVALA GARCIA JOSE DE JESUS",
									"ZAVALA GONZALEZ DAYANA CAROLINA",
									"ZAVALA PEREDO OBED ASAEL",
									"GONZALEZ VAZQUEZ ALAN ALEXIS"});
			this.comboBox1.Location = new System.Drawing.Point(22, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(268, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// Matesc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 261);
			this.Controls.Add(this.comboBox1);
			this.Name = "Matesc";
			this.Text = "Matesc";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
