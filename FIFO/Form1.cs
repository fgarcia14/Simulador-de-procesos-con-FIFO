using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO
{
	public partial class frmPrincipal : Form
	{
		Simulador simulador;
		public frmPrincipal()
		{
			InitializeComponent();
			simulador = new Simulador();
		}

		private void btnSimular_Click(object sender, EventArgs e)
		{
			txtConsola.Text=simulador.simular();
		}
	}
}
