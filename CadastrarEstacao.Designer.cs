namespace Reparo
{
    partial class CadastrarEstacao
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
            this.txtNomeEsta = new System.Windows.Forms.TextBox();
            this.btnIserir = new System.Windows.Forms.Button();
            this.dtgvEstacao = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtulizar
            // 
            this.btnAtulizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtulizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtulizar.Location = new System.Drawing.Point(782, 303);
            this.btnAtulizar.Name = "btnAtulizar";
            this.btnAtulizar.Size = new System.Drawing.Size(188, 31);
            this.btnAtulizar.TabIndex = 7;
            this.btnAtulizar.Text = "Atualizar Estação";
            this.btnAtulizar.UseVisualStyleBackColor = true;
            this.btnAtulizar.Click += new System.EventHandler(this.BtnAtulizar_Click);
            // 
            // txtNomeEsta
            // 
            this.txtNomeEsta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeEsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEsta.Location = new System.Drawing.Point(12, 143);
            this.txtNomeEsta.Name = "txtNomeEsta";
            this.txtNomeEsta.Size = new System.Drawing.Size(232, 29);
            this.txtNomeEsta.TabIndex = 6;
            // 
            // btnIserir
            // 
            this.btnIserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIserir.Location = new System.Drawing.Point(256, 143);
            this.btnIserir.Name = "btnIserir";
            this.btnIserir.Size = new System.Drawing.Size(75, 29);
            this.btnIserir.TabIndex = 5;
            this.btnIserir.Text = "Inserir";
            this.btnIserir.UseVisualStyleBackColor = true;
            this.btnIserir.Click += new System.EventHandler(this.BtnIserir_Click);
            // 
            // dtgvEstacao
            // 
            this.dtgvEstacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEstacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEstacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgvEstacao.Location = new System.Drawing.Point(1, 340);
            this.dtgvEstacao.Name = "dtgvEstacao";
            this.dtgvEstacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEstacao.Size = new System.Drawing.Size(980, 213);
            this.dtgvEstacao.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(153, 63);
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
            this.lblSenha.Location = new System.Drawing.Point(12, 35);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 25);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 63);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '°';
            this.txtSenha.Size = new System.Drawing.Size(115, 29);
            this.txtSenha.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Reparo.Properties.Resources.CCInfinityLogo;
            this.pictureBox1.Location = new System.Drawing.Point(848, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblEstacao
            // 
            this.lblEstacao.AutoSize = true;
            this.lblEstacao.BackColor = System.Drawing.Color.Transparent;
            this.lblEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacao.Location = new System.Drawing.Point(12, 115);
            this.lblEstacao.Name = "lblEstacao";
            this.lblEstacao.Size = new System.Drawing.Size(96, 25);
            this.lblEstacao.TabIndex = 24;
            this.lblEstacao.Text = "Estação:";
            // 
            // CadastrarEstacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reparo.Properties.Resources._47a50a0eb0d184cba8b0351167c4ed5d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblEstacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnAtulizar);
            this.Controls.Add(this.txtNomeEsta);
            this.Controls.Add(this.btnIserir);
            this.Controls.Add(this.dtgvEstacao);
            this.MaximizeBox = false;
            this.Name = "CadastrarEstacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Estação";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtulizar;
        private System.Windows.Forms.TextBox txtNomeEsta;
        private System.Windows.Forms.Button btnIserir;
        private System.Windows.Forms.DataGridView dtgvEstacao;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstacao;
    }
}