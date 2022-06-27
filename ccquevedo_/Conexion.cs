using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccquevedo_
{
    public class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();
       // string cadenaConexion = "SERVER=31.170.160.52;PORT=3306;DATABASE=u868043423_Content;UID=u868043423_Admin;PASSWORD=Ccquevedo2022";
        string cadenaConexion = "SERVER=31.170.160.52;PORT=3306;DATABASE=u868043423_LBWcd;UID=u868043423_2da1n;PASSWORD=Ccquevedo8";
        public string Agregar(string url)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            string datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string[] nombre = url.Split(new char[] { '.' });
            string urln=nombre[0];
            string comando = string.Format("insert into wp_posts (post_author, post_date, post_date_gmt, post_title," +
                "post_status, comment_status, ping_status, post_name, post_modified, " +
                "post_modified_gmt,post_parent, guid, menu_order, post_type, post_mime_type, comment_count) " +
                "values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10},'{11}','{12}','{13}','{14}',{15})",
                1,datetime,datetime,urln, "inherit", "open", "closed",urln,datetime,datetime,95, "https://ccquevedo.com/wp-content/uploads/2019/06/" + url,
                0, "attachment", "image/png",0);
            Console.WriteLine(comando);

            MySqlCommand cmd = new MySqlCommand(comando,conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            return "Foto guardada con exito";
        }

    }
}
