 /*
 * Created by SharpDevelop.
 * User: rm20212930017
 * Date: 13/04/2022
 * Time: 11:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Jogo_13_04
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		//Instâncias e variáveis
		
		Cenario cenario = new Cenario();
		
		public Heroi foguete = new Heroi();
		
		public Heroi foguete2 = new Heroi();
		
		public Bullet bullet = new Bullet();
		
		Inimigo inimigo = new Inimigo();
		
		Inimigo inimigo2 = new Inimigo();
		
		Button btn1 = new Button();
		
		Button btn2 = new Button();
		
		public Form1 f1;
		
		SoundPlayer music1 = new SoundPlayer("Trilha1.wav");
		
		Label txtEsc = new Label();
		
		Timer t1 = new Timer();
		Timer t2 = new Timer();

		bool a = true;
		
		string escolhaPersonagem;

		Image img = Image.FromFile("FogueteUp.gif");
		Image img2 = Image.FromFile("Foguete2Up.gif");
		
		//Botão de Início
		
		public void Button1Click(object sender, EventArgs e)
		{
			btn1.Parent = this;
			btn2.Parent = this;
			
			btn1.Location = new Point(148, 352);
			btn2.Location = new Point(444, 352);
			
			btn1.BackColor = Color.Black;
			btn2.BackColor = Color.Black;
			
			btn1.Size = new Size(100, 100);
			btn2.Size = new Size(120, 100);
			
			btn1.Image = img;
			btn2.Image = img2;
			
			btn2.Click += Btn2Click;
			btn1.Click += Btn1Click;
			
			txtEsc.Text = "Escolha seu personagem";
			txtEsc.AutoSize = true;
			txtEsc.Font = new Font("Showcard Gothic", 24);
			txtEsc.BackColor = Color.Black;
			txtEsc.ForeColor = Color.Snow;
			txtEsc.Location = new Point(141, 500);
			txtEsc.Parent = this;
			
			t1.Interval = 650;
			t1.Start();
			t1.Tick += SubTitulo;
			
			music1.Play();
			
			button1.Visible = false;
			bullet.frm = this;
		}
		
		//Método que relaciona a movimentação com as teclas
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left)
			{
				foguete.btnClickL(this, null);
				foguete2.btnClickL(this, null);
			}
			
			if(e.KeyCode == Keys.Right)
			{
				foguete.btnClickR(this, null);
				foguete2.btnClickR(this, null);
				
			}
			
				if(e.KeyCode == Keys.E && !bullet.shooting)
				{	
					bullet.Parent = cenario;
					bullet.inimigo = inimigo;
					bullet.inimigo2 = inimigo2;
					bullet.relogio.Enabled = true;
					bullet.Left = foguete.Left+15;
					bullet.Top = foguete.Top+10;
					bullet.shooting = true;
				}
		}
		
		//Método da escolha do personagem 1
		
		public void Btn1Click (object sender, EventArgs e)
		{
				cenario.Parent = this;
				foguete.Parent = cenario;
				inimigo.relogio.Start();
				inimigo.Parent = cenario;
				inimigo2.relogio.Start();
				inimigo2.Parent = cenario;
				btn1.Visible = false;
				btn2.Visible = false;
				foguete.aux = true;
				t1.Stop();
				txtEsc.Visible = false;
				label1.Visible = false;
				
				inimigo.heroi = foguete;
				inimigo2.heroi = foguete;
				
				panel1.Visible = true;
				
				escolhaPersonagem = "1";
				
				t2.Interval = 100;
				t2.Start();
				t2.Tick += Fechar;
		}
		
		//Método da escolha do personagem 2
		
		public void Btn2Click (object sender, EventArgs e)
		{
				cenario.Parent = this;
				foguete2.Load("Foguete2Up.gif");
				inimigo.relogio.Start();
				foguete2.Parent = cenario;
				inimigo.Parent = cenario;
				inimigo2.relogio.Start();
				inimigo2.Parent = cenario;
				btn1.Visible = false;
				btn2.Visible = false;
				foguete2.aux = false;
				t1.Stop();
				txtEsc.Visible = false;
				label1.Visible = false;
				
				inimigo.heroi = foguete2;
				inimigo2.heroi = foguete2;
				
				panel1.Visible = true;
				
				escolhaPersonagem = "2";
				
				t2.Interval = 100;
				t2.Start();
				t2.Tick += Fechar;
		}
		
		//Método para animar o "Escolha seu personagem"
		
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
		
		Form2 form2 = new Form2();
		
		//Método usado para controlar a pontuação, vida, derrota e vitória
		
		public void Fechar (object sender, EventArgs e)
		{
			label4.Text = bullet.pontuaçao.ToString();	
			
			if (escolhaPersonagem == "1") 
			{
				label6.Text = foguete.hp.ToString();	
			}
			
			else
			{
				label6.Text = foguete2.hp.ToString();
			}
			
			
			if(inimigo.speed == 0 || inimigo2.speed == 0)
			{
				AltF4();
			}
			
			if(bullet.pontuaçao >=5)
			{
				AltF4();
				form2.victory = true;
				form2.Show();
			}
			
		}
		
		//Método que "fecha" o jogo
		
		void AltF4()
		{
			this.Hide();
			inimigo2.Dispose();
			inimigo2.relogio.Enabled = false;
			inimigo.Dispose();
			inimigo.relogio.Enabled = false;
		}
	}
}
