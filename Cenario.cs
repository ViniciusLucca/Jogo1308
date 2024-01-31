/*
 * Criado por SharpDevelop.
 * Usuário: rm20212930060
 * Data: 25/05/2022
 * Hora: 10:55
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_13_04
{
	public class Cenario: PictureBox
	{
		public Cenario()
		{
			Load("scenario.gif");
			Height = 797;
			Width = 700;
			SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		public void MovingEffect()
		{
			
		}
	}
}
