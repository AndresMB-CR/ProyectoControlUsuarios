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
    public partial class MantenimientoUsuarios : System.Web.UI.Page
    {
        Usuarios nuevoingreso = new Usuarios();
        
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            int control = General.getestadoG();
            if (control == 1)
            {// valida que sea el ingreso de un nuevo usuario
                BtnEditar.Visible = false;
                BtnElimUsuario.Visible = false;
                BtnIngresarUsuario.Visible = true;
                lblNuevoNombre.Visible = false;
                lblnuevoAP2.Visible = false;
                lbluevoAP1.Visible = false;
                lblPassNuevo.Visible = false;
                TxtnuevoNombre.Visible = false;
                TxtnuevoAP2.Visible = false;
                TxtNuevoAp1.Visible = false;
                TxtNuevaPass.Visible = false;
            }
            if (control == 2)
            {// valida que sea el mantenimiento de un usuario existente
                BtnIngresarUsuario.Visible = false;
                BtnEditar.Visible = true;
                BtnElimUsuario.Visible = true;
                lblNuevoNombre.Visible = true;
                lblnuevoAP2.Visible = true;
                lbluevoAP1.Visible = true;
                lblPassNuevo.Visible = true;
                TxtnuevoNombre.Visible = true;
                TxtnuevoAP2.Visible = true;
                TxtNuevoAp1.Visible = true;
                TxtNuevaPass.Visible = true;
                id = General.getidobjeto();
                CargarUsuarios();
            }

        }

        void RegistrarUsuario(Usuarios ingreso)// Permite ingresar un Usuario nuevo
        {
            using (ControlUsuariosEntities ContextoBD = new ControlUsuariosEntities())
            {

                ContextoBD.Usuarios.Add(ingreso);//  ingresa el usuario a la bd
      
                ContextoBD.SaveChanges();// guarda los cambios realizados 


            }
        }
        void actualizarUsuario(int id)
        {// se encarga de actualizar al usuario seleccionado con los nuevos datos ingresados
            using (ControlUsuariosEntities ContextoBD = new ControlUsuariosEntities())
            {

                Usuarios aux = ContextoBD.Usuarios.Find(id);// busca al usuario en base al id del usuario seleccionado

                if (TxtnuevoNombre.Text != "")
                {
                    aux.Nombre = TxtnuevoNombre.Text;// valida si se ingresa un nuevo dato  y se asiga el valor nuevo al nombre del usuario
                }
                else
                {
                    aux.Nombre = aux.Nombre;
                }
                if (TxtNuevoAp1.Text != "")
                {
                    aux.Apellido1 = TxtNuevoAp1.Text;// valida si se ingresa un nuevo dato  y se asiga el valor nuevo al apellido 1 del usuario
                }
                else
                {
                    aux.Apellido1 = aux.Apellido1;
                }
                if (TxtnuevoAP2.Text != "")
                {
                    aux.Apellido2 = TxtnuevoAP2.Text;// valida si se ingresa un nuevo dato  y se asiga el valor nuevo al apellido 2 del usuario
                }
                else
                {
                    aux.Apellido2 = aux.Apellido2;
                }
                if (TxtNuevaPass.Text != "")
                {
                    aux.Contrasena = TxtNuevaPass.Text;
                }
                else
                {
                    aux.Contrasena = aux.Contrasena;
                }
                aux.Nombre_Completo = aux.Nombre + "" + aux.Apellido1 + "" + aux.Apellido2;
                ContextoBD.SaveChanges();// se guardan los cambios realizados a ambas entidades
                General.setestadoG(0);
                Response.Redirect("Usuarios.aspx");// redirige  al módulo de usuarios 
            }

        }
        void EliminarUsuario(int id)
        {// permite eliminar un usuario seleccionado
            using (ControlUsuariosEntities ContextoBD = new ControlUsuariosEntities())
            {
                Usuarios aux = ContextoBD.Usuarios.Find(id);// busca al usuario en base al id del usuario seleccionado 

                ContextoBD.Usuarios.Remove(aux);
  
                ContextoBD.SaveChanges();// se guardan los cambios


            }

        }
        public void CargarUsuarios()
        {// permite cargar todos los usuarios existentes en el sistema
            List<Usuarios> aux = General.ListaUsuario();//  trae toda la lista de usuarios
            
        

            foreach (Usuarios Item in aux)
            {
                if (Item.Id == id) ;
 
                    usuario add = new usuario();
                    // acontinuación se setan los datos en base al usuario extraido
                    TxtNombre.Text = Item.Nombre;
                    TxtApellido1.Text = Item.Apellido1;
                    TxtApellido2.Text = Item.Apellido2;
                TxtPass.Text = Item.Contrasena;

            

            }
            
        }



        protected void btnAtras_Click(object sender, EventArgs e)// permite regresar al modulo de usuarios 
        {
            General.setestadoG(0);
            Response.Redirect("Usuarios.aspx");

        }

        protected void BtnIngresarUsuario_Click(object sender, EventArgs e)
        {
            nuevoingreso.Nombre = TxtNombre.Text;
            nuevoingreso.Apellido1 = TxtApellido1.Text;
            nuevoingreso.Apellido2 = TxtApellido2.Text;
            nuevoingreso.Nombre_Completo = nuevoingreso.Nombre + "" + nuevoingreso.Apellido1 + "" + nuevoingreso.Apellido2;
            nuevoingreso.Contrasena = TxtPass.Text.Trim();
         
            RegistrarUsuario(nuevoingreso);
            General.setestadoG(0);
            Response.Redirect("Usuarios.aspx");

          


        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {// se encarga de llevar a cabo al edición del usuario
            actualizarUsuario(id);// llama al metod editar pasando como parámetro el id del usuario que fue seleccionado en el módulo anterior 
        }

        protected void BtnElimUsuario_Click(object sender, EventArgs e)
        {// se encarga de eliminaral usuario seleccionado 
            EliminarUsuario(id);
            General.setestadoG(0);
            Response.Redirect("Usuarios.aspx");

        }
    }
}