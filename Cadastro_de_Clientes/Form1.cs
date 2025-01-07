using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Cadastro_de_Clientes
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
            LoadComboBox();
            LoadComboBoxGenero();

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtDoc.Text = "";
            TxtEmail.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cadastro_de_clientes;User=root"))
            {
                try
                {
                    Conexao.Open();
                   

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {
                        String nome = TxtNome.Text;
                        String cpf_cnpj = TxtDoc.Text;
                        String email = TxtEmail.Text;
                        ComboBoxItem selectedItem = (ComboBoxItem)CbCiivil.SelectedItem;
                        int codigoEstadoCivil = int.Parse(selectedItem.Value);
                        ComboBoxItem selectedItem2 = (ComboBoxItem)CbGenero.SelectedItem;
                        int codigoCbGenero = int.Parse(selectedItem2.Value);
                        String rg = TxtRG.Text;
                        DateTime dataNascimento = DateTime.Now;
                        String observacoes = TxtObs.Text;
                        String celular = TxtCelular.Text;
                        String cep = TxtCep.Text;
                        String endereco = CbEndereco.Text;
                        int numeroEndereco = int.Parse(TxtNumero.Text);
                        String bairro = CbBairro.Text;
                        String cidade = CbCidade.Text;
                        String estado = CbEstado.Text;
                        



                        cmd.CommandText = "INSERT INTO cliente (nome, CPF_CNPJ, CODIGO_ESTADO_CIVIL, CODIGO_GENERO, SN_SITUACAO_CADASTRAL, EMAIL, RG, DATA_NASCIMENTO, OBSERVACOES, CELULAR, CEP, ENDERECO, N_ENDERECO, BAIRRO, CIDADE, ESTADO, SITUACAO) VALUES (@nome, @CPF_CNPJ, @CODIGO_ESTADO_CIVIL, @CODIGO_GENERO, @SN_SITUACAO_CADASTRAL, @EMAIL, @RG, @DATA_NASCIMENTO, @OBSERVACOES, @CELULAR, @CEP, @ENDERECO, @N_ENDERECO, @BAIRRO, @CIDADE, @ESTADO, @SITUACAO)";

                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@CPF_CNPJ", cpf_cnpj);
                        cmd.Parameters.AddWithValue("@CODIGO_ESTADO_CIVIL", codigoEstadoCivil);
                        cmd.Parameters.AddWithValue("@CODIGO_GENERO", codigoCbGenero);
                        cmd.Parameters.AddWithValue("@SN_SITUACAO_CADASTRAL", "S");
                        cmd.Parameters.AddWithValue("@EMAIL", email);
                        cmd.Parameters.AddWithValue("@RG", rg);
                        cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", dataNascimento);
                        cmd.Parameters.AddWithValue("@OBSERVACOES", observacoes);
                        cmd.Parameters.AddWithValue("@CELULAR", celular);
                        cmd.Parameters.AddWithValue("@CEP", cep);
                        cmd.Parameters.AddWithValue("@ENDERECO", endereco);
                        cmd.Parameters.AddWithValue("@N_ENDERECO", numeroEndereco);
                        cmd.Parameters.AddWithValue("@BAIRRO", bairro);
                        cmd.Parameters.AddWithValue("@CIDADE", cidade);
                        cmd.Parameters.AddWithValue("@ESTADO", estado);
                        



                        if (CkSituacao.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@SITUACAO", "Ativo");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@SITUACAO", "Cancelado");
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ConnectToDatabase()
        {

        }

        private void LoadComboBox()
        {
            string connectionString = "server=localhost;database=cadastro_de_clientes;user=root;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Codigo, nome FROM ESTADO_CIVIL";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Adiciona os valores ao ComboBox
                        CbCiivil.Items.Add(new ComboBoxItem(reader["nome"].ToString(), reader["codigo"].ToString()));
                    }

                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


        }
        private void LoadComboBoxGenero()
        {
            string connectionString = "server=localhost;database=cadastro_de_clientes;user=root;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Codigo, nome FROM GENERO";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Adiciona os valores ao ComboBox
                        CbGenero.Items.Add(new ComboBoxItem(reader["nome"].ToString(), reader["codigo"].ToString()));
                    }

                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCiivil.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)CbCiivil.SelectedItem;
                string selectedText = selectedItem.Text;  // Nome do cliente
                string selectedValue = selectedItem.Value; // ID do cliente

                MessageBox.Show($"Nome: {selectedText}, ID: {selectedValue}");
            }
            if (CbGenero.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)CbGenero.SelectedItem;
                string selectedText = selectedItem.Text;  // Nome do cliente
                string selectedValue = selectedItem.Value; // ID do cliente

                MessageBox.Show($"Nome: {selectedText}, ID: {selectedValue}");
            }

        }

        private void CadCliente_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void SalvarClienteMySQL()
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cadastro_de_clientes;User=root"))
            {
                try
                {
                    Conexao.Open();
                    

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void CbEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Adicionar este método para o evento de clique do botão excluir
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Supondo que você está usando o CPF_CNPJ como chave para excluir o cliente
            string cpf_cnpj = TxtDoc.Text;

            if (string.IsNullOrEmpty(cpf_cnpj))
            {
                MessageBox.Show("Por favor, insira o CPF/CNPJ do cliente para excluir.");
                return;
            }

            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cadastro_de_clientes;User=root"))
            {
                try
                {
                    Conexao.Open();
                    

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {
                        // Comando SQL para excluir o cliente
                        cmd.CommandText = "DELETE FROM cliente WHERE CPF_CNPJ = @CPF_CNPJ";
                        cmd.Parameters.AddWithValue("@CPF_CNPJ", cpf_cnpj);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cadastro_de_clientes;User=root"))
            {
                try
                {
                    Conexao.Open();

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {
                        // Supondo que o CPF seja preenchido no campo TxtDoc
                        String cpf_cnpj = TxtDoc.Text;

                        cmd.CommandText = "SELECT nome, EMAIL, RG, DATA_NASCIMENTO, OBSERVACOES, CELULAR, CEP, ENDERECO, N_ENDERECO, BAIRRO, CIDADE, ESTADO, CODIGO_ESTADO_CIVIL, CODIGO_GENERO, SITUACAO FROM cliente WHERE CPF_CNPJ = @CPF_CNPJ";
                        cmd.Parameters.AddWithValue("@CPF_CNPJ", cpf_cnpj);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TxtNome.Text = reader.GetString("nome");
                                TxtEmail.Text = reader.GetString("EMAIL");
                                TxtRG.Text = reader.GetString("RG");
                                TxtObs.Text = reader.GetString("OBSERVACOES");
                                TxtCelular.Text = reader.GetString("CELULAR");
                                TxtCep.Text = reader.GetString("CEP");
                                CbEndereco.Text = reader.GetString("ENDERECO");
                                TxtNumero.Text = reader.GetInt32("N_ENDERECO").ToString();
                                CbBairro.Text = reader.GetString("BAIRRO");
                                CbCidade.Text = reader.GetString("CIDADE");
                                CbEstado.Text = reader.GetString("ESTADO");

                                // Data de nascimento pode exigir conversão dependendo do formato
                                DateTime dataNascimento = reader.GetDateTime("DATA_NASCIMENTO");
                                // Defina o valor para o controle de data de nascimento aqui, se houver

                                // Estado civil e gênero podem exigir lógica adicional para seleção no ComboBox
                                int codigoEstadoCivil = reader.GetInt32("CODIGO_ESTADO_CIVIL");
                                int codigoGenero = reader.GetInt32("CODIGO_GENERO");
                                // Defina a lógica para selecionar os itens corretos nos ComboBox com base nos códigos

                                // Situação
                                string situacao = reader.GetString("SITUACAO");
                                CkSituacao.Checked = situacao == "Ativo";
                            }
                            else
                            {
                                MessageBox.Show("Cliente não encontrado!");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cadastro_de_clientes;User=root"))
            {
                try
                {
                    Conexao.Open();

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {
                        String nome = TxtNome.Text;
                        String cpf_cnpj = TxtDoc.Text; // CPF utilizado como chave de busca
                        String email = TxtEmail.Text;
                        ComboBoxItem selectedItem = (ComboBoxItem)CbCiivil.SelectedItem;
                        int codigoEstadoCivil = int.Parse(selectedItem.Value);
                        ComboBoxItem selectedItem2 = (ComboBoxItem)CbGenero.SelectedItem;
                        int codigoCbGenero = int.Parse(selectedItem2.Value);
                        String rg = TxtRG.Text;
                        DateTime dataNascimento = DateTime.Now; // Ajustar para o controle de data real, se necessário
                        String observacoes = TxtObs.Text;
                        String celular = TxtCelular.Text;
                        String cep = TxtCep.Text;
                        String endereco = CbEndereco.Text;
                        int numeroEndereco = int.Parse(TxtNumero.Text);
                        String bairro = CbBairro.Text;
                        String cidade = CbCidade.Text;
                        String estado = CbEstado.Text;

                        cmd.CommandText = @"UPDATE cliente 
                                    SET nome = @nome, 
                                        EMAIL = @EMAIL, 
                                        RG = @RG, 
                                        DATA_NASCIMENTO = @DATA_NASCIMENTO, 
                                        OBSERVACOES = @OBSERVACOES, 
                                        CELULAR = @CELULAR, 
                                        CEP = @CEP, 
                                        ENDERECO = @ENDERECO, 
                                        N_ENDERECO = @N_ENDERECO, 
                                        BAIRRO = @BAIRRO, 
                                        CIDADE = @CIDADE, 
                                        ESTADO = @ESTADO, 
                                        CODIGO_ESTADO_CIVIL = @CODIGO_ESTADO_CIVIL, 
                                        CODIGO_GENERO = @CODIGO_GENERO, 
                                        SITUACAO = @SITUACAO
                                    WHERE CPF_CNPJ = @CPF_CNPJ";

                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@CPF_CNPJ", cpf_cnpj);
                        cmd.Parameters.AddWithValue("@EMAIL", email);
                        cmd.Parameters.AddWithValue("@RG", rg);
                        cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", dataNascimento);
                        cmd.Parameters.AddWithValue("@OBSERVACOES", observacoes);
                        cmd.Parameters.AddWithValue("@CELULAR", celular);
                        cmd.Parameters.AddWithValue("@CEP", cep);
                        cmd.Parameters.AddWithValue("@ENDERECO", endereco);
                        cmd.Parameters.AddWithValue("@N_ENDERECO", numeroEndereco);
                        cmd.Parameters.AddWithValue("@BAIRRO", bairro);
                        cmd.Parameters.AddWithValue("@CIDADE", cidade);
                        cmd.Parameters.AddWithValue("@ESTADO", estado);
                        cmd.Parameters.AddWithValue("@CODIGO_ESTADO_CIVIL", codigoEstadoCivil);
                        cmd.Parameters.AddWithValue("@CODIGO_GENERO", codigoCbGenero);

                        if (CkSituacao.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@SITUACAO", "Ativo");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@SITUACAO", "Cancelado");
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados do cliente atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado para o CPF informado.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        private void buttonPreencherTextBox_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=cadastro_de_clientes;User=root"))
            {
                try
                {
                    Conexao.Open();

                    using (MySqlCommand cmd = Conexao.CreateCommand())
                    {
                        cmd.CommandText = "SELECT nome, CPF_CNPJ FROM cliente";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Usando StringBuilder para armazenar os dados
                            StringBuilder sb = new StringBuilder();

                            while (reader.Read())
                            {
                                string nome = reader.GetString("nome");
                                string cpf = reader.GetString("CPF_CNPJ");
                                sb.AppendLine($"{nome}, {cpf}");
                            }

                            // Atribuindo o resultado ao TextBox
                            textBox1.Text = sb.ToString();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
        }



    }
}

