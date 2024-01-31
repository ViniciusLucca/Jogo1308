/*
 * Criado por SharpDevelop.
 * Usuário: rm20212930060
 * Data: 08/06/2022
 * Hora: 10:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_13_04
{
	public class Inimigo: Personagem
	{
		public Timer relogio = new Timer();
		Random rand = new Random();
		public Heroi heroi;
		public Form2 form2 = new Form2();

		
		
		public Inimigo()
		{
			Load("inimigo3.gif");
			Width = 70;
			Height = 70;
			Left = 660;
			relogio.Interval = 10;
			relogio.Tick += Movimentar;
			
		}
		
		//Método que movimenta o inimigo
		
		void Movimentar (object sender, EventArgs e)
		{
			speed = 9;
			Top += speed;
			
				if(this.Bounds.IntersectsWith(heroi.Bounds))
				{
					
					heroi.hp-=1;
					Left = rand.Next(0, 600);
					Top = -50;
					
					if(heroi.hp == 0)
					{
						heroi.Dispose();
						form2.Show();
						relogio.Enabled = false;
						speed = 0;
					}
				}
			
			if (Top >= 850)
			{
				Top = -50;
				Left = rand.Next(0, 600);
			}
		}
		
	}
}
