/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 29/10/2024
 * Time: 08:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Matesp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matesp));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtp = new System.Windows.Forms.TextBox();
			this.txts = new System.Windows.Forms.TextBox();
			this.txtc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnv = new System.Windows.Forms.Button();
			this.btnc = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(196, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ejemplo de promedio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(283, 255);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "El promedio es:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(562, 58);
			this.label3.TabIndex = 2;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// txtp
			// 
			this.txtp.Location = new System.Drawing.Point(385, 255);
			this.txtp.Name = "txtp";
			this.txtp.Size = new System.Drawing.Size(100, 20);
			this.txtp.TabIndex = 3;
			// 
			// txts
			// 
			this.txts.Location = new System.Drawing.Point(283, 173);
			this.txts.Name = "txts";
			this.txts.Size = new System.Drawing.Size(100, 20);
			this.txts.TabIndex = 4;
			// 
			// txtc
			// 
			this.txtc.Location = new System.Drawing.Point(466, 173);
			this.txtc.Name = "txtc";
			this.txtc.Size = new System.Drawing.Size(39, 20);
			this.txtc.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(414, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cantidad de numeros";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(270, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Suma de los numeros";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 111);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(229, 140);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// btnv
			// 
			this.btnv.Location = new System.Drawing.Point(45, 293);
			this.btnv.Name = "btnv";
			this.btnv.Size = new System.Drawing.Size(97, 25);
			this.btnv.TabIndex = 11;
			this.btnv.Text = "<";
			this.btnv.UseVisualStyleBackColor = true;
			this.btnv.Click += new System.EventHandler(this.BtnvClick);
			// 
			// btnc
			// 
			this.btnc.Location = new System.Drawing.Point(422, 295);
			this.btnc.Name = "btnc";
			this.btnc.Size = new System.Drawing.Size(83, 23);
			this.btnc.TabIndex = 12;
			this.btnc.Text = "Calcular";
			this.btnc.UseVisualStyleBackColor = true;
			this.btnc.Click += new System.EventHandler(this.BtncClick);
			// 
			// Matesp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 328);
			this.Controls.Add(this.btnc);
			this.Controls.Add(this.btnv);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtc);
			this.Controls.Add(this.txts);
			this.Controls.Add(this.txtp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Matesp";
			this.Text = "Matesp";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnc;
		private System.Windows.Forms.Button btnv;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtc;
		private System.Windows.Forms.TextBox txts;
		private System.Windows.Forms.TextBox txtp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
