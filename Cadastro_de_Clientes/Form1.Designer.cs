namespace Cadastro_de_Clientes
{
    partial class CadCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCliente));
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label19 = new Label();
            label20 = new Label();
            TxtNome = new TextBox();
            TxtNumero = new TextBox();
            TxtEmail = new TextBox();
            label13 = new Label();
            TxtObs = new TextBox();
            label14 = new Label();
            CkSituacao = new CheckBox();
            TxtDoc = new MaskedTextBox();
            TxtNasc = new MaskedTextBox();
            TxtCep = new MaskedTextBox();
            TxtRG = new MaskedTextBox();
            OpCNPJ = new RadioButton();
            OpCPF = new RadioButton();
            label1 = new Label();
            TxtCelular = new MaskedTextBox();
            CbEstado = new ComboBox();
            CbCiivil = new ComboBox();
            CbEndereco = new ComboBox();
            CbBairro = new ComboBox();
            CbCidade = new ComboBox();
            ImgCliente = new PictureBox();
            BtAddFoto = new Button();
            BtRemoveFoto = new Button();
            BtExcluir = new Button();
            BtNovo = new Button();
            BtSalvar = new Button();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            label2 = new Label();
            CbGenero = new ComboBox();
            BtnPesquisar = new Button();
            TxtAlterar = new Button();
            textBox1 = new TextBox();
            BtnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)ImgCliente).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(349, 99);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 1;
            label3.Text = "Nome do Cliente";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(604, 323);
            label5.Name = "label5";
            label5.Size = new Size(123, 30);
            label5.TabIndex = 6;
            label5.Text = "Estado Civil";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(353, 323);
            label6.Name = "label6";
            label6.Size = new Size(41, 30);
            label6.TabIndex = 5;
            label6.Text = "RG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(960, 323);
            label7.Name = "label7";
            label7.Size = new Size(208, 30);
            label7.TabIndex = 7;
            label7.Text = "Data de Nascimento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(88, 437);
            label8.Name = "label8";
            label8.Size = new Size(50, 30);
            label8.TabIndex = 8;
            label8.Text = "CEP";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(277, 437);
            label9.Name = "label9";
            label9.Size = new Size(104, 30);
            label9.TabIndex = 9;
            label9.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(1130, 426);
            label10.Name = "label10";
            label10.Size = new Size(38, 30);
            label10.TabIndex = 10;
            label10.Text = "Nº";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(619, 564);
            label11.Name = "label11";
            label11.Size = new Size(81, 30);
            label11.TabIndex = 12;
            label11.Text = "Cidade";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(79, 564);
            label12.Name = "label12";
            label12.Size = new Size(71, 30);
            label12.TabIndex = 11;
            label12.Text = "Bairro";
            label12.Click += label12_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.ForeColor = Color.SteelBlue;
            label19.Location = new Point(619, 642);
            label19.Name = "label19";
            label19.Size = new Size(73, 30);
            label19.TabIndex = 15;
            label19.Text = "E-mail";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.ForeColor = Color.SteelBlue;
            label20.Location = new Point(79, 642);
            label20.Name = "label20";
            label20.Size = new Size(77, 30);
            label20.TabIndex = 13;
            label20.Text = "Estado";
            // 
            // TxtNome
            // 
            TxtNome.ForeColor = Color.SteelBlue;
            TxtNome.Location = new Point(349, 132);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(836, 37);
            TxtNome.TabIndex = 1;
            TxtNome.TextChanged += textBox1_TextChanged;
            // 
            // TxtNumero
            // 
            TxtNumero.BorderStyle = BorderStyle.None;
            TxtNumero.ForeColor = Color.SteelBlue;
            TxtNumero.Location = new Point(1102, 470);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(83, 30);
            TxtNumero.TabIndex = 11;
            TxtNumero.TextChanged += textBox10_TextChanged;
            // 
            // TxtEmail
            // 
            TxtEmail.ForeColor = Color.SteelBlue;
            TxtEmail.Location = new Point(619, 675);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(566, 37);
            TxtEmail.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = Color.SteelBlue;
            label13.Location = new Point(79, 771);
            label13.Name = "label13";
            label13.Size = new Size(138, 30);
            label13.TabIndex = 16;
            label13.Text = "Observações";
            // 
            // TxtObs
            // 
            TxtObs.ForeColor = Color.SteelBlue;
            TxtObs.Location = new Point(79, 804);
            TxtObs.Multiline = true;
            TxtObs.Name = "TxtObs";
            TxtObs.Size = new Size(1106, 173);
            TxtObs.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.ForeColor = Color.SteelBlue;
            label14.Location = new Point(79, 1003);
            label14.Name = "label14";
            label14.Size = new Size(189, 30);
            label14.TabIndex = 1;
            label14.Text = "Situação Cadastral";
            // 
            // CkSituacao
            // 
            CkSituacao.AutoSize = true;
            CkSituacao.BackColor = Color.Transparent;
            CkSituacao.Checked = true;
            CkSituacao.CheckState = CheckState.Checked;
            CkSituacao.ForeColor = Color.SteelBlue;
            CkSituacao.Location = new Point(285, 1002);
            CkSituacao.Name = "CkSituacao";
            CkSituacao.Size = new Size(89, 34);
            CkSituacao.TabIndex = 4;
            CkSituacao.TabStop = false;
            CkSituacao.Text = "Ativo";
            CkSituacao.UseVisualStyleBackColor = false;
            // 
            // TxtDoc
            // 
            TxtDoc.BeepOnError = true;
            TxtDoc.ForeColor = Color.SteelBlue;
            TxtDoc.Location = new Point(353, 248);
            TxtDoc.Mask = "000,000,000-00";
            TxtDoc.Name = "TxtDoc";
            TxtDoc.Size = new Size(178, 37);
            TxtDoc.TabIndex = 2;
            // 
            // TxtNasc
            // 
            TxtNasc.ForeColor = Color.SteelBlue;
            TxtNasc.Location = new Point(960, 356);
            TxtNasc.Mask = "00/00/0000";
            TxtNasc.Name = "TxtNasc";
            TxtNasc.Size = new Size(225, 37);
            TxtNasc.TabIndex = 8;
            // 
            // TxtCep
            // 
            TxtCep.ForeColor = Color.SteelBlue;
            TxtCep.Location = new Point(79, 470);
            TxtCep.Mask = "00000-000";
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(177, 37);
            TxtCep.TabIndex = 9;
            // 
            // TxtRG
            // 
            TxtRG.ForeColor = Color.SteelBlue;
            TxtRG.Location = new Point(353, 356);
            TxtRG.Mask = "00,000,000-0";
            TxtRG.Name = "TxtRG";
            TxtRG.Size = new Size(178, 37);
            TxtRG.TabIndex = 6;
            // 
            // OpCNPJ
            // 
            OpCNPJ.AutoSize = true;
            OpCNPJ.BackColor = Color.Transparent;
            OpCNPJ.ForeColor = Color.SteelBlue;
            OpCNPJ.Location = new Point(440, 208);
            OpCNPJ.Name = "OpCNPJ";
            OpCNPJ.Size = new Size(87, 34);
            OpCNPJ.TabIndex = 4;
            OpCNPJ.Text = "CNPJ";
            OpCNPJ.UseVisualStyleBackColor = false;
            OpCNPJ.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // OpCPF
            // 
            OpCPF.AutoSize = true;
            OpCPF.BackColor = Color.Transparent;
            OpCPF.ForeColor = Color.SteelBlue;
            OpCPF.Location = new Point(359, 208);
            OpCPF.Name = "OpCPF";
            OpCPF.Size = new Size(75, 34);
            OpCPF.TabIndex = 3;
            OpCPF.TabStop = true;
            OpCPF.Text = "CPF";
            OpCPF.TextImageRelation = TextImageRelation.ImageBeforeText;
            OpCPF.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(391, 642);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 14;
            label1.Text = "Celular";
            // 
            // TxtCelular
            // 
            TxtCelular.ForeColor = Color.SteelBlue;
            TxtCelular.Location = new Point(391, 675);
            TxtCelular.Mask = "(00) 0 0000-0000";
            TxtCelular.Name = "TxtCelular";
            TxtCelular.Size = new Size(208, 37);
            TxtCelular.TabIndex = 15;
            // 
            // CbEstado
            // 
            CbEstado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbEstado.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbEstado.DropDownHeight = 200;
            CbEstado.ForeColor = Color.SteelBlue;
            CbEstado.FormattingEnabled = true;
            CbEstado.IntegralHeight = false;
            CbEstado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            CbEstado.Location = new Point(86, 675);
            CbEstado.Name = "CbEstado";
            CbEstado.Size = new Size(288, 38);
            CbEstado.TabIndex = 14;
            // 
            // CbCiivil
            // 
            CbCiivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbCiivil.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbCiivil.DropDownHeight = 200;
            CbCiivil.ForeColor = Color.SteelBlue;
            CbCiivil.FormattingEnabled = true;
            CbCiivil.IntegralHeight = false;
            CbCiivil.Location = new Point(604, 356);
            CbCiivil.Name = "CbCiivil";
            CbCiivil.Size = new Size(288, 38);
            CbCiivil.TabIndex = 7;
            CbCiivil.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // CbEndereco
            // 
            CbEndereco.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbEndereco.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbEndereco.DropDownHeight = 200;
            CbEndereco.ForeColor = Color.SteelBlue;
            CbEndereco.FormattingEnabled = true;
            CbEndereco.IntegralHeight = false;
            CbEndereco.Location = new Point(277, 470);
            CbEndereco.Name = "CbEndereco";
            CbEndereco.Size = new Size(796, 38);
            CbEndereco.TabIndex = 10;
            CbEndereco.SelectedIndexChanged += CbEndereco_SelectedIndexChanged;
            // 
            // CbBairro
            // 
            CbBairro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbBairro.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbBairro.DropDownHeight = 200;
            CbBairro.ForeColor = Color.SteelBlue;
            CbBairro.FormattingEnabled = true;
            CbBairro.IntegralHeight = false;
            CbBairro.Location = new Point(79, 597);
            CbBairro.Name = "CbBairro";
            CbBairro.Size = new Size(520, 38);
            CbBairro.TabIndex = 12;
            // 
            // CbCidade
            // 
            CbCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbCidade.DropDownHeight = 200;
            CbCidade.ForeColor = Color.SteelBlue;
            CbCidade.FormattingEnabled = true;
            CbCidade.IntegralHeight = false;
            CbCidade.Location = new Point(619, 597);
            CbCidade.Name = "CbCidade";
            CbCidade.Size = new Size(566, 38);
            CbCidade.TabIndex = 13;
            CbCidade.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // ImgCliente
            // 
            ImgCliente.BackColor = Color.Transparent;
            ImgCliente.BorderStyle = BorderStyle.FixedSingle;
            ImgCliente.Image = (Image)resources.GetObject("ImgCliente.Image");
            ImgCliente.Location = new Point(79, 99);
            ImgCliente.Name = "ImgCliente";
            ImgCliente.Size = new Size(217, 230);
            ImgCliente.SizeMode = PictureBoxSizeMode.Zoom;
            ImgCliente.TabIndex = 8;
            ImgCliente.TabStop = false;
            ImgCliente.Click += pictureBox1_Click;
            // 
            // BtAddFoto
            // 
            BtAddFoto.BackColor = Color.DarkOrange;
            BtAddFoto.Cursor = Cursors.Hand;
            BtAddFoto.FlatStyle = FlatStyle.Flat;
            BtAddFoto.Font = new Font("Segoe UI", 9F);
            BtAddFoto.ForeColor = Color.White;
            BtAddFoto.Image = (Image)resources.GetObject("BtAddFoto.Image");
            BtAddFoto.Location = new Point(79, 356);
            BtAddFoto.Name = "BtAddFoto";
            BtAddFoto.Size = new Size(158, 52);
            BtAddFoto.TabIndex = 9;
            BtAddFoto.TabStop = false;
            BtAddFoto.Text = "Imagem";
            BtAddFoto.TextAlign = ContentAlignment.MiddleRight;
            BtAddFoto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtAddFoto.UseVisualStyleBackColor = false;
            // 
            // BtRemoveFoto
            // 
            BtRemoveFoto.BackColor = Color.Silver;
            BtRemoveFoto.Cursor = Cursors.Hand;
            BtRemoveFoto.FlatStyle = FlatStyle.Flat;
            BtRemoveFoto.Font = new Font("Segoe UI", 9F);
            BtRemoveFoto.ForeColor = Color.White;
            BtRemoveFoto.Image = (Image)resources.GetObject("BtRemoveFoto.Image");
            BtRemoveFoto.Location = new Point(243, 356);
            BtRemoveFoto.Name = "BtRemoveFoto";
            BtRemoveFoto.Size = new Size(53, 52);
            BtRemoveFoto.TabIndex = 9;
            BtRemoveFoto.TabStop = false;
            BtRemoveFoto.TextAlign = ContentAlignment.MiddleRight;
            BtRemoveFoto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtRemoveFoto.UseVisualStyleBackColor = false;
            // 
            // BtExcluir
            // 
            BtExcluir.BackColor = Color.Black;
            BtExcluir.Cursor = Cursors.Hand;
            BtExcluir.FlatStyle = FlatStyle.Flat;
            BtExcluir.Font = new Font("Segoe UI", 9F);
            BtExcluir.ForeColor = Color.White;
            BtExcluir.Image = (Image)resources.GetObject("BtExcluir.Image");
            BtExcluir.Location = new Point(79, 1060);
            BtExcluir.Name = "BtExcluir";
            BtExcluir.Size = new Size(158, 52);
            BtExcluir.TabIndex = 18;
            BtExcluir.TabStop = false;
            BtExcluir.Text = "Excluir";
            BtExcluir.TextAlign = ContentAlignment.MiddleRight;
            BtExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtExcluir.UseVisualStyleBackColor = false;
            BtExcluir.Click += buttonExcluir_Click;
            // 
            // BtNovo
            // 
            BtNovo.BackColor = SystemColors.Highlight;
            BtNovo.Cursor = Cursors.Hand;
            BtNovo.FlatStyle = FlatStyle.Flat;
            BtNovo.Font = new Font("Segoe UI", 9F);
            BtNovo.ForeColor = Color.White;
            BtNovo.Image = (Image)resources.GetObject("BtNovo.Image");
            BtNovo.Location = new Point(256, 1060);
            BtNovo.Name = "BtNovo";
            BtNovo.Size = new Size(158, 52);
            BtNovo.TabIndex = 19;
            BtNovo.TabStop = false;
            BtNovo.Text = "Novo";
            BtNovo.TextAlign = ContentAlignment.MiddleRight;
            BtNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtNovo.UseVisualStyleBackColor = false;
            BtNovo.Click += BtNovo_Click;
            // 
            // BtSalvar
            // 
            BtSalvar.BackColor = Color.FromArgb(0, 192, 192);
            BtSalvar.Cursor = Cursors.Hand;
            BtSalvar.FlatStyle = FlatStyle.Flat;
            BtSalvar.Font = new Font("Segoe UI", 9F);
            BtSalvar.ForeColor = Color.White;
            BtSalvar.Image = (Image)resources.GetObject("BtSalvar.Image");
            BtSalvar.Location = new Point(1027, 1060);
            BtSalvar.Name = "BtSalvar";
            BtSalvar.Size = new Size(158, 52);
            BtSalvar.TabIndex = 20;
            BtSalvar.Text = "Salvar";
            BtSalvar.TextAlign = ContentAlignment.MiddleRight;
            BtSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtSalvar.UseVisualStyleBackColor = false;
            BtSalvar.Click += button3_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(897, 214);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 6;
            label2.Text = "Gênero";
            label2.Click += label2_Click;
            // 
            // CbGenero
            // 
            CbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbGenero.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbGenero.DropDownHeight = 200;
            CbGenero.ForeColor = Color.SteelBlue;
            CbGenero.FormattingEnabled = true;
            CbGenero.IntegralHeight = false;
            CbGenero.Location = new Point(897, 247);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(288, 38);
            CbGenero.TabIndex = 7;
            CbGenero.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(128, 128, 255);
            BtnPesquisar.Cursor = Cursors.Hand;
            BtnPesquisar.FlatStyle = FlatStyle.Flat;
            BtnPesquisar.Font = new Font("Segoe UI", 9F);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Image = (Image)resources.GetObject("BtnPesquisar.Image");
            BtnPesquisar.Location = new Point(824, 1060);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(158, 52);
            BtnPesquisar.TabIndex = 19;
            BtnPesquisar.TabStop = false;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            BtnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += buttonPesquisar_Click;
            // 
            // TxtAlterar
            // 
            TxtAlterar.BackColor = Color.FromArgb(192, 0, 0);
            TxtAlterar.Cursor = Cursors.Hand;
            TxtAlterar.FlatStyle = FlatStyle.Flat;
            TxtAlterar.Font = new Font("Segoe UI", 9F);
            TxtAlterar.ForeColor = Color.White;
            TxtAlterar.Image = (Image)resources.GetObject("TxtAlterar.Image");
            TxtAlterar.Location = new Point(634, 1060);
            TxtAlterar.Name = "TxtAlterar";
            TxtAlterar.Size = new Size(158, 52);
            TxtAlterar.TabIndex = 19;
            TxtAlterar.TabStop = false;
            TxtAlterar.Text = "Alterar";
            TxtAlterar.TextAlign = ContentAlignment.MiddleRight;
            TxtAlterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            TxtAlterar.UseVisualStyleBackColor = false;
            TxtAlterar.Click += buttonAlterar_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.SteelBlue;
            textBox1.Location = new Point(1236, 132);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(764, 550);
            textBox1.TabIndex = 17;
            // 
            // BtnConsultar
            // 
            BtnConsultar.BackColor = Color.FromArgb(0, 192, 192);
            BtnConsultar.Cursor = Cursors.Hand;
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.Font = new Font("Segoe UI", 9F);
            BtnConsultar.ForeColor = Color.White;
            BtnConsultar.Image = (Image)resources.GetObject("BtnConsultar.Image");
            BtnConsultar.Location = new Point(1433, 723);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(318, 52);
            BtnConsultar.TabIndex = 20;
            BtnConsultar.Text = "Consultar Todos";
            BtnConsultar.TextAlign = ContentAlignment.MiddleRight;
            BtnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnConsultar.UseVisualStyleBackColor = false;
            BtnConsultar.Click += buttonPreencherTextBox_Click;
            // 
            // CadCliente
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Captura_de_tela_2024_07_26_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2039, 1135);
            Controls.Add(BtRemoveFoto);
            Controls.Add(BtnConsultar);
            Controls.Add(BtSalvar);
            Controls.Add(TxtAlterar);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtNovo);
            Controls.Add(BtExcluir);
            Controls.Add(BtAddFoto);
            Controls.Add(ImgCliente);
            Controls.Add(CbCidade);
            Controls.Add(CbBairro);
            Controls.Add(CbEndereco);
            Controls.Add(CbGenero);
            Controls.Add(CbCiivil);
            Controls.Add(CbEstado);
            Controls.Add(OpCPF);
            Controls.Add(OpCNPJ);
            Controls.Add(TxtCelular);
            Controls.Add(TxtCep);
            Controls.Add(TxtNasc);
            Controls.Add(TxtRG);
            Controls.Add(TxtDoc);
            Controls.Add(CkSituacao);
            Controls.Add(TxtEmail);
            Controls.Add(textBox1);
            Controls.Add(TxtObs);
            Controls.Add(TxtNumero);
            Controls.Add(TxtNome);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(label20);
            Controls.Add(label12);
            Controls.Add(label19);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.LightSkyBlue;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += Form1_Load;
            KeyDown += CadCliente_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ImgCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label19;
        private Label label20;
        private TextBox TxtNome;
        private TextBox TxtNumero;
        private TextBox TxtEmail;
        private Label label13;
        private TextBox TxtObs;
        private Label label14;
        private CheckBox CkSituacao;
        private MaskedTextBox TxtDoc;
        private MaskedTextBox TxtNasc;
        private MaskedTextBox TxtCep;
        private MaskedTextBox TxtRG;
        private RadioButton OpCNPJ;
        private RadioButton OpCPF;
        private Label label1;
        private MaskedTextBox TxtCelular;
        private ComboBox CbEstado;
        private ComboBox CbCiivil;
        private ComboBox CbEndereco;
        private ComboBox CbBairro;
        private ComboBox CbCidade;
        private PictureBox ImgCliente;
        private Button BtAddFoto;
        private Button BtRemoveFoto;
        private Button BtExcluir;
        private Button BtNovo;
        private Button BtSalvar;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Label label2;
        private ComboBox CbGenero;
        private Button BtnPesquisar;
        private Button TxtAlterar;
        private TextBox textBox1;
        private Button BtnConsultar;
    }
}
