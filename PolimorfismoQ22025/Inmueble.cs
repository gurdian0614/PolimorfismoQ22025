
namespace PolimorfismoQ22025
{
    public class Inmueble
    {
        public string? TipoInmueble { get; set; }
        public string? Ubicacion { get; set; }
        public double AreaTerreno { get; set; }
        public double Precio { get; set; }

        public void Vender()
        {
            Console.WriteLine($"{TipoInmueble}, con Ubicación en {Ubicacion}, con un área de {AreaTerreno} mts2, ha sido vendido por el Precio de L{Precio}");
        }

        public void Vender(string Vendedor)
        {
            Console.WriteLine($"{TipoInmueble}, con ubicación en {Ubicacion}, con un área de {AreaTerreno} mts2, ha sido vendido por el precio de L{Precio}, por el vendedor {Vendedor}");
        }
    }
}
