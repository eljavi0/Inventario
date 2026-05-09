using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class InventarioServicio
    {
        private readonly List<Producto> _productos = new();
        private int _nextId = 1;

        public void RegistrarProducto(string nombre, decimal precio, int cantidad)
        {
            _productos.Add(new Producto
            {
                Id = _nextId++,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad
            });
        }

        public int ContarProductos() => _productos.Count;
    }
}
