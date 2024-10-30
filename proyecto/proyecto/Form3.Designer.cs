/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 29/10/2024
 * Time: 07:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(449, 341);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(58, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(293, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Profundidades del oceano";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Zona batial";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(37, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(441, 42);
			this.label3.TabIndex = 3;
			this.label3.Text = "Comprende desde 1000 hasta 4000 m de profundidad, la luz solar ya no está disponi" +
			"ble, la presión hidrostática es mayor, la temperatura del agua es de 4 °C.";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(37, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Zona abisal";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(37, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(441, 67);
			this.label5.TabIndex = 5;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(37, 263);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Zona hadal";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(37, 297);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(441, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "label7";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(519, 386);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
