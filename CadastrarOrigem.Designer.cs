namespace Reparo
{
    partial class CadastrarOrigem
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
            this.btnAtulizar = new System.Windows.Forms.Button();
            this.txtNomeSetor = new System.Windows.Forms.TextBox();
            this.btnIserir = new System.Windows.Forms.Button();
            this.dtgvSetor = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOrigem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSetor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtulizar
            // 
            this.btnAtulizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtulizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtulizar.Location = new System.Drawing.Point(678, 233);
            this.btnAtulizar.Name = "btnAtulizar";
            this.btnAtulizar.Size = new System.Drawing.Size(173, 31);
            this.btnAtulizar.TabIndex = 11;
            this.btnAtulizar.Text = "Atualizar Setor";
            this.btnAtulizar.UseVisualStyleBackColor = true;
            this.btnAtulizar.Click += new System.EventHandler(this.BtnAtulizar_Click);
            // 
            // txtNomeSetor
            // 
            this.txtNomeSetor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSetor.Location = new System.Drawing.Point(26, 123);
            this.txtNomeSetor.Name = "txtNomeSetor";
            this.txtNomeSetor.Size = new System.Drawing.Size(232, 29);
            this.txtNomeSetor.TabIndex = 10;
            // 
            // btnIserir
            // 
            this.btnIserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIserir.Location = new System.Drawing.Point(270, 123);
            this.btnIserir.Name = "btnIserir";
            this.btnIserir.Size = new System.Drawing.Size(75, 29);
            this.btnIserir.TabIndex = 9;
            this.btnIserir.Text = "Inserir";
            this.btnIserir.UseVisualStyleBackColor = true;
            this.btnIserir.Click += new System.EventHandler(this.BtnIserir_Click);
            // 
            // dtgvSetor
            // 
            this.dtgvSetor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSetor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgvSetor.Location = new System.Drawing.Point(-1, 270);
            this.dtgvSetor.Name = "dtgvSetor";
            this.dtgvSetor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSetor.Size = new System.Drawing.Size(852, 224);
            this.dtgvSetor.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(162, 41);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 29);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(21, 13);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 25);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(26, 41);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '°';
            this.txtSenha.Size = new System.Drawing.Size(115, 29);
            this.txtSenha.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Reparo.Properties.Resources.CCInfinityLogo;
            this.pictureBox1.Location = new System.Drawing.Point(748, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.Location = new System.Drawing.Point(21, 95);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(87, 25);
            this.lblOrigem.TabIndex = 24;
            this.lblOrigem.Text = "Origem:";
            // 
            // CadastrarSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reparo.Properties.Resources._47a50a0eb0d184cba8b0351167c4ed5d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 488);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnAtulizar);
            this.Controls.Add(this.txtNomeSetor);
            this.Controls.Add(this.btnIserir);
            this.Controls.Add(this.dtgvSetor);
            this.MaximizeBox = false;
            this.Name = "CadastrarSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Origem";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSetor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtulizar;
        private System.Windows.Forms.TextBox txtNomeSetor;
        private System.Windows.Forms.Button btnIserir;
        private System.Windows.Forms.DataGridView dtgvSetor;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOrigem;
    }
}