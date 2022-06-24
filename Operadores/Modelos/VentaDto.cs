namespace Operadores.Modelos
{
    public class VentaDto
    {
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
    }
}
