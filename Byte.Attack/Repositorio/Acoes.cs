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