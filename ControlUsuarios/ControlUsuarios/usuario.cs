using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlUsuarios
{
    public class usuario
    {
        string id;
        string nombre;
        string apellido1;
        string apellido2;
        string telefono;
        string contrasena;
        string nombrecompleto;
        public usuario()
        {
            this.Id = "";
            this.Nombre = "";
            this.Apellido1 = "";
            this.Apellido2 = "";
            this.Telefono = "";
            this.contrasena = "";
            this.nombrecompleto = "";

        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contrasena
        {
            get => contrasena; set => contrasena = value;

        
        }
        public string Nombre_Completo
        {
            get => nombrecompleto; set => nombrecompleto = value;


        }
    }
}