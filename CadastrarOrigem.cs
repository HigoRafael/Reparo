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
    public partial class CadastrarOrigem : Form
    {
        const string serverDB = "10.57.64.203";

        public CadastrarOrigem()
        {
            InitializeComponent();
            txtNomeSetor.Enabled = false;
            btnIserir.Enabled = false;
            btnAtulizar.Enabled = false;
        }

        private void BtnAtulizar_Click(object sender, EventArgs e)
        {
            UpdateSetor();
        }

        private void UpdateSetor()
        {
            var dgId = dtgvSetor.SelectedRows[0].Cells["id"].Value;
            var dgSetor = dtgvSetor.SelectedRows[0].Cells["descriSetor"].Value;

            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"update setor set descriSetor='{dgSetor}' where id='{dgId}'";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public DataTable Consultar(String descriSetor)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            MySqlConnection con = new MySqlConnection(conexao);
            string query = $"select * from setor where descriSetor={descriSetor}";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);

            DataTable resulta = new DataTable();
            adp.Fill(resulta);

            return resulta;
        }

        private void BtnIserir_Click(object sender, EventArgs e)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"insert into setor (descriSetor,id) " +
                $"values ('{txtNomeSetor.Text}','');";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            cmd.ExecuteNonQuery();

            dtgvSetor.DataSource = Consultar(txtNomeSetor.Text);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var senha = "CAD4041";

            if (txtSenha.Text.Equals(senha))
            {
                txtNomeSetor.Enabled = true;
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
