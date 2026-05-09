using Xunit;
namespace Inventario.Test
{
    public class InventarioServicioTests
    {
        [Fact]
        public void RegistrarProducto_DebeAgregarloAlInventario()
        {
            var servicio = new InventarioServicio();

            servicio.RegistrarProducto("Laptop", 250000m, 10);

            Assert.Equal(1,servicio.ContarProductos());
        }
    }
}