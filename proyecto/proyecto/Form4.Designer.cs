/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 29/10/2024
 * Time: 08:27 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(102, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Profundidades del oceano";
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(497, 343);
			this.Controls.Add(this.label1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
	}
}
