/*
 * Criado por SharpDevelop.
 * Usuário: rm20212930060
 * Data: 31/08/2022
 * Hora: 11:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_13_04
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			
		}
		
		Timer t1 = new Timer();
		Label txtEsc = new Label();
		public bool victory;
		bool a = true;
		Image vitoriaImg = Image.FromFile("astronauta.jpg");
		Image derrotaImg = Image.FromFile("FundoTelaPrincipal.jpg");
		
		//Método que constrói a tela de vitória/derrota
		
		void Form2Load(object sender, EventArgs e)
		{
			label1.Text = victory ? "VOCÊ VENCEU!" : "GAME OVER";
			txtEsc.Text = victory ? "Jogar Novamente?" : "Continuar?";

			txtEsc.AutoSize = true;
			txtEsc.Font = new Font("Showcard Gothic", 42);
			txtEsc.ForeColor = Color.Snow;
			txtEsc.BackColor = Color.Transparent;
			label1.Location = victory ? new Point(80, label1.Location.Y): label1.Location;
			txtEsc.Location = victory ? new Point(110, 153): new Point(220, 153);
			
			if (victory) {
				
				BackgroundImage = vitoriaImg;
			}
			
			else
			{
				BackgroundImage = derrotaImg;
			}
			
			
			txtEsc.Parent = this;
			t1.Interval = 650;
			t1.Start();
			t1.Tick += SubTitulo;
		}
		
		//Método que anima o "Continuar"
		
		public void SubTitulo (object sender, EventArgs e)
		{
			if(a)
			{
				txtEsc.Visible = false;
				a = false;
			}
			
			else
			{
				txtEsc.Visible = true;
				a = true;
			}
		}
		
		//Método do botão "SIM"
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
		
		//Método do botão "NÃO"
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		//Método encerra a aplicação quando a tela de derrota/vitória
		
		void Form2FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
