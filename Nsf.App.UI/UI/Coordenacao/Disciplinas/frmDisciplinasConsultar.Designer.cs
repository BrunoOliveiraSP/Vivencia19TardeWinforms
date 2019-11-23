namespace Nsf.App.UI
{
    partial class frmDisciplinasConsultar
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
			this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
			this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.txtDisciplina = new System.Windows.Forms.TextBox();
			this.label68 = new System.Windows.Forms.Label();
			this.txtSigla = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.label5.Location = new System.Drawing.Point(48, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(346, 37);
			this.label5.TabIndex = 5;
			this.label5.Text = "  Consultar Disciplinas  ";
			// 
			// pnSelected
			// 
			this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.pnSelected.Location = new System.Drawing.Point(10, 37);
			this.pnSelected.Name = "pnSelected";
			this.pnSelected.Size = new System.Drawing.Size(1000, 1);
			this.pnSelected.TabIndex = 6;
			// 
			// dgvDisciplinas
			// 
			this.dgvDisciplinas.AllowUserToAddRows = false;
			this.dgvDisciplinas.AllowUserToDeleteRows = false;
			this.dgvDisciplinas.AllowUserToResizeRows = false;
			this.dgvDisciplinas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvDisciplinas.ColumnHeadersHeight = 45;
			this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.Nome,
            this.Column3,
            this.Column2,
            this.Column1});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDisciplinas.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDisciplinas.Location = new System.Drawing.Point(44, 191);
			this.dgvDisciplinas.Name = "dgvDisciplinas";
			this.dgvDisciplinas.ReadOnly = true;
			this.dgvDisciplinas.RowHeadersVisible = false;
			this.dgvDisciplinas.RowHeadersWidth = 45;
			this.dgvDisciplinas.RowTemplate.Height = 25;
			this.dgvDisciplinas.Size = new System.Drawing.Size(731, 370);
			this.dgvDisciplinas.TabIndex = 2;
			// 
			// Registro
			// 
			this.Registro.DataPropertyName = "nm_disciplina";
			this.Registro.HeaderText = "Disciplina";
			this.Registro.Name = "Registro";
			this.Registro.ReadOnly = true;
			this.Registro.Width = 450;
			// 
			// Nome
			// 
			this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nome.DataPropertyName = "ds_sigla";
			this.Nome.HeaderText = "Sigla";
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "bt_ativo";
			this.Column3.HeaderText = "Ativo";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
			// txtDisciplina
			// 
			this.txtDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDisciplina.Location = new System.Drawing.Point(174, 145);
			this.txtDisciplina.Name = "txtDisciplina";
			this.txtDisciplina.Size = new System.Drawing.Size(333, 27);
			this.txtDisciplina.TabIndex = 0;
			// 
			// label68
			// 
			this.label68.AutoSize = true;
			this.label68.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label68.ForeColor = System.Drawing.Color.Black;
			this.label68.Location = new System.Drawing.Point(80, 148);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(88, 19);
			this.label68.TabIndex = 162;
			this.label68.Text = "Disciplina:";
			// 
			// txtSigla
			// 
			this.txtSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSigla.Location = new System.Drawing.Point(573, 145);
			this.txtSigla.Name = "txtSigla";
			this.txtSigla.Size = new System.Drawing.Size(157, 27);
			this.txtSigla.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(516, 148);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 19);
			this.label1.TabIndex = 164;
			this.label1.Text = "Sigla:";
			// 
			// frmDisciplinasConsultar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.txtSigla);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDisciplina);
			this.Controls.Add(this.label68);
			this.Controls.Add(this.dgvDisciplinas);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pnSelected);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "frmDisciplinasConsultar";
			this.Size = new System.Drawing.Size(800, 600);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
		private System.Windows.Forms.TextBox txtDisciplina;
		private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
