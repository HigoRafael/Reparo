namespace Reparo
{
    partial class CadastrarModelo
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
            this.dtgvModel = new System.Windows.Forms.DataGridView();
            this.btnIserir = new System.Windows.Forms.Button();
            this.txtNomeModel = new System.Windows.Forms.TextBox();
            this.btnAtulizaModel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblModelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvModel
            // 
            this.dtgvModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvModel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgvModel.Location = new System.Drawing.Point(-3, 284);
            this.dtgvModel.Name = "dtgvModel";
            this.dtgvModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvModel.Size = new System.Drawing.Size(844, 164);
            this.dtgvModel.TabIndex = 0;
            // 
            // btnIserir
            // 
            this.btnIserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIserir.Location = new System.Drawing.Point(286, 133);
            this.btnIserir.Name = "btnIserir";
            this.btnIserir.Size = new System.Drawing.Size(75, 32);
            this.btnIserir.TabIndex = 1;
            this.btnIserir.Text = "Inserir";
            this.btnIserir.UseVisualStyleBackColor = true;
            this.btnIserir.Click += new System.EventHandler(this.BtnIserir_Click);
            // 
            // txtNomeModel
            // 
            this.txtNomeModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeModel.Location = new System.Drawing.Point(12, 136);
            this.txtNomeModel.Name = "txtNomeModel";
            this.txtNomeModel.Size = new System.Drawing.Size(232, 29);
            this.txtNomeModel.TabIndex = 2;
            // 
            // btnAtulizaModel
            // 
            this.btnAtulizaModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtulizaModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtulizaModel.Location = new System.Drawing.Point(668, 247);
            this.btnAtulizaModel.Name = "btnAtulizaModel";
            this.btnAtulizaModel.Size = new System.Drawing.Size(173, 31);
            this.btnAtulizaModel.TabIndex = 3;
            this.btnAtulizaModel.Text = "Atualizar Modelo";
            this.btnAtulizaModel.UseVisualStyleBackColor = true;
            this.btnAtulizaModel.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(153, 57);
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
            this.lblSenha.Location = new System.Drawing.Point(12, 29);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 25);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 57);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '#';
            this.txtSenha.Size = new System.Drawing.Size(115, 29);
            this.txtSenha.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Reparo.Properties.Resources.CCInfinityLogo;
            this.pictureBox1.Location = new System.Drawing.Point(741, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(12, 108);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(89, 25);
            this.lblModelo.TabIndex = 24;
            this.lblModelo.Text = "Modelo:";
            // 
            // CadastrarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Reparo.Properties.Resources._47a50a0eb0d184cba8b0351167c4ed5d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 446);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnAtulizaModel);
            this.Controls.Add(this.txtNomeModel);
            this.Controls.Add(this.btnIserir);
            this.Controls.Add(this.dtgvModel);
            this.MaximizeBox = false;
            this.Name = "CadastrarModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Modelo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvModel;
        private System.Windows.Forms.Button btnIserir;
        private System.Windows.Forms.TextBox txtNomeModel;
        private System.Windows.Forms.Button btnAtulizaModel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblModelo;
    }
}