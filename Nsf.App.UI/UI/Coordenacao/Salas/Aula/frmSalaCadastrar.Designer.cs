namespace Nsf.App.UI
{
    partial class frmSalaCadastrar
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
            this.label5 = new System.Windows.Forms.Label();
            this.pnSelected = new System.Windows.Forms.Panel();
            this.cboInstituicao = new System.Windows.Forms.ComboBox();
            this.panelId = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.nudCapacidade = new System.Windows.Forms.NumericUpDown();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(48, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "  Cadastrar Sala  ";
            // 
            // pnSelected
            // 
            this.pnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.pnSelected.Location = new System.Drawing.Point(10, 37);
            this.pnSelected.Name = "pnSelected";
            this.pnSelected.Size = new System.Drawing.Size(1000, 1);
            this.pnSelected.TabIndex = 6;
            // 
            // cboInstituicao
            // 
            this.cboInstituicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstituicao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboInstituicao.FormattingEnabled = true;
            this.cboInstituicao.Items.AddRange(new object[] {
            "Selecione",
            "Ação Social NSF",
            "Cedesp",
            "Calhim"});
            this.cboInstituicao.Location = new System.Drawing.Point(250, 240);
            this.cboInstituicao.Name = "cboInstituicao";
            this.cboInstituicao.Size = new System.Drawing.Size(388, 29);
            this.cboInstituicao.TabIndex = 0;
            // 
            // panelId
            // 
            this.panelId.Controls.Add(this.label3);
            this.panelId.Controls.Add(this.lblId);
            this.panelId.Location = new System.Drawing.Point(186, 196);
            this.panelId.Name = "panelId";
            this.panelId.Size = new System.Drawing.Size(122, 38);
            this.panelId.TabIndex = 189;
            this.panelId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 155;
            this.label3.Text = "Id:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(60, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 22);
            this.lblId.TabIndex = 156;
            this.lblId.Text = "0";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.chkAtivo.Location = new System.Drawing.Point(249, 308);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(72, 25);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // nudCapacidade
            // 
            this.nudCapacidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCapacidade.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nudCapacidade.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCapacidade.Location = new System.Drawing.Point(588, 275);
            this.nudCapacidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidade.Name = "nudCapacidade";
            this.nudCapacidade.Size = new System.Drawing.Size(50, 27);
            this.nudCapacidade.TabIndex = 2;
            this.nudCapacidade.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtSala
            // 
            this.txtSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSala.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSala.ForeColor = System.Drawing.Color.Black;
            this.txtSala.Location = new System.Drawing.Point(249, 275);
            this.txtSala.MaxLength = 50;
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(195, 27);
            this.txtSala.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(183, 280);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 19);
            this.label31.TabIndex = 185;
            this.label31.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(564, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 187;
            this.label1.Text = "*";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label33.ForeColor = System.Drawing.Color.Salmon;
            this.label33.Location = new System.Drawing.Point(225, 279);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(16, 19);
            this.label33.TabIndex = 188;
            this.label33.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Salmon;
            this.label17.Location = new System.Drawing.Point(225, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 19);
            this.label17.TabIndex = 184;
            this.label17.Text = "*";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(142)))));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.Location = new System.Drawing.Point(475, 482);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(163, 50);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(140, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 19);
            this.label18.TabIndex = 183;
            this.label18.Text = "Instituição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(450, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 186;
            this.label2.Text = "Capacidade:";
            // 
            // frmSalaCadastrar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cboInstituicao);
            this.Controls.Add(this.panelId);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.nudCapacidade);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnSelected);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSalaCadastrar";
            this.Size = new System.Drawing.Size(800, 600);
            this.panelId.ResumeLayout(false);
            this.panelId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnSelected;
        private System.Windows.Forms.ComboBox cboInstituicao;
        private System.Windows.Forms.Panel panelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.NumericUpDown nudCapacidade;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
    }
}
