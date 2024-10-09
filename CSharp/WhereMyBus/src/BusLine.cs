using System.Linq;

namespace WhereBus
{
   

    

    public class LineaBus : IElementoRuta{
        public string Nombre { get; set;} 
        public Paradero[] Paraderos {get; set;}

        public LineaBus(string nombre, Paradero[] paraderos){
            Nombre = nombre;
            Paraderos = paraderos;
        }
        public string GetNombre() => $"[L]{Nombre}";
        public string Descripcion(){
            string msg = $"Ruta: {Nombre} \n Paraderos: ";
            foreach (Paradero paradero in Paraderos)
            {
                msg += $"{paradero.Nombre} > ";
            }
            return msg;
        }

        public bool ContieneParadero(Paradero paraderoObjetivo){
            return Paraderos.Contains(paraderoObjetivo);
        }
    }
}