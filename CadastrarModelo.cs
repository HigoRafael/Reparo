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
    public partial class CadastrarModelo : Form
    {
        const string serverDB = "10.57.64.203";
        public CadastrarModelo()
        {
            InitializeComponent();
       
            txtNomeModel.Enabled = false;
            btnIserir.Enabled = false;
            btnAtulizaModel.Enabled = false;
        }

        public DataTable Consultar()
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            MySqlConnection con = new MySqlConnection(conexao);
            string query = $"select * from modelo order by _data desc";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);

            DataTable resulta = new DataTable();
            adp.Fill(resulta);

            return resulta;
        }

        private void BtnIserir_Click(object sender, EventArgs e)
        {
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"insert into modelo (descriModel,id) " +
                $"values ('{txtNomeModel.Text}','');";

            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            cmd.ExecuteNonQuery();

            dtgvModel.DataSource = Consultar();
        }

        private void UpdateModelo()
        {
            var dgId = dtgvModel.SelectedRows[0].Cells["id"].Value;
            var dgModel = dtgvModel.SelectedRows[0].Cells["descriModel"].Value;
  
            string conexao = $"server={serverDB}; database=bd_reparo; uid=root;  password=rootpass1234";

            string query = $"update modelo set descriModel='{dgModel}' where id='{dgId}'";
                
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateModelo();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var senha = "CAD4041";

            if (txtSenha.Text.Equals(senha))
            {
                txtNomeModel.Enabled = true;
                btnIserir.Enabled = true;
                btnAtulizaModel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Senha Invalida");
            }
        }
    }
}
