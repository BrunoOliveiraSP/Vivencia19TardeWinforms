﻿namespace Nsf.App.UI
{
    partial class frmInscricoesConsultar
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
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.cboAnoLetivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Column54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column56 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(48, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "  Consultar Candidatos  ";
            // 
            // pnSelected
            // 
            this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.pnSelected.Location = new System.Drawing.Point(10, 37);
            this.pnSelected.Name = "pnSelected";
            this.pnSelected.Size = new System.Drawing.Size(1000, 1);
            this.pnSelected.TabIndex = 6;
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.AllowUserToDeleteRows = false;
            this.dgvCandidatos.AllowUserToResizeRows = false;
            this.dgvCandidatos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCandidatos.ColumnHeadersHeight = 50;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column54,
            this.Nome,
            this.Column3,
            this.Column31,
            this.Column1,
            this.Column48,
            this.Column32,
            this.Column2,
            this.Column56});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidatos.Location = new System.Drawing.Point(10, 173);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowHeadersVisible = false;
            this.dgvCandidatos.RowHeadersWidth = 50;
            this.dgvCandidatos.RowTemplate.Height = 30;
            this.dgvCandidatos.Size = new System.Drawing.Size(768, 406);
            this.dgvCandidatos.TabIndex = 1;
            this.dgvCandidatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatos_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNome.Location = new System.Drawing.Point(147, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(384, 27);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(80, 131);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(61, 19);
            this.label68.TabIndex = 160;
            this.label68.Text = "Nome:";
            // 
            // cboAnoLetivo
            // 
            this.cboAnoLetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnoLetivo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboAnoLetivo.FormattingEnabled = true;
            this.cboAnoLetivo.Location = new System.Drawing.Point(632, 126);
            this.cboAnoLetivo.Name = "cboAnoLetivo";
            this.cboAnoLetivo.Size = new System.Drawing.Size(100, 29);
            this.cboAnoLetivo.TabIndex = 165;
            this.cboAnoLetivo.SelectedIndexChanged += new System.EventHandler(this.cboAnoLetivo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(538, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 166;
            this.label3.Text = "Ano letivo:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Nsf.App.UI.Properties.Resources.edit2;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 162;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(-129, 638);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(109, 23);
            this.lblTotal.TabIndex = 162;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column54
            // 
            this.Column54.DataPropertyName = "CdInscricao";
            this.Column54.HeaderText = "Código Inscrição";
            this.Column54.Name = "Column54";
            this.Column54.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NmInscrito";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 97;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DsRg";
            this.Column3.HeaderText = "RG";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column31
            // 
            this.Column31.DataPropertyName = "NmCurso";
            this.Column31.HeaderText = "Curso";
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NmLocal";
            this.Column1.HeaderText = "Local";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column48
            // 
            this.Column48.DataPropertyName = "NmSala";
            this.Column48.HeaderText = "Sala Vestibular";
            this.Column48.Name = "Column48";
            this.Column48.ReadOnly = true;
            // 
            // Column32
            // 
            this.Column32.DataPropertyName = "DsPeriodo";
            this.Column32.HeaderText = "Período";
            this.Column32.Name = "Column32";
            this.Column32.ReadOnly = true;
            this.Column32.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Image = global::Nsf.App.UI.Properties.Resources.edit2;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 25;
            // 
            // Column56
            // 
            this.Column56.HeaderText = "";
            this.Column56.Image = global::Nsf.App.UI.Properties.Resources.remove2;
            this.Column56.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column56.Name = "Column56";
            this.Column56.ReadOnly = true;
            this.Column56.Width = 25;
            // 
            // frmInscricoesConsultar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cboAnoLetivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnSelected);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmInscricoesConsultar";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.ComboBox cboAnoLetivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column54;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column48;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column56;
    }
}
