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
			richTextBox1.Text += textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text + "\n";
	
		}
	}
}
