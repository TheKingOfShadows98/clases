using System.Collection.Generic;
namespace WhereBus{
    
    public class Route{
        
        public Rama Padre;
        public IRutable PuntoRuta;

        public List<Route> Childs;
        
        public Route(IRouteItem puntoRuta , Rama padre = null){
            Padre = padre;
            PuntoRuta = puntoRuta;
            Childs = new List<Route>();
        }

        public List<Route> GetEnds()
        {
            List<Route> ends = new();
            foreach(Route route in Childs)
            {
                route.GetEnds();
            }
            if(Childs.Count < 1)
            {
                ends.Add(this);
            }
        }

        public void ShowRama(){
            Console.WriteLine($"{PuntoRuta.GetNombre()} > {Caminos.Count}");
            foreach(Rama camino in Caminos){
                camino.ShowRama();
            }
        }
        public void AñadirCamino(Rama camino){
            Caminos.Add(camino);
            camino.Padre = this;
        }

        
    }


}