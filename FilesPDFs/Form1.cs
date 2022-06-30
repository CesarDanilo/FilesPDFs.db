using MySql.Data.MySqlClient;
using System.Data;
using System.IO;


namespace FilesPDFs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /*
            ADICIONANDO UM ARQUIVO NO BANCO DE DADOS         
        */
        private void btn_add_file_Click(object sender, EventArgs e)
        {
            #region ADD File

            string strConnection = "server=localhost;user=root;database=FILES_DB;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(strConnection);

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                string strFileNameURL = openFileDialog.FileName;    // Nosso caminho do arquivo que iremos pegar 
                string strFileName = openFileDialog.SafeFileName;   // Nome do arquivo 

                int pointer = strFileName.IndexOf('.');

                string extention = strFileName.Substring(pointer, (strFileName.Length - pointer));  // Extenção do arquivo
                openFileDialog.ShowDialog();

                // Depois de pegar o nome, caminho e extenção do arquivo,  iremos enviar para o banco de dados

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $@"INSERT INTO FILES_TB VALUES (NULL, '{strFileName}', '{extention}', CURRENT_TIME())";
                cmd.ExecuteNonQuery();

                label_bottom.Text = "OK";


            }catch (Exception ex)
            {
                label_bottom.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            #endregion
        }

        private void btn_create_database_Click(object sender, EventArgs e)
        {
            #region CREATE DATABASE

            /* Nessa classe criaremos o nosso banco de dados 
               caso o banco de dados ja esteja criado mostrará na tela um alerta que já existe o banco de dados
               [ Caminho do nosso banco de dados ]
            */

            string strConnection = "server=localhost;user=root;database=FILES_DB;port=3306;password=root";


            MySqlConnection conn = new MySqlConnection(strConnection);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                label_bottom.Text = "Conectado com súcesso!";

            }
            catch (Exception ex)
            {
                label_bottom.Text = ex.Message;

            }
            finally
            {

                // Toda vez que for aberto uma conexão o finelly vai fechar automaticamente depois que já for utilizado 
                conn.Close();
            }

            #endregion
        }

        private void btn_search_all_Click(object sender, EventArgs e)
        {

        }

 

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}