namespace Nsf.App.UI
{
    partial class frmAnoLetivoConsultar
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
			this.dgvAnosLetivos = new System.Windows.Forms.DataGridView();
			this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvAnosLetivos)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.label5.Location = new System.Drawing.Point(48, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(371, 37);
			this.label5.TabIndex = 5;
			this.label5.Text = "  Consultar Anos Letivos  ";
			// 
			// pnSelected
			// 
			this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.pnSelected.Location = new System.Drawing.Point(10, 37);
			this.pnSelected.Name = "pnSelected";
			this.pnSelected.Size = new System.Drawing.Size(1000, 1);
			this.pnSelected.TabIndex = 6;
			// 
			// dgvAnosLetivos
			// 
			this.dgvAnosLetivos.AllowUserToAddRows = false;
			this.dgvAnosLetivos.AllowUserToDeleteRows = false;
			this.dgvAnosLetivos.AllowUserToResizeRows = false;
			this.dgvAnosLetivos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvAnosLetivos.ColumnHeadersHeight = 45;
			this.dgvAnosLetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvAnosLetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.Nome,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column1});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(227)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAnosLetivos.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAnosLetivos.Location = new System.Drawing.Point(85, 147);
			this.dgvAnosLetivos.Name = "dgvAnosLetivos";
			this.dgvAnosLetivos.ReadOnly = true;
			this.dgvAnosLetivos.RowHeadersVisible = false;
			this.dgvAnosLetivos.RowHeadersWidth = 45;
			this.dgvAnosLetivos.RowTemplate.Height = 25;
			this.dgvAnosLetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAnosLetivos.Size = new System.Drawing.Size(637, 350);
			this.dgvAnosLetivos.TabIndex = 0;
			// 
			// Registro
			// 
			this.Registro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Registro.DataPropertyName = "nr_ano";
			this.Registro.HeaderText = "Ano";
			this.Registro.Name = "Registro";
			this.Registro.ReadOnly = true;
			// 
			// Nome
			// 
			this.Nome.DataPropertyName = "dt_inicio";
			this.Nome.HeaderText = "Início";
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			this.Nome.Width = 140;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "dt_fim";
			this.Column3.HeaderText = "Fim";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 140;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "bt_ativo";
			this.Column4.HeaderText = "Aberto";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
			// frmAnoLetivoConsultar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.dgvAnosLetivos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pnSelected);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "frmAnoLetivoConsultar";
			this.Size = new System.Drawing.Size(800, 600);
			((System.ComponentModel.ISupportInitialize)(this.dgvAnosLetivos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
        private System.Windows.Forms.DataGridView dgvAnosLetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
