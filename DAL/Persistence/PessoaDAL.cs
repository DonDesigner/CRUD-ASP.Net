using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {

        //Método para Gravar dados : INSERT
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Pessoa (Nome, Endereco, Email) VALUES (@v1, @v2, @v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao Gravar o Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            
        }

        //Método para Atualizar dados : UPDATE
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("UPTADE Pessoa SET Nome=@v1, Endereco=@v2, Email=@v3 WHERE Codigo=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);

                Cmd.ExecuteNonQuery();            

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para Exclui Dados : DELETE
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DELETE FROM Pessoa WHERE Codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir Clliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Metodo para Oberter 1 Pessoa pelo Código
        public Pessoa PesquisaPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Pessoas WHERE Codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Pessoa p = null;
                Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    p = new Pessoa();

                    p.Codigo    = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome      = Convert.ToString(Dr["Nome"]);
                    p.Endereco  = Convert.ToString(Dr["Endereco"]);
                    p.Email     = Convert.ToString(Dr["Email"]);

                }
                return p;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar localizar Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para listar todos os cliente cadastrados:
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Pessoa", Con);
                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>(); //Lista Vazia como Ponteiro

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo    = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome      = Convert.ToString(Dr["Nome"]);
                    p.Endereco  = Convert.ToString(Dr["Endereco"]);
                    p.Email     = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Cliente:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
