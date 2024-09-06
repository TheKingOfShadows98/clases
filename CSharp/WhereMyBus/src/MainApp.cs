using System.Collections.Generic;
namespace WhereBus
{
    

    public class MainApp{

        string[] Paraderos = {"P1", "P2", "P3", "P4", "P5", "P6"};
        Ruta[] Rutas = new Ruta[3];
        
        public MainApp()
        {
            Rutas[0] = new Ruta("Azul",new string[]{Paraderos[1],Paraderos[5],Paraderos[4],Paraderos[2]});
            Rutas[1] = new Ruta("Rojo",new string[]{Paraderos[0],Paraderos[2],Paraderos[1]});
            Rutas[2] = new Ruta("Verde",new string[]{Paraderos[0],Paraderos[4],Paraderos[3]});
            
        }

        public void Start(){
            string origen = Paraderos[5]; // <- Este es nuestro Paradero de Origen;
            string destino; // <- Esto es un paradero;
            try{
                Console.WriteLine("Ingrese en Nombre del paradero de destino:");
                Console.WriteLine($"Paraderos Disponibles: [{Paraderos[0]},{Paraderos[1]}, {Paraderos[2]}, {Paraderos[3]}, {Paraderos[4]}]");
                string input = Console.ReadLine();
                destino = input;
                // Buscar la ruta o rutas que pasan por Origen y Destino
                Ruta[] rutasOrigen = BuscarRutas(origen);
                Ruta[] rutasDestino = BuscarRutas(destino);

                // Segregar que Rutas pasan Por Ambos Puntos
                Ruta[] rutasSemejantes = BuscarParecidos(rutasOrigen, rutasDestino);
                if(rutasSemejantes.Length > 1){
                    Console.WriteLine("LAS RUTAS QUE VAN A DESTIO SON:");
                    for (int i = 0; i < rutasSemejantes.Length; i++)
                    {
                        Console.WriteLine("" + rutasSemejantes[i].Descripcion());
                    }
                    return;
                }
                Console.WriteLine("NO HAY RUTA DIRECTA A TU DESTINO... BUSCANDO TRASBORDOS");
                
            }
            catch(Exception e){
                Console.WriteLine("INGRESE UN VALOR VALIDO");
                Start();
                return;
            }
            
        }
        // Segregar que Rutas pasan Por Ambos Puntos
        public Ruta[] BuscarParecidos(Ruta[] lista1, Ruta[] lista2){
            List<Ruta> rutasSemejantes = new List<Ruta>();
            foreach (Ruta ruta1 in lista1)
            {
                foreach (Ruta ruta2 in lista2)
                {
                    if(ruta1 == ruta2){
                        rutasSemejantes.Add(ruta1);
                    }
                }
            }
            return rutasSemejantes.ToArray();
        }
        /// Busca las rutas que pasan por un punto determinado
        public Ruta[] BuscarRutas(string punto){
            
            List<Ruta> rutas = new List<Ruta>();
            foreach (Ruta ruta in Rutas)
            {
                foreach (string paradero in ruta.Paraderos)
                {
                    if(paradero == punto){
                        rutas.Add(ruta);
                        
                        break;
                    }
                }
            }
            return rutas.ToArray();
        }
            
    }


}