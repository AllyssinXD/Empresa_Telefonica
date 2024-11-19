using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Empresa_de_Telefone
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		void Button1Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 2; i++) {
				int nlinhas = int.Parse(textBox9.Text);
				string linha = richTextBox1.Lines[nlinhas];
				string[] dados = linha.Split('|');
			
			
				if (dados[0] == textBox9.Text) {
					MessageBox.Show("O número de ID já existem!", "Erro!");
				
				}			
				else{
					richTextBox1.Text += String.Format("{4}|{0}|({3}){1}|{2}\n", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox9.Text);
					MessageBox.Show("Registrado com Sucesso!", "Adicionado");
					textBox1.Clear();
					textBox2.Clear();
					textBox3.Clear();
					textBox4.Clear();
					textBox9.Focus();
				}
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile("Funcionários.txt", RichTextBoxStreamType.PlainText);
		}
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.LoadFile("Funcionários.txt", RichTextBoxStreamType.PlainText);
		}
		void Button4Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
	}
}
