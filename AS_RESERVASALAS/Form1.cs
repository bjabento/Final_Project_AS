using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_RESERVASALAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCriarsala_Click(object sender, EventArgs e)
        {
            FrmCriarSala CRIARSALA = new FrmCriarSala();
            this.Hide();
            CRIARSALA.ShowDialog();
        }

        private void BTNVerReservas_Click(object sender, EventArgs e)
        {
            VerReservas verReservas = new VerReservas();
            this.Hide();
            verReservas.ShowDialog();   
        }
    }
}
