/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 29/10/2024
 * Time: 07:29 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "¿Que es ecologia?";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(410, 279);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(437, 46);
			this.label2.TabIndex = 2;
			this.label2.Text = "La ecología es el estudio y cuidado del planeta tierra, es una ciencia que estudi" +
			"a las relaciones de los seres vivos con su ambiente y características del medio." +
			"";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(498, 326);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
