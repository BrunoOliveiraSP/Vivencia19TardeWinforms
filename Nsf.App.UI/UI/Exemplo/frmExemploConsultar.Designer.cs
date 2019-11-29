namespace Nsf.App.UI
{
    partial class frmExemploConsultar
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
            this.dgvExemplo = new System.Windows.Forms.DataGridView();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExemplo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(48, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "  Consultar Exemplo  ";
            // 
            // pnSelected
            // 
            this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.pnSelected.Location = new System.Drawing.Point(10, 37);
            this.pnSelected.Name = "pnSelected";
            this.pnSelected.Size = new System.Drawing.Size(1000, 1);
            this.pnSelected.TabIndex = 6;
            // 
            // dgvExemplo
            // 
            this.dgvExemplo.AllowUserToAddRows = false;
            this.dgvExemplo.AllowUserToDeleteRows = false;
            this.dgvExemplo.AllowUserToResizeRows = false;
            this.dgvExemplo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExemplo.ColumnHeadersHeight = 45;
            this.dgvExemplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExemplo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.Nome,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExemplo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExemplo.Location = new System.Drawing.Point(36, 185);
            this.dgvExemplo.Name = "dgvExemplo";
            this.dgvExemplo.ReadOnly = true;
            this.dgvExemplo.RowHeadersVisible = false;
            this.dgvExemplo.RowHeadersWidth = 45;
            this.dgvExemplo.RowTemplate.Height = 25;
            this.dgvExemplo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExemplo.Size = new System.Drawing.Size(742, 396);
            this.dgvExemplo.TabIndex = 2;
            // 
            // txtCurso
            // 
            this.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurso.Location = new System.Drawing.Point(115, 134);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(390, 27);
            this.txtCurso.TabIndex = 0;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(42, 137);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(61, 19);
            this.label68.TabIndex = 162;
            this.label68.Text = "Nome:";
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "Id";
            this.Registro.HeaderText = "Id";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
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
            // frmExemploConsultar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.dgvExemplo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnSelected);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmExemploConsultar";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExemplo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
        private System.Windows.Forms.DataGridView dgvExemplo;
		private System.Windows.Forms.TextBox txtCurso;
		private System.Windows.Forms.Label label68;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
