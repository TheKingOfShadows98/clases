namespace WhereBus
{
    public class BusStop: IRouteItem{
        public string Nombre { get; set;}

        public BusStop(string nombre)
        {
            Nombre = nombre;
        }

        public string GetName() => $"[P]{Nombre}";
    }
}