/*
 * Criado por SharpDevelop.
 * Usuário: rm20212930060
 * Data: 08/06/2022
 * Hora: 09:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_13_04
{
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
		}
		
		public int speed;
		public int hp;
		public int escudo;
		public int dano;
		
	}
}
