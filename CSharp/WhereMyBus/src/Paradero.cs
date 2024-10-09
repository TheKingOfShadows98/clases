namespace WhereBus
{
    public class Paradero : IElementoRuta{
        public string Nombre { get; set;}

        public Paradero(string nombre)
        {
            Nombre = nombre;
        }

        public string GetNombre() => $"[P]{Nombre}";
    }
}