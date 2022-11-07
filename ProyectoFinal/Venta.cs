using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Venta
    {

        private String Id;
        private String Comentarios;

        public Venta(string id, string comentarios)
        {
            this.Id = id;
            this.Comentarios = comentarios;
        } 

        public String id
        {
            get { return Id; }
            set { Id = value; }
        }

        public String comentarios
        {
            get { return Comentarios; }
            set { Comentarios = value; }
        }

    }
}
