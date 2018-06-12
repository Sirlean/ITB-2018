namespace Agenda_C_sharp
{
    partial class BuscaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaCliente));
            this.dgvBuscaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovoBuscaCliente = new System.Windows.Forms.Button();
            this.btnSairBuscaCliente = new System.Windows.Forms.Button();
            this.btnAlterarBuscaCliente = new System.Windows.Forms.Button();
            this.btnExcluirBuscaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricaoBuscaCliente = new System.Windows.Forms.TextBox();
            this.LblDescricaoBuscaCliente = new System.Windows.Forms.Label();
            this.btnPesquisarBuscaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaCliente
            // 
            this.dgvBuscaCliente.AllowUserToAddRows = false;
            this.dgvBuscaCliente.AllowUserToDeleteRows = false;
            this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaCliente.Location = new System.Drawing.Point(21, 75);
            this.dgvBuscaCliente.Name = "dgvBuscaCliente";
            this.dgvBuscaCliente.ReadOnly = true;
            this.dgvBuscaCliente.Size = new System.Drawing.Size(515, 160);
            this.dgvBuscaCliente.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovoBuscaCliente);
            this.groupBox2.Controls.Add(this.btnSairBuscaCliente);
            this.groupBox2.Controls.Add(this.btnAlterarBuscaCliente);
            this.groupBox2.Controls.Add(this.btnExcluirBuscaCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 63);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENU";
            // 
            // btnNovoBuscaCliente
            // 
            this.btnNovoBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoBuscaCliente.Location = new System.Drawing.Point(124, 19);
            this.btnNovoBuscaCliente.Name = "btnNovoBuscaCliente";
            this.btnNovoBuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNovoBuscaCliente.TabIndex = 3;
            this.btnNovoBuscaCliente.Text = "&Novo";
            this.btnNovoBuscaCliente.UseVisualStyleBackColor = true;
            this.btnNovoBuscaCliente.Click += new System.EventHandler(this.btnNovoBuscaCliente_Click);
            // 
            // btnSairBuscaCliente
            // 
            this.btnSairBuscaCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSairBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairBuscaCliente.ForeColor = System.Drawing.Color.Magenta;
            this.btnSairBuscaCliente.Location = new System.Drawing.Point(448, 28);
            this.btnSairBuscaCliente.Name = "btnSairBuscaCliente";
            this.btnSairBuscaCliente.Size = new System.Drawing.Size(64, 29);
            this.btnSairBuscaCliente.TabIndex = 8;
            this.btnSairBuscaCliente.Text = "sair";
            this.btnSairBuscaCliente.UseVisualStyleBackColor = false;
            // 
            // btnAlterarBuscaCliente
            // 
            this.btnAlterarBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarBuscaCliente.Location = new System.Drawing.Point(248, 19);
            this.btnAlterarBuscaCliente.Name = "btnAlterarBuscaCliente";
            this.btnAlterarBuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarBuscaCliente.TabIndex = 5;
            this.btnAlterarBuscaCliente.Text = "&Alterar";
            this.btnAlterarBuscaCliente.UseVisualStyleBackColor = true;
            this.btnAlterarBuscaCliente.Click += new System.EventHandler(this.btnAlterarBuscaCliente_Click);
            // 
            // btnExcluirBuscaCliente
            // 
            this.btnExcluirBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirBuscaCliente.Location = new System.Drawing.Point(351, 19);
            this.btnExcluirBuscaCliente.Name = "btnExcluirBuscaCliente";
            this.btnExcluirBuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirBuscaCliente.TabIndex = 6;
            this.btnExcluirBuscaCliente.Text = "&Excluir";
            this.btnExcluirBuscaCliente.UseVisualStyleBackColor = true;
            this.btnExcluirBuscaCliente.Click += new System.EventHandler(this.btnExcluirBuscaCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescricaoBuscaCliente);
            this.groupBox1.Controls.Add(this.LblDescricaoBuscaCliente);
            this.groupBox1.Controls.Add(this.btnPesquisarBuscaCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // txtDescricaoBuscaCliente
            // 
            this.txtDescricaoBuscaCliente.Location = new System.Drawing.Point(85, 22);
            this.txtDescricaoBuscaCliente.Name = "txtDescricaoBuscaCliente";
            this.txtDescricaoBuscaCliente.Size = new System.Drawing.Size(313, 20);
            this.txtDescricaoBuscaCliente.TabIndex = 2;
            // 
            // LblDescricaoBuscaCliente
            // 
            this.LblDescricaoBuscaCliente.AutoSize = true;
            this.LblDescricaoBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricaoBuscaCliente.Location = new System.Drawing.Point(5, 23);
            this.LblDescricaoBuscaCliente.Name = "LblDescricaoBuscaCliente";
            this.LblDescricaoBuscaCliente.Size = new System.Drawing.Size(73, 16);
            this.LblDescricaoBuscaCliente.TabIndex = 1;
            this.LblDescricaoBuscaCliente.Text = "Descrição:";
            // 
            // btnPesquisarBuscaCliente
            // 
            this.btnPesquisarBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBuscaCliente.Location = new System.Drawing.Point(404, 23);
            this.btnPesquisarBuscaCliente.Name = "btnPesquisarBuscaCliente";
            this.btnPesquisarBuscaCliente.Size = new System.Drawing.Size(88, 25);
            this.btnPesquisarBuscaCliente.TabIndex = 7;
            this.btnPesquisarBuscaCliente.Text = "P&esquisar";
            this.btnPesquisarBuscaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarBuscaCliente.Click += new System.EventHandler(this.btnPesquisarBuscaCliente_Click);
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 338);
            this.Controls.Add(this.dgvBuscaCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaCliente";
            this.Text = "BuscaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSairBuscaCliente;
        private System.Windows.Forms.Button btnAlterarBuscaCliente;
        private System.Windows.Forms.Button btnExcluirBuscaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricaoBuscaCliente;
        private System.Windows.Forms.Label LblDescricaoBuscaCliente;
        private System.Windows.Forms.Button btnPesquisarBuscaCliente;
        private System.Windows.Forms.Button btnNovoBuscaCliente;
    }
}