
namespace PolimorfismoQ22025
{
    public class Terreno : Inmueble
    {
        public Terreno() {
            TipoInmueble = "Terreno";
            Ubicacion = "San Pedro de Tutule";
            AreaTerreno = 60;
            Precio = 200500;
        }

        public Terreno(string Ubicacion)
        {
            TipoInmueble = "Terreno";
            this.Ubicacion = Ubicacion;
        }

        public Terreno(string Ubicacion, double AreaTerreno)
        {
            TipoInmueble = "Terreno";
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
        }

        public Terreno(string Ubicacion, double AreaTerreno, double Precio)
        {
            TipoInmueble = "Terreno";
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
            this.Precio = Precio;
        }
    }
}
