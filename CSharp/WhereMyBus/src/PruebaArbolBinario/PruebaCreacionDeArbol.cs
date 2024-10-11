using Tests.Arbol;

namespace WhereBus{

    public class PruebaCreacionDeArbol{

        Paradero[] Paraderos;
        LineaBus[] Rutas;

        public PruebaCreacionDeArbol()
        {
            Paraderos = new Paradero[]{
            new Paradero("Caquetá"),
            new Paradero("Lima Centro"),
            new Paradero("Aeropuerto"),
            new Paradero("Santa Anita Mall"),
            new Paradero("Universitaria"),
            new Paradero("El Naranjal")
            };

            Rutas = new LineaBus[]{
            new LineaBus("El Chino",new Paradero[]{Paraderos[0],Paraderos[1],Paraderos[3]}),
            new LineaBus("Z",new Paradero[]{Paraderos[5],Paraderos[4],Paraderos[2]}),
            new LineaBus("El Loro",new Paradero[]{Paraderos[4],Paraderos[2],Paraderos[3]})
            };
        }

        public void Start(){
                
                // ARRAYS son TIPO[]
                Paradero origen = PedirParadero();//✔ Input
                
                LineaBus[] rutasdeorigen = BuscarRutas(origen);//✔ Identifique en qué rutas esta ese paradero

                Node nodeOrigen = new Node(origen); // Crear un nodo para nuestro Origen. va a ser nuestro root

                foreach(var ruta in rutasdeorigen){// Por cada Ruta que pasa por nuestro Origen, vamos a crear un Nodo y añadirlo a nuestra Raiz.
                    Node node = new (ruta);
                    foreach(var para in ruta.Paraderos){
                        Node n = new (para);
                        node.Add(n);
                        Console.WriteLine(n.GetTree());
                    }
                    nodeOrigen.Add(node);
                        
                }


                //Guardamos las rutas
                
                //Pasaria al siguiente paradero
                

        }

    // ESTO LE PIDE AL USUARIO UN PARADERO Y LO RETORNA
        public Paradero PedirParadero(){ // Si no se encuentra el paradero, retorna null
            
            Paradero paradero = null; 
            Console.WriteLine("Ingrese en Nombre del paradero:");
            // Arreglar para solo mostrar los Paraderos.
            Console.WriteLine("Paraderos disponibles");
            for (int i = 0; i < Paraderos.Length; i++)
            {
                Console.WriteLine($"[{i}]: {Paraderos[i].GetNombre()}");
            }
            string input = Console.ReadLine();
            if(!int.TryParse(input, out int n)){
                Console.WriteLine("Numero no conocido");
                return PedirParadero();
            }
            if(n < 0 || n >= Paraderos.Length){
                Console.WriteLine("Numero esta fuera de Lista");
                return PedirParadero();
            }
            return Paraderos[n];
        }
        
        /// Busca las rutas que pasan por un punto determinado
        public LineaBus[] BuscarRutas(Paradero punto){
            
            List<LineaBus> rutas = new List<LineaBus>();
            foreach (LineaBus ruta in Rutas)
            {
                if( ruta.ContieneParadero(punto)){
                    rutas.Add(ruta);
                }
            } 
            return rutas.ToArray();
        }
    }
}