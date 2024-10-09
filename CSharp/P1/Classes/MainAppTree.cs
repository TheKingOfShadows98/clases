using System.Collections.Generic;
namespace WhereBus
{
    

    public class MainAppTree{

        BusStop[] BusStops = new BusStop[6]{
            new BusStop("P1"),
            new BusStop("P2"),
            new BusStop("P3"),
            new BusStop("P4"),
            new BusStop("P5"),
            new BusStop("P6"),
        };
        BusLine[] Rutas = new BusLine[3];
        
        public MainAppTree()
        {
            Rutas[0] = new BusLine("Azul",new BusStop[]{BusStops[1],BusStops[5],BusStops[4],BusStops[2]});
            Rutas[1] = new BusLine("Rojo",new BusStop[]{BusStops[0],BusStops[2],BusStops[1]});
            Rutas[2] = new BusLine("Verde",new BusStop[]{BusStops[0],BusStops[4],BusStops[3]});
            
        }

        public void Start(){
            BusStop origen = BusStops[5]; // <- Este es nuestro BusStop de Origen;
            BusStop destino = null; // <- Esto es un BusStop;
            try{
                Console.WriteLine("Ingrese en Nombre del BusStop de destino:");
                Console.WriteLine($"BusStops Disponibles: [{BusStops[0].Nombre},{BusStops[1].Nombre}, {BusStops[2].Nombre}, {BusStops[3].Nombre}, {BusStops[4].Nombre}]");
                string input = Console.ReadLine();
                foreach(BusStop item in BusStops){
                    if(item.Nombre == input){
                        destino = item;
                        break;
                    }
                }
                if(destino == null){
                    Console.WriteLine("NO ENCONTRAMOS EL BusStop");
                    return;
                }
                Rama ArboldeRuta = new Rama(origen);
                BusLine[] rutasOrigen = BuscarRutas(origen);
                foreach(BusLine linea in rutasOrigen){
                    ArboldeRuta.AñadirCamino(new Rama(linea));
                }
                ArboldeRuta.MostrarRama();
                
                // Buscar la ruta o rutas que pasan por Origen y Destino
                
                BusLine[] rutasDestino = BuscarRutas(destino);

                // Segregar que Rutas pasan Por Ambos Puntos
                BusLine[] rutasSemejantes = BuscarParecidos(rutasOrigen, rutasDestino);
                if(rutasSemejantes.Length > 1)
                {
                    Console.WriteLine("LAS RUTAS QUE VAN A DESTIO SON:");
                    for (int i = 0; i < rutasSemejantes.Length; i++)
                    {
                        Console.WriteLine("" + rutasSemejantes[i].Descripcion());
                    }
                    return;
                }
                Console.WriteLine("NO HAY RUTA DIRECTA A TU DESTINO... BUSCANDO TRASBORDOS");
                string trasbordo = BuscarTrasbordo(rutasOrigen, rutasDestino);
                BusLine[] rutasTrasbordo = BuscarRutas(trasbordo);
                // Segregar que Rutas pasan Por Ambos Puntos
                BusLine[] rutasOriTras = BuscarParecidos(rutasOrigen, rutasTrasbordo);
                BusLine[] rutasDesTras = BuscarParecidos(rutasDestino, rutasTrasbordo);
                Console.WriteLine("RUTA DISEÑADA:");
                Console.WriteLine($"{origen} > {rutasOriTras[0].Nombre} > {trasbordo} > {rutasDesTras[0].Nombre} > {destino}");
                
            }
            catch(Exception e){
                Console.WriteLine("INGRESE UN VALOR VALIDO");
                Start();
                return;
            }
            
        }
        

        
    }


}