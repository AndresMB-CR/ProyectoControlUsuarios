using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using ControlUsuarios.Models;

namespace ControlUsuarios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Boton_Login_Click(object sender, EventArgs e)
        {// se revisa si el id y el nombre coinciden para ingresar al sistema
            int id = Convert.ToInt32(Caja_Usuario.Text);
            String pass = Caja_Clave.Text.ToString();

            Boolean acceso = GetUser(id, pass);
           
            if (acceso)
            {
                Response.Redirect("Usuarios.aspx");
            }
            else
            {

            }

        }

        public Boolean GetUser(int id, string nombre)//devuelve el usuario segpún id y nombre
        {
            Usuarios aux;
            Boolean existe = false;
            using (ControlUsuariosEntities entidad = new ControlUsuariosEntities())
            {
             
                aux = entidad.Usuarios.Where(x => x.Id.Equals(id) && x.Contrasena.Equals(nombre)).FirstOrDefault();

                if (aux != null)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public List<Usuarios> ListUsuario(int id, string nombre)//devuelve el usuario segpún id y nombre
        {
            List<Usuarios> lista;
            using (ControlUsuariosEntities entidad = new ControlUsuariosEntities())
            {

                lista = entidad.Usuarios.Where(x => x.Id.Equals(id) && x.Contrasena.Equals(nombre)).ToList();


            }
            return lista;
        }
    }
}