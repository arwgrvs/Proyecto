/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 04:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Humani
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Humani));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "¿QUE ES LA MORAL?";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label2.Font = new System.Drawing.Font("Lucida Bright", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(283, 77);
			this.label2.TabIndex = 1;
			this.label2.Text = "  ES UN CONJUNTO DE NORMAS ACEPTADAS LIBRE Y CONSIENTEMENTE, QUE REGULAN LA CONDU" +
			"CTA  INDIVIDUAL Y SOCIAL DE LAS PERSONAS\r\n";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "¿QUE ES LA ETICA?";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Lucida Bright", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 237);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(342, 42);
			this.label4.TabIndex = 3;
			this.label4.Text = " ES UN ANALISIS SISTEMATICO Y CRITICO DE LA MORALIDAD, DE LOS FACTORES MORALES QU" +
			"E GUIAN LA CONDUCTA HUMANA EN UNA DETERMINADA PRACTICA O SOCIAL.\r\n";
			// 
			// Humani
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(544, 327);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Name = "Humani";
			this.Text = "HUMANIDADES";
			this.Load += new System.EventHandler(this.HumaniLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
	
		
		void HumaniLoad(object sender, System.EventArgs e)
		{
			
		}
		
		void PictureBox1Click(object sender, System.EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, System.EventArgs e)
		{
			
		}
		}
		}
		


