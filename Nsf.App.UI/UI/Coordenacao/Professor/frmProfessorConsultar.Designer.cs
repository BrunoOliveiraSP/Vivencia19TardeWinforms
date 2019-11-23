namespace Nsf.App.UI
{
    partial class frmProfessorConsultar
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
			this.dgvProfessores = new System.Windows.Forms.DataGridView();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.label5.Location = new System.Drawing.Point(48, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(354, 37);
			this.label5.TabIndex = 5;
			this.label5.Text = "  Consultar Professores  ";
			// 
			// pnSelected
			// 
			this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
			this.pnSelected.Location = new System.Drawing.Point(10, 37);
			this.pnSelected.Name = "pnSelected";
			this.pnSelected.Size = new System.Drawing.Size(1000, 1);
			this.pnSelected.TabIndex = 6;
			// 
			// dgvProfessores
			// 
			this.dgvProfessores.AllowUserToAddRows = false;
			this.dgvProfessores.AllowUserToDeleteRows = false;
			this.dgvProfessores.AllowUserToResizeRows = false;
			this.dgvProfessores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvProfessores.ColumnHeadersHeight = 45;
			this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone,
            this.Email,
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
			this.dgvProfessores.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProfessores.Location = new System.Drawing.Point(26, 188);
			this.dgvProfessores.Name = "dgvProfessores";
			this.dgvProfessores.ReadOnly = true;
			this.dgvProfessores.RowHeadersVisible = false;
			this.dgvProfessores.RowHeadersWidth = 45;
			this.dgvProfessores.RowTemplate.Height = 25;
			this.dgvProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProfessores.Size = new System.Drawing.Size(744, 390);
			this.dgvProfessores.TabIndex = 1;
			// 
			// Nome
			// 
			this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nome.DataPropertyName = "nm_professor";
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			// 
			// Telefone
			// 
			this.Telefone.DataPropertyName = "ds_telefone";
			this.Telefone.HeaderText = "Telefone";
			this.Telefone.Name = "Telefone";
			this.Telefone.ReadOnly = true;
			this.Telefone.Width = 150;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "ds_email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Width = 250;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(79, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 19);
			this.label1.TabIndex = 162;
			this.label1.Text = "Nome:";
			// 
			// txtNome
			// 
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Location = new System.Drawing.Point(146, 141);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(568, 27);
			this.txtNome.TabIndex = 0;
			// 
			// frmProfessorConsultar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvProfessores);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pnSelected);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "frmProfessorConsultar";
			this.Size = new System.Drawing.Size(800, 600);
			((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
        private System.Windows.Forms.DataGridView dgvProfessores;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
