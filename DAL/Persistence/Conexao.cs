using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL.Persistence
{
    public class Conexao
    {
        //Atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Método - Abrir Conexão
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=DESKTOP-C7H4FP2\\SQLEXPRESS;Initial Catalog=BDTestes;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar abrir a Conexão " + ex.Message);
            }
        }

        //Método - Fechar Conexão
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                throw  new Exception("Erro ao tentar fechar a Conexão " + ex.Message);
            }
        }



    }


}
