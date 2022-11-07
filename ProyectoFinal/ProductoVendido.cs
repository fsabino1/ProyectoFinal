using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ProductoVendido
    {

        private String Id;
        private String IdProducto;
        private int Stock;
        private String IdVenta;

        public ProductoVendido(string id, string idProducto, int stock, string idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }

        public String id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public String idProducto
        {
            get { return this.IdProducto; }
            set { this.IdProducto = value; }
        }

        public int stock
        {
            get { return this.Stock; }
            set
            {
                this.Stock = value;
            }
        }

        public String idVenta
        {
            get { return this.IdVenta; }
            set
            {
                this.IdVenta = value;
            }
        }


    }
}
