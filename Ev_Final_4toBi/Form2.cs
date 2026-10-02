using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void BtnProducto_Click(object sender, EventArgs e)
		{
			Byte Num1 = Byte.Parse(TextVar1.Text);
			Byte num2 = Byte.Parse(TextVar2.Text);
			int Producto = Num1 * num2;
			MessageBox.Show("El resultado es; " + Producto);

		}

		private void BtnSuma_Click(object sender, EventArgs e)
		{
			Byte Num1 = Byte.Parse(TextVar1.Text);
			Byte Num2 = Byte.Parse(TextVar2.Text);
			int Suma = Num1 + Num2;
			MessageBox.Show("El resultado es: " + Suma);
		}

		private void BtnPotencia_Click(object sender, EventArgs e)
		{
			int Num1 = int.Parse(TextVar1.Text);
			int Num2 = int.Parse(TextVar2.Text);
			int Potencia = 1;
			int I = 0;
			while(I !=Num2)
			{
				Potencia = Potencia * Num1;
				I++; 
			}
			MessageBox.Show("El resultado es" + Potencia);

	}

		private void BtnDivision_Click(object sender, EventArgs e)
		{
			float Num1 = float.Parse(TextVar1.Text);
			float Num2 = float.Parse(TextVar2.Text);
			if (Num2 > 0)
			{
				float Division = Num1 / Num2;
				MessageBox.Show("El Resultado es" + Division);
	}
			else
	              MessageBox.Show("No se puede dividir entre 0");
	}

}
}