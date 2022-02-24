using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_RESERVASALAS
{
    public partial class VerReservas : Form
    {
        BaseDados bd = new BaseDados();
        public VerReservas()
        {

            InitializeComponent();

        }

        private void VerReservas_Load(object sender, EventArgs e)
        {
            string sql = "Select r.ID_RESERVA, r.ID_SALA, s.HORA_SLOT, r.DATA_RESERVA, r.EMAIL FROM RESERVA r JOIN SLOT_HORARIO s ON s.ID_SLOT = r.ID_SLOT";
            dgv_Listar.DataSource = bd.devolveconsulta(sql);
            dgv_Listar.Refresh();
            /*btn_editar.Visible = false;*/
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bd.executa_SQL("Delete From RESERVA WHERE ID_RESERVA=" + dgv_Listar.SelectedRows[0].Cells[0].Value);
            dgv_Listar.Refresh();
        }

      

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string up_APP = "UPDATE RESERVA SET DATA_RESERVA=@DATA_RESERVA where ID_RESERVA =" + dgv_Listar.SelectedRows[0].Cells[0].Value;
            List<SqlParameter> parametros1 = new List<SqlParameter>();
            parametros1.Add(new SqlParameter("@DATA_RESERVA", (DateTime)editar_Data.Value));
            bd.executa_SQL(up_APP, parametros1);
            string sql = "Select r.ID_RESERVA, r.ID_SALA, s.HORA_SLOT, r.DATA_RESERVA, r.EMAIL FROM RESERVA r JOIN SLOT_HORARIO s ON s.ID_SLOT = r.ID_SLOT";
            dgv_Listar.DataSource = bd.devolveconsulta(sql);
            dgv_Listar.Refresh();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            editar_Data.Value = (DateTime)dgv_Listar.SelectedRows[0].Cells[3].Value;
            guardarbtn.Visible = true;
        }
    }
}
