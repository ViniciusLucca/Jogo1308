/*
 * Criado por SharpDevelop.
 * Usuário: rm20212930060
 * Data: 18/05/2022
 * Hora: 11:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
	
namespace Jogo_13_04
{
	public class Heroi: Personagem
	{
		public Heroi()
		{
			Load("FogueteUp.gif");
			Left = 170;
			Top = 650;
			speed = 20;
			Width = 65;
			Height = 82;
			hp = 3;
		}
		
		public bool R = true;
		public bool L = true;
		public bool U = true;
		public bool D = true;
		public int nivel = 1;
		public bool aux;
	
		//Método que movimenta para a direita
		
		public void btnClickR(object sender, EventArgs e)
		{
			
			if (Left >= 600) {
				
				Left = 600;
			}
			
			
			else
			{
				Left += speed;
				
				
				
				if(aux)
				{
					if (R)
					{
						R = false;
						U = true;
						L = true;
						D = true;
					}
				}
				
				else
				{
					if(R)
					{
						R = false;
						U = true;
						L = true;
						D = true;
					}
				}
			}
		}
		
		//Método que movimenta para a esquerda
		
		public void btnClickL(object sender, EventArgs e)
		{
			
			if (Left <= 0) {
				
				Left = 0;
			}
			
			else
			{
			
				Left -= speed;
				
				
				if (aux)
				{
					if (L) 
					{
						L = false;
						U = true;
						D = true;
						R = true;
					}
				}
				
				else
				{
					if(L)
					{
						L = false;
						U = true;
						D = true;
						R = true;
					}
				}
			}
		}
	
	}
}
