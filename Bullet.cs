using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_13_04
{
	/// <summary>
	/// Description of Bullet.
	/// </summary>
	public class Bullet:PictureBox
	{
		
		public Bullet()
		{
			Load("bala2.gif");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 35;
			Height = 107;
			bullet_speed = 20;
			relogio.Interval = 30;
			relogio.Tick+=Movimentar;
		}
		
		public int bullet_speed;
		public Timer relogio = new Timer();
		public bool shooting = false;
		public Inimigo inimigo = new Inimigo();
		public Inimigo inimigo2 = new Inimigo();
		public Random rnd = new Random();
		public Heroi heroi = new Heroi();
		public Form frm = new Form();
		public int pontuaçao;
		
		//Método de movimentação da bala
		
		void Movimentar(object sender, EventArgs e)
		{
			if (shooting)
			{
				Top -= bullet_speed;
				
				if(this.Bounds.IntersectsWith(inimigo.Bounds))
				{
					inimigo.Left = 830;
					inimigo.Top = rnd.Next(0, 330);
					relogio.Enabled = false;
					Left = -100;
					Top = -100;
					shooting = false;
					pontuaçao++;
				}
				
				if(this.Bounds.IntersectsWith(inimigo2.Bounds))
				{
					inimigo2.Left = 830;
					inimigo2.Top = rnd.Next(0, 330);
					relogio.Enabled = false;
					Left = -100;
					Top = -100;
					shooting = false;
					pontuaçao++;
					
				}
				
				if(Top <= -100)
				{
					relogio.Enabled = false;
					shooting = false;
				}
			}
		}
		
	}
}

