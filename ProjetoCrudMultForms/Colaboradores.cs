using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrudMultForms
{
    class Colaboradores: Conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public void inserir()
        {
            string query = "INSERT INTO colaborador(nome_colaborador,sobrenome_colaborador,cpf_colaborador) VALUES ('" + Nome + "','"
                + Sobrenome + "','" + Cpf + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
        public void excluir()
        {
            string query = "Delete from colaborador where cpf_colaborador= '" + Cpf + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void alterar()
        {
            string query = "UPDATE colaborador SET nome_colaborador = '" + Nome +
                            "', sobrenome_colaborador =  '" + Sobrenome +
                            "'where cpf_colaborador = '" + Cpf + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from colaborador ";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

