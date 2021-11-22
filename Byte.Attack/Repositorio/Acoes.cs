using System;
using System.Collections.Generic;
using System.Linq;
using ByteAttack.Repositorio;
using ByteAttack.Models;
using System.Web;
using MySql.Data.MySqlClient;
using System.Web.Mvc;


namespace ByteAttack.Repositorio
{
    public class Acoes 
    {

        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        /*Cadastro de Funcionários*/

        public void CadastrarFuncionario(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.FuncDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into Funcionario values(@IDfunc, @nomeFunc, @cpf, @rg, @nascimento, @endereco, @cel, @email, @cargo)", con.MyConectarBD());
            cmd.Parameters.Add("@IDfunc", MySqlDbType.VarChar).Value = func.FuncCod;
            cmd.Parameters.Add("@nomeFunc", MySqlDbType.VarChar).Value = func.FuncNome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = func.FuncCPF;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = func.FuncRg;
            cmd.Parameters.Add("@nascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = func.FuncEnd;
            cmd.Parameters.Add("@cel", MySqlDbType.VarChar).Value = func.FuncCel;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = func.FuncEmail;
            cmd.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = func.FuncCargo;
            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();
        }
        public List<Funcionario> ListarFuncionario()//Criando Um metodo para listar os funcionarios
        {
            MySqlCommand cmd = new MySqlCommand("select * from funcionario", con.MyConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    FuncCod = ushort.Parse(dt["IDfunc"].ToString()),
                    FuncNome = dt["nomeFunc"].ToString(),
                    FuncCPF = dt["cpf"].ToString(),
                    FuncRg = dt["rg"].ToString(),
                    FuncDtNasc = DateTime.Parse(dt["nascimento"].ToString()),
                    FuncEnd = dt["endereco"].ToString(),
                    FuncCel = dt["cel"].ToString(),
                    FuncEmail = dt["email"].ToString(),
                    FuncCargo = dt["cargo"].ToString()

                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncionarios;
        }

        public void DeletarFuncionario(int dlt)
        {
            var comando = String.Format("delete from funcionario where funcCod = {0}", dlt);
            MySqlCommand cmd = new MySqlCommand(comando, con.MyConectarBD());
            cmd.ExecuteReader();
        }

        /*Login*/
        public Usuario TestarUsuario(Usuario user)
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbUsuario where nm_usuario = @Usuario and ds_senha = @Senha", con.MyConectarBD());
            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = user.nm_usuario;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = user.ds_senha;

            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    Usuario dto = new Usuario();
                    {
                        dto.nm_usuario = Convert.ToString(leitor["nm_usuario"]);
                        dto.ds_senha = Convert.ToString(leitor["ds_senha"]);
                    }
                }
            }

            else
            {
                user.nm_usuario = null;
                user.ds_senha = null;
            }

            return user;
        }
       




    }
}