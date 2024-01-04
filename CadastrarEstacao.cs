using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reparo
{
    public partial class CadastrarEstacao : Form
    {
        const string serverDB = "10.57.64.203";
        public CadastrarEstacao()
        {
            InitializeComponent();
 
            txtNomeEsta.Enabled = false;
            btnIserir.Enabled = false;
            btnAtulizar.Enabled = false;
        }

        private void BtnAtulizar_Click(object sender, EventArgs e)
        {
            UpdateEstcao();
        }

        public DataTable Consultar(String descriEstacao)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            MySqlConnection con = new MySqlConnection(conexao);
            string query = $"select * from estacao where descriEstacao={descriEstacao}";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);

            DataTable resulta = new DataTable();
            adp.Fill(resulta);

            return resulta;
        }

        private void BtnIserir_Click(object sender, EventArgs e)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"insert into estcao (descriEstacao,id) " +
                $"values ('{txtNomeEsta.Text}','');";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            cmd.ExecuteNonQuery();

            dtgvEstacao.DataSource = Consultar(txtNomeEsta.Text);
        }

        private void UpdateEstcao()
        {
            var dgId = dtgvEstacao.SelectedRows[0].Cells["id"].Value;
            var dgEstacao = dtgvEstacao.SelectedRows[0].Cells["descriEstacao"].Value;

            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"update estacao set descriEstacao='{dgEstacao}' where id='{dgId}'";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var senha = "CAD4041";

            if (txtSenha.Text.Equals(senha))
            {
                txtNomeEsta.Enabled = true;
                btnIserir.Enabled = true;
                btnAtulizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Senha Invalida");
            }
        }
    }
}
