using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControlUsuarios.Models;
using ControlUsuarios.Metodos;


namespace ControlUsuarios
{
    public partial class USUARIOS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnUsuarios_Click(object sender, EventArgs e)// se encarga de llevar al sector de mantenimiento de usuarios para ingresar un nuevo usuario
        {
            
            General.setestadoG(1);
            Response.Redirect("MantenimientoUsuarios.aspx");// redirecciona al sector de mantenimiento 

        }
        protected void Gdv_Usuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)// se encarga de escoger el usuario al cual se le dará mantenimiento 
        {
           
            General.setidobjeto(Convert.ToInt32((Gdv_Usuarios.Rows[e.RowIndex].FindControl("Lbl_ID") as Label).Text));// setea el id del usuario al cual se le dará mantenimiento 
            General.setestadoG(2);
           
            Response.Redirect("MantenimientoUsuarios.aspx");// redirecciona al sector de mantenimiento 



        }
        
        public void CargarUsuarios()// se encarga de traer y llenar la lista de usuarios para el grid
        {
            List<Usuarios> aux = General.ListaUsuario();// trae una lista de los usuarios
            List<usuario> registro = new List<usuario>();
              

            foreach (Usuarios Item in aux)
            {
                    usuario add = new usuario();
                    // Ingresa los datos del usuario que se va a agregar a la lista
                    add.Id = Item.Id.ToString();
                    add.Nombre = Item.Nombre;
                    add.Apellido1 = Item.Apellido1;
                    add.Apellido2 = Item.Apellido2;
                    registro.Add(add);// se agrega el usuario a la lista 
                }

            cargarDatos(registro);// carga la lista de los usuarios

        }
        public void cargarDatos(List<usuario> aux)
        {
            Gdv_Usuarios.DataSource = aux;//Trae una lista con los datos y los liga segun el Eval
            Gdv_Usuarios.DataBind();
        }

        protected void btn_mostrasUsuarios_Click(object sender, EventArgs e)// Se encarga de mostrar la lista de usuaros
        {
            CargarUsuarios();// carga el grid con la información de los usuarios
        }

        protected void btnAtras_Click(object sender, EventArgs e)// regresa al usuario a la pantalla de inicio
        {
            General.setestadoG(0);
            Response.Redirect("Inicio.aspx");
        }
    }
}