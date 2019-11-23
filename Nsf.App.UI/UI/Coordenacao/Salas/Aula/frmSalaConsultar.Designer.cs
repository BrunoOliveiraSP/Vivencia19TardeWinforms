namespace Nsf.App.UI
{
    partial class frmSalaConsultar
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
			this.dgvSalas = new System.Windows.Forms.DataGridView();
			this.Instituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.label68 = new System.Windows.Forms.Label();
			this.txtInstituicao = new System.Windows.Forms.TextBox();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.label5.Location = new System.Drawing.Point(48, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(270, 37);
			this.label5.TabIndex = 5;
			this.label5.Text = "  Consultar Salas  ";
			// 
			// pnSelected
			// 
			this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.pnSelected.Location = new System.Drawing.Point(10, 37);
			this.pnSelected.Name = "pnSelected";
			this.pnSelected.Size = new System.Drawing.Size(1000, 1);
			this.pnSelected.TabIndex = 6;
			// 
			// dgvSalas
			// 
			this.dgvSalas.AllowUserToAddRows = false;
			this.dgvSalas.AllowUserToDeleteRows = false;
			this.dgvSalas.AllowUserToResizeRows = false;
			this.dgvSalas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvSalas.ColumnHeadersHeight = 45;
			this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instituicao,
            this.Sala,
            this.Capacidade,
            this.Column3,
            this.Column1,
            this.Column2});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(227)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSalas.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSalas.Location = new System.Drawing.Point(31, 183);
			this.dgvSalas.Name = "dgvSalas";
			this.dgvSalas.ReadOnly = true;
			this.dgvSalas.RowHeadersVisible = false;
			this.dgvSalas.RowHeadersWidth = 45;
			this.dgvSalas.RowTemplate.Height = 25;
			this.dgvSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSalas.Size = new System.Drawing.Size(740, 398);
			this.dgvSalas.TabIndex = 1;
			// 
			// Instituicao
			// 
			this.Instituicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Instituicao.DataPropertyName = "nm_local";
			this.Instituicao.HeaderText = "Instituição";
			this.Instituicao.Name = "Instituicao";
			this.Instituicao.ReadOnly = true;
			// 
			// Sala
			// 
			this.Sala.DataPropertyName = "nm_sala";
			this.Sala.HeaderText = "Sala";
			this.Sala.Name = "Sala";
			this.Sala.ReadOnly = true;
			this.Sala.Width = 110;
			// 
			// Capacidade
			// 
			this.Capacidade.DataPropertyName = "nr_capacidade_maxima";
			this.Capacidade.HeaderText = "Capacidade";
			this.Capacidade.Name = "Capacidade";
			this.Capacidade.ReadOnly = true;
			this.Capacidade.Width = 150;
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
			// Column1
			// 
			this.Column1.HeaderText = "";
			this.Column1.Image = global::Nsf.App.UI.Properties.Resources.edit2;
			this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column1.Width = 25;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "";
			this.Column2.Image = global::Nsf.App.UI.Properties.Resources.remove2;
			this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column2.Width = 25;
			// 
			// label68
			// 
			this.label68.AutoSize = true;
			this.label68.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label68.ForeColor = System.Drawing.Color.Black;
			this.label68.Location = new System.Drawing.Point(89, 141);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(90, 19);
			this.label68.TabIndex = 160;
			this.label68.Text = "Instituição:";
			// 
			// txtInstituicao
			// 
			this.txtInstituicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtInstituicao.Location = new System.Drawing.Point(185, 138);
			this.txtInstituicao.Name = "txtInstituicao";
			this.txtInstituicao.Size = new System.Drawing.Size(518, 27);
			this.txtInstituicao.TabIndex = 0;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::Nsf.App.UI.Properties.Resources.edit2;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewImageColumn1.Width = 50;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::Nsf.App.UI.Properties.Resources.remove2;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewImageColumn2.Width = 50;
			// 
			// frmSalaConsultar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.txtInstituicao);
			this.Controls.Add(this.label68);
			this.Controls.Add(this.dgvSalas);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pnSelected);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "frmSalaConsultar";
			this.Size = new System.Drawing.Size(800, 600);
			((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtInstituicao;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}
