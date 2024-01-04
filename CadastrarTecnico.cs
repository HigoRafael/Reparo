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
    public partial class CadastrarTecnico : Form
    {
        const string serverDB = "10.57.64.203";
        public CadastrarTecnico()
        {
            InitializeComponent();

            txtNomeTec.Enabled = false;
            txtMatricula.Enabled = false;
            btnIserir.Enabled = false;
            btnAtulizar.Enabled = false;
        }

        private void BtnAtulizar_Click(object sender, EventArgs e)
        {
            UpdateTecnico();
        }

        public DataTable Consultar(String nomeT)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            MySqlConnection con = new MySqlConnection(conexao);
            string query = $"select * from tecnico where nomeTec={nomeT}";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);

            DataTable resulta = new DataTable();
            adp.Fill(resulta);

            return resulta;
        }

        private void UpdateTecnico()
        {
            var dgId = dtgvTecnico.SelectedRows[0].Cells["id"].Value;
            var dgMatricula = dtgvTecnico.SelectedRows[0].Cells["matricula"].Value;
            var dgNome = dtgvTecnico.SelectedRows[0].Cells["nomeTec"].Value;

            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"update tecnico set nomeTec='{dgNome}', matricula='{dgMatricula}' where id='{dgId}'";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        private void BtnIserir_Click(object sender, EventArgs e)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"insert into tecnico (nomeTec, matricula, id) " +
                $"values ('{txtNomeTec.Text}','{txtMatricula.Text}','');";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            cmd.ExecuteNonQuery();

            dtgvTecnico.DataSource = Consultar(txtMatricula.Text);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var senha = "CAD4041";

            if (txtSenha.Text.Equals(senha))
            {
                txtNomeTec.Enabled = true;
                txtMatricula.Enabled = true;
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
