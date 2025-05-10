
namespace PolimorfismoQ22025
{
    public class Casa : Inmueble
    {
        public Casa(double AreaTerreno, double precio) 
        {
            TipoInmueble = "Casa";
            this.AreaTerreno = AreaTerreno;
            Precio = precio;
        }
    }
}
