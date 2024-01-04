namespace Reparo
{
    partial class frmReparo
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
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtPosMec = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblEstac = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblCausa = new System.Windows.Forms.Label();
            this.lblPosMec = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dtgvReparo = new System.Windows.Forms.DataGridView();
            this.cmbCausa = new System.Windows.Forms.ComboBox();
            this.cmbEstacao = new System.Windows.Forms.ComboBox();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cmbMatriculaTec = new System.Windows.Forms.ComboBox();
            this.lblDefData = new System.Windows.Forms.Label();
            this.lblReparo = new System.Windows.Forms.Label();
            this.txtConsPlaca = new System.Windows.Forms.TextBox();
            this.lblConsPlaca = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnFixar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCdEstacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCdCausa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCdModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCdSetor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCdTecnico = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReparo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbModelo
            // 
            this.cmbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(58, 157);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(362, 32);
            this.cmbModelo.TabIndex = 2;
            this.cmbModelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbModelo_KeyUp);
            // 
            // txtDefeito
            // 
            this.txtDefeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefeito.Location = new System.Drawing.Point(58, 417);
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(362, 31);
            this.txtDefeito.TabIndex = 5;
            this.txtDefeito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDefeito_KeyUp);
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(58, 328);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(362, 29);
            this.txtNumSerie.TabIndex = 4;
            this.txtNumSerie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumSerie_KeyUp);
            // 
            // txtPosMec
            // 
            this.txtPosMec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPosMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosMec.Location = new System.Drawing.Point(623, 160);
            this.txtPosMec.Name = "txtPosMec";
            this.txtPosMec.Size = new System.Drawing.Size(362, 29);
            this.txtPosMec.TabIndex = 6;
            this.txtPosMec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPosMec_KeyUp);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(58, 43);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(106, 25);
            this.lblMatricula.TabIndex = 9;
            this.lblMatricula.Text = "Matricula:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(58, 120);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(89, 25);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblEstac
            // 
            this.lblEstac.AutoSize = true;
            this.lblEstac.BackColor = System.Drawing.Color.Transparent;
            this.lblEstac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstac.Location = new System.Drawing.Point(55, 202);
            this.lblEstac.Name = "lblEstac";
            this.lblEstac.Size = new System.Drawing.Size(96, 25);
            this.lblEstac.TabIndex = 11;
            this.lblEstac.Text = "Estação:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.BackColor = System.Drawing.Color.Transparent;
            this.lblDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDef.Location = new System.Drawing.Point(58, 380);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(86, 25);
            this.lblDef.TabIndex = 12;
            this.lblDef.Text = "Defeito:";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(58, 289);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(179, 25);
            this.lblNumSerie.TabIndex = 13;
            this.lblNumSerie.Text = "Numero de Serie:";
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.BackColor = System.Drawing.Color.Transparent;
            this.lblCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausa.Location = new System.Drawing.Point(622, 202);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(80, 25);
            this.lblCausa.TabIndex = 14;
            this.lblCausa.Text = "Causa:";
            // 
            // lblPosMec
            // 
            this.lblPosMec.AutoSize = true;
            this.lblPosMec.BackColor = System.Drawing.Color.Transparent;
            this.lblPosMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosMec.Location = new System.Drawing.Point(624, 121);
            this.lblPosMec.Name = "lblPosMec";
            this.lblPosMec.Size = new System.Drawing.Size(194, 25);
            this.lblPosMec.TabIndex = 15;
            this.lblPosMec.Text = "Posição Mecânica:";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.BackColor = System.Drawing.Color.Transparent;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(624, 290);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(87, 25);
            this.lblSetor.TabIndex = 16;
            this.lblSetor.Text = "Origem:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(624, 45);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 25);
            this.lblData.TabIndex = 17;
            this.lblData.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(623, 76);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(117, 29);
            this.txtData.TabIndex = 18;
            // 
            // dtgvReparo
            // 
            this.dtgvReparo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvReparo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReparo.Location = new System.Drawing.Point(-2, 570);
            this.dtgvReparo.MultiSelect = false;
            this.dtgvReparo.Name = "dtgvReparo";
            this.dtgvReparo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvReparo.Size = new System.Drawing.Size(1053, 196);
            this.dtgvReparo.TabIndex = 19;
            // 
            // cmbCausa
            // 
            this.cmbCausa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCausa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCausa.FormattingEnabled = true;
            this.cmbCausa.Location = new System.Drawing.Point(623, 239);
            this.cmbCausa.Name = "cmbCausa";
            this.cmbCausa.Size = new System.Drawing.Size(362, 33);
            this.cmbCausa.TabIndex = 7;
            this.cmbCausa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbCausa_KeyUp);
            // 
            // cmbEstacao
            // 
            this.cmbEstacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEstacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstacao.FormattingEnabled = true;
            this.cmbEstacao.Location = new System.Drawing.Point(58, 239);
            this.cmbEstacao.Name = "cmbEstacao";
            this.cmbEstacao.Size = new System.Drawing.Size(362, 33);
            this.cmbEstacao.TabIndex = 3;
            this.cmbEstacao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbEstacao_KeyUp);
            // 
            // cmbSetor
            // 
            this.cmbSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(623, 325);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(362, 32);
            this.cmbSetor.TabIndex = 8;
            this.cmbSetor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbSetor_KeyUp);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(847, 527);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(189, 37);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar Registro";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // cmbMatriculaTec
            // 
            this.cmbMatriculaTec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMatriculaTec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMatriculaTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatriculaTec.FormattingEnabled = true;
            this.cmbMatriculaTec.Location = new System.Drawing.Point(58, 71);
            this.cmbMatriculaTec.Name = "cmbMatriculaTec";
            this.cmbMatriculaTec.Size = new System.Drawing.Size(120, 32);
            this.cmbMatriculaTec.TabIndex = 1;
            this.cmbMatriculaTec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbNomeTec_KeyUp);
            // 
            // lblDefData
            // 
            this.lblDefData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefData.AutoSize = true;
            this.lblDefData.BackColor = System.Drawing.Color.Transparent;
            this.lblDefData.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefData.ForeColor = System.Drawing.Color.Blue;
            this.lblDefData.Location = new System.Drawing.Point(980, 7);
            this.lblDefData.Name = "lblDefData";
            this.lblDefData.Size = new System.Drawing.Size(23, 33);
            this.lblDefData.TabIndex = 21;
            this.lblDefData.Text = ".";
            // 
            // lblReparo
            // 
            this.lblReparo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReparo.AutoSize = true;
            this.lblReparo.BackColor = System.Drawing.Color.Transparent;
            this.lblReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparo.ForeColor = System.Drawing.Color.Blue;
            this.lblReparo.Location = new System.Drawing.Point(853, 11);
            this.lblReparo.Name = "lblReparo";
            this.lblReparo.Size = new System.Drawing.Size(124, 20);
            this.lblReparo.TabIndex = 22;
            this.lblReparo.Text = "Reparos diários:";
            // 
            // txtConsPlaca
            // 
            this.txtConsPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsPlaca.Location = new System.Drawing.Point(61, 516);
            this.txtConsPlaca.Name = "txtConsPlaca";
            this.txtConsPlaca.Size = new System.Drawing.Size(362, 31);
            this.txtConsPlaca.TabIndex = 23;
            this.txtConsPlaca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtConsPlaca_KeyUp);
            // 
            // lblConsPlaca
            // 
            this.lblConsPlaca.AutoSize = true;
            this.lblConsPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblConsPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsPlaca.Location = new System.Drawing.Point(58, 488);
            this.lblConsPlaca.Name = "lblConsPlaca";
            this.lblConsPlaca.Size = new System.Drawing.Size(170, 25);
            this.lblConsPlaca.TabIndex = 24;
            this.lblConsPlaca.Text = "Consultar Placa:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(208, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(18, 25);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = ".";
            // 
            // btnFixar
            // 
            this.btnFixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixar.Location = new System.Drawing.Point(2, 71);
            this.btnFixar.Name = "btnFixar";
            this.btnFixar.Size = new System.Drawing.Size(50, 32);
            this.btnFixar.TabIndex = 20;
            this.btnFixar.Text = "Fixar ";
            this.btnFixar.UseVisualStyleBackColor = true;
            this.btnFixar.Click += new System.EventHandler(this.BtnFixar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Reparo.Properties.Resources.CCInfinityLogo;
            this.pictureBox1.Location = new System.Drawing.Point(860, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 33);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnCadastrar
            // 
            this.mnCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCdEstacao,
            this.mnCdCausa,
            this.mnCdModelo,
            this.mnCdSetor,
            this.mnCdTecnico});
            this.mnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnCadastrar.Name = "mnCadastrar";
            this.mnCadastrar.Size = new System.Drawing.Size(105, 29);
            this.mnCadastrar.Text = "Cadastrar";
            // 
            // mnCdEstacao
            // 
            this.mnCdEstacao.BackColor = System.Drawing.Color.Transparent;
            this.mnCdEstacao.Name = "mnCdEstacao";
            this.mnCdEstacao.Size = new System.Drawing.Size(235, 30);
            this.mnCdEstacao.Text = "Cadastrar Estação";
            this.mnCdEstacao.Click += new System.EventHandler(this.MnCdEstacao_Click);
            // 
            // mnCdCausa
            // 
            this.mnCdCausa.Name = "mnCdCausa";
            this.mnCdCausa.Size = new System.Drawing.Size(235, 30);
            this.mnCdCausa.Text = "Cadastrar Causa";
            this.mnCdCausa.Click += new System.EventHandler(this.MnCdCausa_Click);
            // 
            // mnCdModelo
            // 
            this.mnCdModelo.Name = "mnCdModelo";
            this.mnCdModelo.Size = new System.Drawing.Size(235, 30);
            this.mnCdModelo.Text = "Cadastrar Modelo";
            this.mnCdModelo.Click += new System.EventHandler(this.MnCdModelo_Click);
            // 
            // mnCdSetor
            // 
            this.mnCdSetor.Name = "mnCdSetor";
            this.mnCdSetor.Size = new System.Drawing.Size(235, 30);
            this.mnCdSetor.Text = "Cadastrar Origem";
            this.mnCdSetor.Click += new System.EventHandler(this.MnCdSetor_Click);
            // 
            // mnCdTecnico
            // 
            this.mnCdTecnico.Name = "mnCdTecnico";
            this.mnCdTecnico.Size = new System.Drawing.Size(235, 30);
            this.mnCdTecnico.Text = "Cadastrar Tecnico";
            this.mnCdTecnico.Click += new System.EventHandler(this.MnCdTecnico_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(623, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(362, 54);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Inserir Reparo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // frmReparo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Reparo.Properties.Resources.background_723052_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 746);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblConsPlaca);
            this.Controls.Add(this.txtConsPlaca);
            this.Controls.Add(this.lblReparo);
            this.Controls.Add(this.lblDefData);
            this.Controls.Add(this.cmbMatriculaTec);
            this.Controls.Add(this.btnFixar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.cmbEstacao);
            this.Controls.Add(this.cmbCausa);
            this.Controls.Add(this.dtgvReparo);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblPosMec);
            this.Controls.Add(this.lblCausa);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.lblDef);
            this.Controls.Add(this.lblEstac);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtPosMec);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtDefeito);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmReparo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Reparo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReparo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtPosMec;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblEstac;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.Label lblPosMec;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridView dtgvReparo;
        private System.Windows.Forms.ComboBox cmbCausa;
        private System.Windows.Forms.ComboBox cmbEstacao;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnFixar;
        private System.Windows.Forms.ComboBox cmbMatriculaTec;
        private System.Windows.Forms.Label lblDefData;
        private System.Windows.Forms.Label lblReparo;
        private System.Windows.Forms.TextBox txtConsPlaca;
        private System.Windows.Forms.Label lblConsPlaca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolStripMenuItem mnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem mnCdEstacao;
        private System.Windows.Forms.ToolStripMenuItem mnCdCausa;
        private System.Windows.Forms.ToolStripMenuItem mnCdModelo;
        private System.Windows.Forms.ToolStripMenuItem mnCdSetor;
        private System.Windows.Forms.ToolStripMenuItem mnCdTecnico;
    }
}

