namespace Nsf.App.UI
{
    partial class frmCursoConsultar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.pnSelected = new System.Windows.Forms.Panel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNrCapacidadeMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBtAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(48, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "  Consultar Cursos  ";
            // 
            // pnSelected
            // 
            this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.pnSelected.Location = new System.Drawing.Point(10, 37);
            this.pnSelected.Name = "pnSelected";
            this.pnSelected.Size = new System.Drawing.Size(1000, 1);
            this.pnSelected.TabIndex = 6;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCursos.ColumnHeadersHeight = 45;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCurso,
            this.dgvtxtCurso,
            this.dgvtxtSigla,
            this.dgvtxtNrCapacidadeMaxima,
            this.dgvtxtBtAtivo,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.Location = new System.Drawing.Point(36, 185);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.RowHeadersWidth = 45;
            this.dgvCursos.RowTemplate.Height = 25;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(728, 396);
            this.dgvCursos.TabIndex = 2;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            // 
            // txtCurso
            // 
            this.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurso.Location = new System.Drawing.Point(115, 134);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(390, 27);
            this.txtCurso.TabIndex = 0;
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(42, 137);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(56, 19);
            this.label68.TabIndex = 162;
            this.label68.Text = "Curso:";
            // 
            // txtSigla
            // 
            this.txtSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSigla.Location = new System.Drawing.Point(590, 134);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(174, 27);
            this.txtSigla.TabIndex = 1;
            this.txtSigla.TextChanged += new System.EventHandler(this.txtSigla_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(533, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 164;
            this.label1.Text = "Sigla:";
            // 
            // IdCurso
            // 
            this.IdCurso.DataPropertyName = "IdCurso";
            this.IdCurso.HeaderText = "ID";
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.ReadOnly = true;
            this.IdCurso.Visible = false;
            // 
            // dgvtxtCurso
            // 
            this.dgvtxtCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtCurso.DataPropertyName = "NmCurso";
            this.dgvtxtCurso.HeaderText = "Curso";
            this.dgvtxtCurso.Name = "dgvtxtCurso";
            this.dgvtxtCurso.ReadOnly = true;
            // 
            // dgvtxtSigla
            // 
            this.dgvtxtSigla.DataPropertyName = "DsSigla";
            this.dgvtxtSigla.HeaderText = "Sigla";
            this.dgvtxtSigla.Name = "dgvtxtSigla";
            this.dgvtxtSigla.ReadOnly = true;
            this.dgvtxtSigla.Width = 71;
            // 
            // dgvtxtNrCapacidadeMaxima
            // 
            this.dgvtxtNrCapacidadeMaxima.DataPropertyName = "NrCapacidadeMaxima";
            this.dgvtxtNrCapacidadeMaxima.HeaderText = "Capacidade";
            this.dgvtxtNrCapacidadeMaxima.Name = "dgvtxtNrCapacidadeMaxima";
            this.dgvtxtNrCapacidadeMaxima.ReadOnly = true;
            this.dgvtxtNrCapacidadeMaxima.Width = 133;
            // 
            // dgvtxtBtAtivo
            // 
            this.dgvtxtBtAtivo.DataPropertyName = "BtAtivo";
            this.dgvtxtBtAtivo.HeaderText = "Ativo";
            this.dgvtxtBtAtivo.Name = "dgvtxtBtAtivo";
            this.dgvtxtBtAtivo.ReadOnly = true;
            this.dgvtxtBtAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtBtAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvtxtBtAtivo.Width = 134;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Image = global::Nsf.App.UI.Properties.Resources.edit2;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = global::Nsf.App.UI.Properties.Resources.remove2;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 25;
            // 
            // frmCursoConsultar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnSelected);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCursoConsultar";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.frmCursoConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
		private System.Windows.Forms.TextBox txtCurso;
		private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNrCapacidadeMaxima;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvtxtBtAtivo;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
