namespace Reparo
{
    partial class CadastrarCausa
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
            this.dtgvCausa = new System.Windows.Forms.DataGridView();
            this.btnIserir = new System.Windows.Forms.Button();
            this.btnAtulizar = new System.Windows.Forms.Button();
            this.txtNomeCausa = new System.Windows.Forms.TextBox();
            this.lblCausa = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCausa
            // 
            this.dtgvCausa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCausa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgvCausa.Location = new System.Drawing.Point(-12, 268);
            this.dtgvCausa.Name = "dtgvCausa";
            this.dtgvCausa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCausa.Size = new System.Drawing.Size(812, 181);
            this.dtgvCausa.TabIndex = 12;
            // 
            // btnIserir
            // 
            this.btnIserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIserir.Location = new System.Drawing.Point(270, 143);
            this.btnIserir.Name = "btnIserir";
            this.btnIserir.Size = new System.Drawing.Size(75, 29);
            this.btnIserir.TabIndex = 13;
            this.btnIserir.Text = "Inserir";
            this.btnIserir.UseVisualStyleBackColor = true;
            this.btnIserir.Click += new System.EventHandler(this.BtnIserir_Click);
            // 
            // btnAtulizar
            // 
            this.btnAtulizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtulizar.Location = new System.Drawing.Point(627, 231);
            this.btnAtulizar.Name = "btnAtulizar";
            this.btnAtulizar.Size = new System.Drawing.Size(173, 31);
            this.btnAtulizar.TabIndex = 15;
            this.btnAtulizar.Text = "Atualizar Causa";
            this.btnAtulizar.UseVisualStyleBackColor = true;
            this.btnAtulizar.Click += new System.EventHandler(this.BtnAtulizar_Click);
            // 
            // txtNomeCausa
            // 
            this.txtNomeCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCausa.Location = new System.Drawing.Point(26, 143);
            this.txtNomeCausa.Name = "txtNomeCausa";
            this.txtNomeCausa.Size = new System.Drawing.Size(232, 29);
            this.txtNomeCausa.TabIndex = 14;
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.BackColor = System.Drawing.Color.Transparent;
            this.lblCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausa.Location = new System.Drawing.Point(26, 111);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(80, 25);
            this.lblCausa.TabIndex = 16;
            this.lblCausa.Text = "Causa:";
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(26, 60);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '°';
            this.txtSenha.Size = new System.Drawing.Size(115, 29);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyUp);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(26, 32);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 25);
            this.lblSenha.TabIndex = 18;
            this.lblSenha.Text = "Senha:";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(167, 60);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Reparo.Properties.Resources.CCInfinityLogo;
            this.pictureBox1.Location = new System.Drawing.Point(700, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarCausa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reparo.Properties.Resources._47a50a0eb0d184cba8b0351167c4ed5d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblCausa);
            this.Controls.Add(this.btnAtulizar);
            this.Controls.Add(this.txtNomeCausa);
            this.Controls.Add(this.btnIserir);
            this.Controls.Add(this.dtgvCausa);
            this.MaximizeBox = false;
            this.Name = "CadastrarCausa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Causa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvCausa;
        private System.Windows.Forms.Button btnIserir;
        private System.Windows.Forms.Button btnAtulizar;
        private System.Windows.Forms.TextBox txtNomeCausa;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}