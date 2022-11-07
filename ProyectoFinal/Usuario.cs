using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Usuario
    {

        private String Id;
        private String Nombre;
        private String Apellido;
        private String NombreUsuario;
        private String Contrasenia;
        private String Mail;

        public Usuario(string id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
            this.Mail = mail;
        }

        public String id
        {
            get { return this.Id; }
            set
            {
                this.Id = value;
            }
        }

        public String nombre
        {
            get { return this.Nombre; }
            set
            {
                this.Nombre = value;
            }
        }

        public String apellido
        {
            get { return this.Apellido; }
            set
            {
                this.Apellido = value;
            }
        }

        public String nombreUsuario
        {
            get { return this.NombreUsuario; }
            set
            {
                this.NombreUsuario = value;
            }
        }

        public String contrasenia
        {
            get { return this.Contrasenia; }
            set
            {
                this.Contrasenia = value;
            }
        }

        public String mail
        {
            get { return this.Mail; }
            set
            {
                this.Mail = value;
            }
        }

    }
}
