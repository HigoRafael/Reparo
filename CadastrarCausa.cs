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
    public partial class CadastrarCausa : Form
    {
        const string serverDB = "10.57.64.203";
        public CadastrarCausa()
        {
            InitializeComponent();
            txtNomeCausa.Enabled = false;
            btnIserir.Enabled = false;
            btnAtulizar.Enabled = false;
            txtSenha.Focus();
        }

        private void BtnIserir_Click(object sender, EventArgs e)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"insert into causa (descriSetor,id) " +
                $"values ('{txtNomeCausa.Text}','');";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            cmd.ExecuteNonQuery();

            dtgvCausa.DataSource = Consultar(txtNomeCausa.Text);
        }

        public DataTable Consultar(String descriCausa)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            MySqlConnection con = new MySqlConnection(conexao);
            string query = $"select * from causa where descriCausa={descriCausa}";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);

            DataTable resulta = new DataTable();
            adp.Fill(resulta);

            return resulta;
        }

        private void UpdateCausa()
        {
            var dgId = dtgvCausa.SelectedRows[0].Cells["id"].Value;
            var dgSetor = dtgvCausa.SelectedRows[0].Cells["descriCausa"].Value;

            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"update setor set descriCausa='{dgSetor}' where id='{dgId}'";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        private void BtnAtulizar_Click(object sender, EventArgs e)
        {
            UpdateCausa();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var senha = "CAD4041";

            if (txtSenha.Text.Equals(senha))
            {
                txtNomeCausa.Enabled = true;
                btnIserir.Enabled = true;
                btnAtulizar.Enabled = true;
                txtNomeCausa.TabIndex = 1;
                txtNomeCausa.Focus();
            }
            else
            {
                MessageBox.Show("Senha Invalida");
            }
        }

        private void TxtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.Focus();
            }
        }
    }
}
