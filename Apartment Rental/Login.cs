/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 21/02/2020
 * Time: 12:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Apartment_Rental
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			Home ins = new Home();
			this.Hide();
			ins.Show();
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
	}
}
