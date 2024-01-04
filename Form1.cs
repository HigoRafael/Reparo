using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Reparo
{
    public partial class frmReparo : Form
    {
        const string serverDB = "10.57.64.203";
        public frmReparo()
        {
            InitializeComponent();
            txtData.Text = DateTime.Today.ToString("yyyy-MM-dd");

            CarregaComboBox(cmbModelo, "modelo", "descriModel");
            CarregaComboBox(cmbSetor, "setor", "descriSetor");
            CarregaComboBox(cmbEstacao, "estacao", "descriEstacao");
            CarregaComboBox(cmbCausa, "causa", "descriCausa");
            CarregaComboBox(cmbMatriculaTec, "tecnico", "matricula");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"insert into reparo (id, tecnico, modelo, estacao, defeito, num_serie, causa, posicao_mec, setor, _data) " +
                $"values ('','{cmbMatriculaTec.Text}','{cmbModelo.Text}','{cmbEstacao.Text}','{txtDefeito.Text}','{txtNumSerie.Text}','{cmbCausa.Text}','{txtPosMec.Text}'," +
                $"'{cmbSetor.Text}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            if (ValidaCamposPreencidos())
            {
                cmd.ExecuteNonQuery();
                txtDefeito.Clear();
                txtNumSerie.Text = "";
                txtPosMec.Clear();

                txtNumSerie.Focus();

                dtgvReparo.DataSource = Consultar(cmbMatriculaTec.Text);
            }
        }

        private bool ValidaCamposPreencidos()
        {
            if (!cmbMatriculaTec.Items.Contains(cmbMatriculaTec.Text))
            {
                MessageBox.Show("Informe uma matricula valida");
                return false;
            }
            else if (!cmbModelo.Items.Contains(cmbModelo.Text))
            {
                MessageBox.Show("Informe um modelo correto");
                return false;
            }
            else if (!cmbEstacao.Items.Contains(cmbEstacao.Text))
            {
                MessageBox.Show("Informe uma estação valida");
                return false;
            }
            else if (txtDefeito.Text == "")
            {
                MessageBox.Show("Informe o defeito");
                return false;
            }
            else if (txtNumSerie.Text == "")
            {
                MessageBox.Show("Informe o numero de serie");
                return false;
            }
            else if (!cmbCausa.Items.Contains(cmbCausa.Text))
            {
                MessageBox.Show("Informe uma causa valida");
                return false;
            }
            else if (txtPosMec.Text == "")
            {
                MessageBox.Show("Informe a posição mecanica");
                return false;
            }
            else if (!cmbSetor.Items.Contains(cmbSetor.Text))
            {
                MessageBox.Show("Informe uma origem valida");
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable Consultar(String nomeT)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            MySqlConnection con = new MySqlConnection(conexao);
            string query = $"select * from reparo where tecnico = '{nomeT}'  order by _data desc";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);

            DataTable resulta = new DataTable();
            adp.Fill(resulta);

            var expressao = $"_data >= '{DateTime.Today.ToString("yyyy-MM-dd")}' and _data < '{DateTime.Today.AddDays(1).ToString("yyyy-MM-dd")}'";
            lblDefData.Text = resulta.Select(expressao).Count().ToString();


            return resulta;
        }

        public DataTable ConsultarPlaca(String nomeSerie)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            MySqlConnection con = new MySqlConnection(conexao);
            string query = $"select * from reparo where num_serie = '{nomeSerie}' order by _data desc";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);

            DataTable resulta = new DataTable();
            adp.Fill(resulta);

            return resulta;
        }

        private void CarregaComboBox(ComboBox combobx, string NameTabela, string nomeColuna)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";
            string query = $"select * from {NameTabela}";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            con.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String descri = reader.GetString(nomeColuna);
                combobx.Items.Add(descri);
            }
        }

        private string GetTecnico(string matricula)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";
            string query = $"select nomeTec from tecnico where matricula = '{matricula}'";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
            con.Open();

            DataTable result = new DataTable();
            adp.Fill(result);

            if (result.Rows.Count > 0)
                return result.Rows[0]["nomeTec"].ToString();

            return "";
          
        }

        private void BtnFixar_Click(object sender, EventArgs e)
        {
            if (cmbMatriculaTec.Enabled)
            {
                cmbMatriculaTec.Enabled = false;
                btnFixar.Text = "Cancel";
                dtgvReparo.DataSource = Consultar(cmbMatriculaTec.Text);
                lblNome.Text = GetTecnico(cmbMatriculaTec.Text);


            }
            else
            {
                cmbMatriculaTec.Enabled = true;
                btnFixar.Text = "Fixar";
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            UpdateReparo();
        }

        private void UpdateReparo()
        {
            var dgId = dtgvReparo.SelectedRows[0].Cells["id"].Value;
            var dgTecnico = dtgvReparo.SelectedRows[0].Cells["tecnico"].Value;
            var dgModelo = dtgvReparo.SelectedRows[0].Cells["modelo"].Value;
            var dgEstacao = dtgvReparo.SelectedRows[0].Cells["estacao"].Value;
            var dgDefeito = dtgvReparo.SelectedRows[0].Cells["defeito"].Value;
            var dgNumSerie = dtgvReparo.SelectedRows[0].Cells["num_serie"].Value;
            var dgCausa = dtgvReparo.SelectedRows[0].Cells["causa"].Value;
            var dgPosiMec = dtgvReparo.SelectedRows[0].Cells["posicao_mec"].Value;
            var dgSetor = dtgvReparo.SelectedRows[0].Cells["setor"].Value;

            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"update reparo set tecnico='{dgTecnico}', modelo='{dgModelo}', estacao='{dgEstacao}', defeito='{dgDefeito}', " +
                $"num_serie='{dgNumSerie}', causa='{dgCausa}', posicao_mec='{dgPosiMec}', setor='{dgSetor}' where id= '{dgId}'";
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        private void TxtNomeTec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbModelo.Focus();
                BtnFixar_Click(this, null);
            }
        }

        private void CmbModelo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbEstacao.Focus();
            }
        }

        private void CmbEstacao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumSerie.Focus();
            }
        }

        private void TxtNumSerie_KeyUp(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txtNumSerie.Text))
            {
               txtDefeito.Focus();
            }
        }

        private void TxtDefeito_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txtNumSerie.Text))
            {
                txtPosMec.Focus();
            }
        }

        private void TxtPosMec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCausa.Focus();
            }
        }

        private void CmbCausa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSetor.Focus();
            }
        }

        private void CmbSetor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void CmbNomeTec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbModelo.Focus();
                BtnFixar_Click(this, null);
            }
        }

        private void TxtConsPlaca_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgvReparo.DataSource = ConsultarPlaca(txtConsPlaca.Text);
                txtConsPlaca.Clear();
            }
        }

        private void MnCdEstacao_Click(object sender, EventArgs e)
        {
            var estcao = new CadastrarEstacao();
            estcao.ShowDialog();
        }

        private void MnCdCausa_Click(object sender, EventArgs e)
        {
            var causa = new CadastrarCausa();
            causa.Show();
        }

        private void MnCdModelo_Click(object sender, EventArgs e)
        {
            var modelo = new CadastrarModelo();
            modelo.ShowDialog();
        }

        private void MnCdSetor_Click(object sender, EventArgs e)
        {
            var setor = new CadastrarOrigem();
            setor.ShowDialog();
        }

        private void MnCdTecnico_Click(object sender, EventArgs e)
        {
            var tecnico = new CadastrarTecnico();
            tecnico.ShowDialog();
        }

    }
}
