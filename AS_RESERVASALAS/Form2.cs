using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AS_RESERVASALAS
{
    public partial class FrmCriarSala : Form
    {
        BaseDados bd = new BaseDados();
        Form1 form1 = new Form1();
        public FrmCriarSala()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool erro = false;
            errorProvider1.Clear();

            if (txt_Capacidade.Text == "")
            {
                errorProvider1.SetError(txt_Capacidade, "Campo de preenchimento obrigatorio");
                erro = true;
            }

            if (txt_Alocmax.Text == "")
            {
                errorProvider1.SetError(txt_Alocmax, "Campo de preenchimento obrigatorio");
                erro = true;
            }

            if (erro)
            {
                DialogResult = DialogResult.None;
            }

            if (!erro)
            {
                int Capacidade = Convert.ToInt32(txt_Capacidade.Text);
                int Aloc_max = Convert.ToInt32(txt_Alocmax.Text);

                string sql = "INSERT INTO SALA ( CAPACIDADE, ALOC_MAX) VALUES ( @CAPACIDADE, @ALOC_MAX)";

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@CAPACIDADE", Capacidade));
                parametros.Add(new SqlParameter("@ALOC_MAX", Aloc_max));
                bd.executa_SQL(sql, parametros);
                MessageBox.Show("Sala criada com sucesso!");
                this.Hide();
                form1.Show();
                    
               
            }
            
        }
    }
}
