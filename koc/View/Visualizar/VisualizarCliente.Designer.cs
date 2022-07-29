namespace koc.View.Visualizar
{
    partial class VisualizarCliente
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
            this.btnAlterarCli = new System.Windows.Forms.Button();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.idCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpfCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foneCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senhaCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxIdCli = new System.Windows.Forms.TextBox();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.tbxCpfCli = new System.Windows.Forms.TextBox();
            this.tbxFoneCli = new System.Windows.Forms.TextBox();
            this.tbxEmailCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCpfCli = new System.Windows.Forms.Label();
            this.lblFoneCli = new System.Windows.Forms.Label();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblSenhaCli = new System.Windows.Forms.Label();
            this.tbxSenhaCli = new System.Windows.Forms.TextBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterarCli
            // 
            this.btnAlterarCli.Location = new System.Drawing.Point(97, 399);
            this.btnAlterarCli.Name = "btnAlterarCli";
            this.btnAlterarCli.Size = new System.Drawing.Size(89, 30);
            this.btnAlterarCli.TabIndex = 1;
            this.btnAlterarCli.Text = "Alterar";
            this.btnAlterarCli.UseVisualStyleBackColor = true;
            this.btnAlterarCli.Click += new System.EventHandler(this.btnAlterarCli_Click);
            // 
            // btnDeletarCli
            // 
            this.btnDeletarCli.Location = new System.Drawing.Point(203, 399);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(89, 30);
            this.btnDeletarCli.TabIndex = 2;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.UseVisualStyleBackColor = true;
            this.btnDeletarCli.Click += new System.EventHandler(this.btnDeletarCli_Click);
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCli,
            this.nomeCli,
            this.cpfCli,
            this.foneCli,
            this.emailCli,
            this.senhaCli});
            this.lvClientes.HideSelection = false;
            this.lvClientes.Location = new System.Drawing.Point(12, 12);
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(760, 177);
            this.lvClientes.TabIndex = 3;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            this.lvClientes.SelectedIndexChanged += new System.EventHandler(this.lvClientes_SelectedIndexChanged);
            // 
            // idCli
            // 
            this.idCli.Text = "ID";
            this.idCli.Width = 64;
            // 
            // nomeCli
            // 
            this.nomeCli.Text = "Nome";
            this.nomeCli.Width = 128;
            // 
            // cpfCli
            // 
            this.cpfCli.Text = "CPF";
            this.cpfCli.Width = 128;
            // 
            // foneCli
            // 
            this.foneCli.Text = "Telefone";
            this.foneCli.Width = 128;
            // 
            // emailCli
            // 
            this.emailCli.Text = "E-mail";
            this.emailCli.Width = 128;
            // 
            // senhaCli
            // 
            this.senhaCli.Text = "Senha";
            this.senhaCli.Width = 128;
            // 
            // tbxIdCli
            // 
            this.tbxIdCli.Location = new System.Drawing.Point(97, 195);
            this.tbxIdCli.Name = "tbxIdCli";
            this.tbxIdCli.ReadOnly = true;
            this.tbxIdCli.Size = new System.Drawing.Size(455, 26);
            this.tbxIdCli.TabIndex = 4;
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(97, 230);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(455, 26);
            this.tbxNomeCli.TabIndex = 5;
            // 
            // tbxCpfCli
            // 
            this.tbxCpfCli.Location = new System.Drawing.Point(97, 265);
            this.tbxCpfCli.Name = "tbxCpfCli";
            this.tbxCpfCli.Size = new System.Drawing.Size(455, 26);
            this.tbxCpfCli.TabIndex = 6;
            // 
            // tbxFoneCli
            // 
            this.tbxFoneCli.Location = new System.Drawing.Point(97, 300);
            this.tbxFoneCli.Name = "tbxFoneCli";
            this.tbxFoneCli.Size = new System.Drawing.Size(455, 26);
            this.tbxFoneCli.TabIndex = 7;
            // 
            // tbxEmailCli
            // 
            this.tbxEmailCli.Location = new System.Drawing.Point(97, 335);
            this.tbxEmailCli.Name = "tbxEmailCli";
            this.tbxEmailCli.Size = new System.Drawing.Size(455, 26);
            this.tbxEmailCli.TabIndex = 8;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Location = new System.Drawing.Point(13, 198);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(30, 20);
            this.lblIdCli.TabIndex = 9;
            this.lblIdCli.Text = "ID:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(13, 233);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(55, 20);
            this.lblNomeCli.TabIndex = 10;
            this.lblNomeCli.Text = "Nome:";
            // 
            // lblCpfCli
            // 
            this.lblCpfCli.AutoSize = true;
            this.lblCpfCli.Location = new System.Drawing.Point(13, 268);
            this.lblCpfCli.Name = "lblCpfCli";
            this.lblCpfCli.Size = new System.Drawing.Size(44, 20);
            this.lblCpfCli.TabIndex = 11;
            this.lblCpfCli.Text = "CPF:";
            // 
            // lblFoneCli
            // 
            this.lblFoneCli.AutoSize = true;
            this.lblFoneCli.Location = new System.Drawing.Point(13, 303);
            this.lblFoneCli.Name = "lblFoneCli";
            this.lblFoneCli.Size = new System.Drawing.Size(75, 20);
            this.lblFoneCli.TabIndex = 12;
            this.lblFoneCli.Text = "Telefone:";
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Location = new System.Drawing.Point(13, 338);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(57, 20);
            this.lblEmailCli.TabIndex = 13;
            this.lblEmailCli.Text = "E-mail:";
            // 
            // lblSenhaCli
            // 
            this.lblSenhaCli.AutoSize = true;
            this.lblSenhaCli.Location = new System.Drawing.Point(13, 373);
            this.lblSenhaCli.Name = "lblSenhaCli";
            this.lblSenhaCli.Size = new System.Drawing.Size(60, 20);
            this.lblSenhaCli.TabIndex = 15;
            this.lblSenhaCli.Text = "Senha:";
            // 
            // tbxSenhaCli
            // 
            this.tbxSenhaCli.Location = new System.Drawing.Point(97, 370);
            this.tbxSenhaCli.Name = "tbxSenhaCli";
            this.tbxSenhaCli.Size = new System.Drawing.Size(455, 26);
            this.tbxSenhaCli.TabIndex = 14;
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(558, 195);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(214, 201);
            this.btnBuscarCli.TabIndex = 16;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // VisualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btnBuscarCli);
            this.Controls.Add(this.lblSenhaCli);
            this.Controls.Add(this.tbxSenhaCli);
            this.Controls.Add(this.lblEmailCli);
            this.Controls.Add(this.lblFoneCli);
            this.Controls.Add(this.lblCpfCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblIdCli);
            this.Controls.Add(this.tbxEmailCli);
            this.Controls.Add(this.tbxFoneCli);
            this.Controls.Add(this.tbxCpfCli);
            this.Controls.Add(this.tbxNomeCli);
            this.Controls.Add(this.tbxIdCli);
            this.Controls.Add(this.lvClientes);
            this.Controls.Add(this.btnDeletarCli);
            this.Controls.Add(this.btnAlterarCli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "VisualizarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlterarCli;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.ColumnHeader idCli;
        private System.Windows.Forms.ColumnHeader nomeCli;
        private System.Windows.Forms.ColumnHeader cpfCli;
        private System.Windows.Forms.ColumnHeader foneCli;
        private System.Windows.Forms.ColumnHeader emailCli;
        private System.Windows.Forms.ColumnHeader senhaCli;
        private System.Windows.Forms.TextBox tbxIdCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.TextBox tbxCpfCli;
        private System.Windows.Forms.TextBox tbxFoneCli;
        private System.Windows.Forms.TextBox tbxEmailCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCpfCli;
        private System.Windows.Forms.Label lblFoneCli;
        private System.Windows.Forms.Label lblEmailCli;
        private System.Windows.Forms.Label lblSenhaCli;
        private System.Windows.Forms.TextBox tbxSenhaCli;
        private System.Windows.Forms.Button btnBuscarCli;
    }
}