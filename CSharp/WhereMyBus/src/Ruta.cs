namespace WhereBus
{
    public class Ruta{
        public string Nombre { get; set;} 
        public string[] Paraderos {get; set;}

        public Ruta(string nombre, string[] paraderos){
            Nombre = nombre;
            Paraderos = paraderos;
        }

        public string Descripcion(){
            string msg = $"Ruta: {Nombre} \n Paraderos: ";
            foreach (string paradero in Paraderos)
            {
                msg += $"{paradero} > ";
            }
            return msg;
        }
    }
}