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

namespace AS_Crowdzero
{
    public partial class Frm_Criar_Utilizador : Form
    {
        BaseDados bd = new BaseDados();
        public Frm_Criar_Utilizador()
        {
            InitializeComponent();
        }

        private void Frm_Criar_Utilizador_Load(object sender, EventArgs e)
        {
      
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
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

               /* string Nome = txt_Capacidade.Text;
                int Idade = Convert.ToInt32(txt_Alocmax.Text);
                string Tipo_Func = "Utilizador APP";
                string Genero = cmb_Genero.Text;
                int Telefone = Convert.ToInt32(txt_Telefone.Text);
                int BI = Convert.ToInt32(txt_BI.Text);              
                string Email = txt_Email.Text;
                string Pass = txt_Password.Text;
                string Estado = "Ativo"; */

                string sql = "INSERT INTO SALA ( CAPACIDADE, ALOC_MAX) VALUES ( @CAPACIDADE, @ALOC_MAX)";

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@CAPACIDADE", Capacidade));
                parametros.Add(new SqlParameter("@ALOC_MAX", Aloc_max));
                bd.executa_SQL(sql, parametros);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_Crowdzero frm_c = new Frm_Crowdzero();
            frm_c.Show();
            this.Close();
        }
    }
}
