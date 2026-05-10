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

        public void ActualizarCantidad(int id, int nuevaCantidad)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
                producto.Cantidad = nuevaCantidad;
        }
        public Producto? ObtenerProducto(int id)
        => _productos.FirstOrDefault(p => p.Id == id);
    }
}
