using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Acceso; 

namespace Controller
{
    public class Manejador_login
    {
        Funciones f = new Funciones();

        public string[] Validar(string _nickname, string _pass)
        {
            string[] resultado = new string[2];
            DataSet r = f.Mostrar($"call p_validar('{_nickname}', '{Sha1(_pass)}')", "usuarios");
            DataTable dt = r.Tables[0];
            resultado[0] = dt.Rows[0]["rs"].ToString();
            resultado[1] = dt.Rows[0]["nivel"].ToString();
            return resultado;
        }
        public static string Sha1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textoOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textoOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
        public int Obtener_id_usuario(string nickname)
        {
            string query = $"select id_usuario from usuarios where nickname = '{nickname}'";
            string id_Usuario_Str = f.ObtenerDato(query, "usuarios", "id_usuario");
            int Id_usuario = 0;
            int.TryParse(id_Usuario_Str, out Id_usuario);
            return Id_usuario;
        }
    }
}
