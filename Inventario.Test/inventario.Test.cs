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
    }
}