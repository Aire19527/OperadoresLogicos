using Operadores.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operadores.Logica
{
    public class AdminsitradorInventario
    {
        //Realizar una aplicación de consola que le permita:
        //1. ingresar
        //	A.el nombre,
        //	B.cantidad y
        //	C.precio de un producto. 

        //2. Realizar la venta de un producto 
        //3. Realizar reporte
        //	A.informando cuantos productos se han vendidos,
        //	B.cuantos hay en inventario,
        //	C.cual es el más vendido.

        List<ProductoDto> ListaProductos = new List<ProductoDto>();
        List<VentaDto> ListaVentas = new List<VentaDto>();

        #region Methods

        public void Orquestador()
        {
            int adminstrar = 1;
            while (adminstrar == 1)
            {
                Console.Clear();
                Console.WriteLine("*** ADMINISTRAR INVENTARIO DE SOFIA ***");
                Console.WriteLine("** 1. INGRESO DE PRODUCTOS **");
                Console.WriteLine("** 2. VENTA DE PRODUCTOS **");
                Console.WriteLine("** 3. REPORTE GENERAL **");
                Console.WriteLine("** 4. Salir **");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                    IngresoProductos();
                else if (opcion == 2)
                    VentaProducto();
                else if (opcion == 3)
                    ReporteGeneral();
                else
                    adminstrar = 0;
            }
        }


        private void IngresoProductos()
        {
            Console.WriteLine("");
            Console.WriteLine("*** Ingresar Información del Producto ***");

            ProductoDto producto = new ProductoDto();
            Console.Write("Nombre: ");
            producto.Nombre = Console.ReadLine();
            Console.Write("Precio: ");
            producto.Precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cantidad: ");
            producto.Cantidad = Convert.ToInt32(Console.ReadLine());

            producto.IdProducto = IdProducto();
            ListaProductos.Add(producto);
            Console.WriteLine("");
        }

        private void VentaProducto()
        {
            Console.WriteLine("*** VENTA DE PRODUCTOS ***");
            ListarProductos();

            Console.Write("Seleccione un producto por el ID: ");
            int idProducto = Convert.ToInt32(Console.ReadLine());

            ProductoDto producSelect = ListaProductos.FirstOrDefault(x => x.IdProducto == idProducto);
            if (producSelect != null)
            {
                int cantidadCorrecta = 1;
                while (cantidadCorrecta == 1)
                {
                    Console.WriteLine("");
                    Console.Write("Cantidad: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    if (cantidad > producSelect.Cantidad)
                    {
                        Console.WriteLine($"En inventario hay [{producSelect.Cantidad}] unidades, por favor digite una cantidad menor o igual");
                    }
                    else
                    {
                        int cantidadRestante = producSelect.Cantidad - cantidad;

                        //elimino el iten seleccionado
                        ListaProductos.Remove(producSelect);
                        ListaProductos.Add(new ProductoDto()
                        {
                            Cantidad = cantidadRestante,
                            IdProducto = idProducto,
                            Nombre = producSelect.Nombre,
                            Precio = producSelect.Precio
                        });

                        ProcesoVenta(producSelect, cantidad);
                        cantidadCorrecta = 2;
                    }
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Señor usuario, seleccione un producto válido.");
                VentaProducto();
            }
        }

        private void ProcesoVenta(ProductoDto producto, int cantidad)
        {

            ListaVentas.Add(new VentaDto()
            {
                Cantidad = cantidad,
                IdProducto = producto.IdProducto,
                Precio = producto.Precio,
                Total = producto.Precio * cantidad,
                IdVenta = IdVenta()
            });

            Console.WriteLine("Venta Realizada exitosamente!");
        }

        private void ListarProductos()
        {
            Console.WriteLine("");
            Console.WriteLine("*** LISTADO DE PRODUCTOS EN INVENTARIO ***");
            Console.WriteLine($"    ID - Nombre - Cantidad - Precio");

            foreach (var product in ListaProductos)
            {
                Console.WriteLine($"    {product.IdProducto} - {product.Nombre} - {product.Cantidad} - {product.Precio}");
            }

            Console.WriteLine("");
        }

        private void ReporteGeneral()
        {

            ListarProductos();
            
            var agrupacion = (from p in ListaVentas
                              group p by p.IdProducto into grupo
                              select new
                              {
                                  IdProducto = grupo.Key,
                                  Cantidad = grupo.Sum(x => x.Cantidad),
                                  ValorUnitario = grupo.FirstOrDefault().Precio,
                                  Total = grupo.Sum(x => x.Total)
                              }).ToList();
            //Producto más vendido
            int cantidadMaxima = agrupacion.Max(x => x.Cantidad);
            int idProducto = agrupacion.FirstOrDefault(x => x.Cantidad == cantidadMaxima).IdProducto;

            var producto = ListaProductos.FirstOrDefault(x => x.IdProducto == idProducto);
            Console.WriteLine($"El producto más vendido: [{producto.Nombre}], total ventas [{cantidadMaxima}]");

            Console.WriteLine("");
            Console.WriteLine("Los Productos vendidos son: ");
            Console.WriteLine("");
            Console.WriteLine(" Nombre - Cantidad - Valor Unidad - Total Venta");
            foreach (var item in agrupacion)
            {

                var productoInforme= ListaProductos.FirstOrDefault(x => x.IdProducto == item.IdProducto);
                Console.WriteLine($" {productoInforme.Nombre} - {item.Cantidad} - {item.ValorUnitario} - {item.Total}");
            }

            Console.WriteLine("");
            Console.ReadKey();
        }

        #endregion

        #region Auxiliares
        private int IdProducto()
        {
            try
            {
                int id = ListaProductos.Max(x => x.IdProducto) + 1;
                return id;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        private int IdVenta()
        {
            try
            {
                int id = ListaVentas.Max(x => x.IdVenta) + 1;
                return id;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }
        #endregion
    }
}
