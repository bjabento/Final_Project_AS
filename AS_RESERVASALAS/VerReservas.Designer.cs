namespace AS_RESERVASALAS
{
    partial class VerReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btn_eliminar;
            this.guardarbtn = new System.Windows.Forms.Button();
            this.dgv_Listar = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editar_Data = new System.Windows.Forms.DateTimePicker();
            btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new System.Drawing.Point(716, 322);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new System.Drawing.Size(155, 49);
            btn_eliminar.TabIndex = 1;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // guardarbtn
            // 
            this.guardarbtn.Location = new System.Drawing.Point(17, 402);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(164, 36);
            this.guardarbtn.TabIndex = 8;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = true;
            this.guardarbtn.Visible = false;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // dgv_Listar
            // 
            this.dgv_Listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listar.Location = new System.Drawing.Point(-2, -3);
            this.dgv_Listar.Name = "dgv_Listar";
            this.dgv_Listar.RowHeadersWidth = 62;
            this.dgv_Listar.Size = new System.Drawing.Size(885, 319);
            this.dgv_Listar.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(716, 381);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(152, 57);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data da reserva:";
            // 
            // editar_Data
            // 
            this.editar_Data.Location = new System.Drawing.Point(145, 322);
            this.editar_Data.Name = "editar_Data";
            this.editar_Data.Size = new System.Drawing.Size(200, 26);
            this.editar_Data.TabIndex = 6;
            // 
            // VerReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.editar_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(btn_eliminar);
            this.Controls.Add(this.dgv_Listar);
            this.Name = "VerReservas";
            this.Text = "VerReservas";
            this.Load += new System.EventHandler(this.VerReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Listar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker editar_Data;
        private System.Windows.Forms.Button guardarbtn;
    }
}