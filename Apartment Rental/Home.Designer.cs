﻿/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 21/02/2020
 * Time: 12:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Apartment_Rental
{
	partial class Home
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(308, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "Parrot Home\'s";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(261, 130);
			this.button1.TabIndex = 1;
			this.button1.Text = "Sign In";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(280, 358);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(261, 130);
			this.button2.TabIndex = 2;
			this.button2.Text = "New Tenant";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Home";
			this.Text = "Home";
			this.ResumeLayout(false);

		}
	}
}
