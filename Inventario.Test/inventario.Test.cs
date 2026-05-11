using Xunit;
namespace Inventario.Test
{
    public class InventarioServicioTest
    {
        [Fact]
        public void RegistrarProducto_DebeAgregarloAlInventario()
        {
            var servicio = new InventarioServicio();

            servicio.RegistrarProducto("Laptop", 2500000m, 10);

            Assert.Equal(1, servicio.ContarProductos());
        }

        [Fact]
        public void ActualizarCantidad_DebeModificarElInventario()
        {
            var servicio = new InventarioServicio();
            servicio.RegistrarProducto("Mouse", 80000m, 5);

            servicio.ActualizarCantidad(1, 20);

            var producto = servicio.ObtenerProducto(1);
            Assert.Equal(20, producto?.Cantidad);

        }

        [Fact]
        public void ObtenerProducto_ConIdInvalido_RetornaNull()
        {
            var servicio = new InventarioServicio();

            var resultado = servicio.ObtenerProducto(999);

            Assert.Null(resultado);
        }

        [Fact]
        public void ListarProductos_DebeRetornarTodosLosProductos()
        {
            var servicio = new InventarioServicio();
            servicio.RegistrarProducto("Teclado", 150000m, 8);
            servicio.RegistrarProducto("Monitor", 900000m, 3);

            var lista = servicio.ListarProductos();

            Assert.Equal(2, lista.Count);
        }
    }
}