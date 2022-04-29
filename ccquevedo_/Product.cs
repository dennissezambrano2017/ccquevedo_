using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccquevedo_
{
    internal class Product
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcionCorta { get; set; }
        public string descripcionLarga { get; set; }
        public int stock { get; set; }
        public double precioNormal { get; set; }
        public double precioOferta { get; set; }
        public string categorias { get; set; }
        public string tipoProducto { get; set; }
        public string imagen { get; set; }

        public Product() { }

        public Product(int id, string nombre,string descripcionCorta,string descripcionLarga, int stock, double precioNormal,double precioOferta,string categorias,string tipoProducto, string imagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcionCorta = descripcionCorta;
            this.descripcionLarga = descripcionLarga;
            this.stock = stock;
            this.precioNormal = precioNormal;
            this.precioOferta = precioOferta;
            this.categorias = categorias;
            this.tipoProducto = tipoProducto;
            this.imagen = imagen;
        }

        public Product(int id, string nombre, string descripcionCorta, string descripcionLarga, int stock, double precioNormal, double precioOferta, string categorias, string tipoProducto)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcionCorta = descripcionCorta;
            this.descripcionLarga = descripcionLarga;
            this.stock = stock;
            this.precioNormal = precioNormal;
            this.precioOferta = precioOferta;
            this.categorias = categorias;
            this.tipoProducto = tipoProducto;
        }
    }
}
