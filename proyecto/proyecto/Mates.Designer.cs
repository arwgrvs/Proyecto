/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 04:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Mates
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
			this.btnc = new System.Windows.Forms.Button();
			this.btnp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnc
			// 
			this.btnc.Location = new System.Drawing.Point(12, 28);
			this.btnc.Name = "btnc";
			this.btnc.Size = new System.Drawing.Size(95, 22);
			this.btnc.TabIndex = 0;
			this.btnc.Text = "Calificaciones";
			this.btnc.UseVisualStyleBackColor = true;
			this.btnc.Click += new System.EventHandler(this.BtncClick);
			// 
			// btnp
			// 
			this.btnp.Location = new System.Drawing.Point(12, 69);
			this.btnp.Name = "btnp";
			this.btnp.Size = new System.Drawing.Size(95, 23);
			this.btnp.TabIndex = 1;
			this.btnp.Text = "Promedio";
			this.btnp.UseVisualStyleBackColor = true;
			this.btnp.Click += new System.EventHandler(this.Button2Click);
			// 
			// Mates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnp);
			this.Controls.Add(this.btnc);
			this.Name = "Mates";
			this.Text = "Mates";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnp;
		private System.Windows.Forms.Button btnc;
	}
}
