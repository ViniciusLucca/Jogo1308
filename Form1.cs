/*
 * Created by SharpDevelop.
 * User: RM20212930060
 * Date: 10/08/2022
 * Time: 09:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_13_04
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
			
		public Timer timer1 = new Timer();
		public bool teste;
		
		public void Timer1Tick(object sender, EventArgs e)
		{
			panel2.Width += 6;
			
			if (panel2.Width >= 650)
			{
				timer1.Stop();
				this.Hide();
				//m2.Show();
			}
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "d" && textBox2.Text == "d")
			{
				timer1.Interval = 10;
				timer1.Start();
				timer1.Tick += Timer1Tick;
				MessageBox.Show("Login feito com secesso!");
				
			}
			
			else
			{
				MessageBox.Show("Login não encontrado!");
			}
		}
		
	}
}
