using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Producto
    {

        private String Id;
        private String Descripcion;
        private float Costo;
        private float PrecioVenta;
        private int Stock;
        private String IdUsuario;

        public Producto(string id, string descripcion, float costo, float precioVenta, int stock, string idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }

        public String id
        {
            get { return this.Id; }
            set
            {
                this.Id = value;
            }
        }

        public String description
        {
            get { return this.Descripcion; }
            set
            {
                this.Descripcion = value;
            }   
        }

        public float costo
        {
            get { return this.Costo; }
            set { this.Costo = value; }
        }

        public float precioVenta
        {
            get { return this.PrecioVenta; }
            set
            {
                this.PrecioVenta = value;
            }
        }

        public int stock
        {
            get { return this.Stock; }
            set { this.Stock = value; }
        }

        public String idUsuario
        {
            get { return this.IdUsuario; }
            set
            {
                this.IdUsuario = value;
            }
        }
    }
}
