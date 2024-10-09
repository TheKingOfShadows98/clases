using System.Collections.Generic;
using System;
namespace WhereBus
{
    

    public class MainAppTree{

        Paradero[] Paraderos;
        LineaBus[] Rutas;

        public MainAppTree()
        {
            Paraderos = new Paradero[]{
            new Paradero("P1"),
            new Paradero("P2"),
            new Paradero("P3"),
            new Paradero("P4"),
            new Paradero("P5"),
            new Paradero("P6"),
            new Paradero("P7"),
            };

            Rutas = new LineaBus[]{
            new LineaBus("Azul",new Paradero[]{Paraderos[1],Paraderos[5],Paraderos[4],Paraderos[2]}),
            new LineaBus("Rojo",new Paradero[]{Paraderos[0],Paraderos[1],Paraderos[2]}),
            new LineaBus("Verde",new Paradero[]{Paraderos[0],Paraderos[4],Paraderos[3]}),
            new LineaBus("Morado",new Paradero[]{Paraderos[6],Paraderos[5]})
            };
        }

        public void Start(){ // Iniciamos la Applicacion
            Console.WriteLine("Seleccione un Origen");
            Paradero origen = PedirParadero(); // <- Pedir un Origen;
            Console.WriteLine("Seleccione un Destino");
            Paradero destino = PedirParadero(); // <- Pedir un Destino;
            ArbolNodos ArboldeRuta = new ArbolNodos();
            ArboldeRuta.currentCycle.AddNode(new Nodo(origen));
            
            for (int i = 0; i < 10; i++) // <= 2
            {
                ArboldeRuta.NewCicle();
                foreach(Nodo node in ArboldeRuta.currentCycle.Nodos)//Nodo [P]P2{Paradero, LRojo}
                {
                    
                    if(node.Elemento is Paradero)
                        {
                            var paradero = (Paradero) node.Elemento;
                            if(paradero == destino){
                                Console.WriteLine("Destino encontrado!");
                                Console.WriteLine($"Instrucciones:\n {node.History()}");
                                return;
                            }
                            LineaBus[] lineasNodo = BuscarRutas(paradero);// <- [Roja,Verde]
                            
                            foreach(LineaBus linea in lineasNodo){// <- [Verde]
                                
                                if(ArboldeRuta.ExistElement(linea)) continue;
                                ArboldeRuta.AddNodeToCicle(new Nodo(linea, node));
                            }
                            
                        }
                    else if(node.Elemento is LineaBus)
                    {
                        LineaBus linea = (LineaBus) node.Elemento;
                        foreach(Paradero paradero in linea.Paraderos){
                                if(ArboldeRuta.ExistElement(paradero)) continue;
                                ArboldeRuta.AddNodeToCicle(new Nodo(paradero, node));
                            }
                    }
                    ArboldeRuta.NextCycle();
                }
            }
            
        }  
        
        
        public Paradero PedirParadero(){ // Si no se encuentra el paradero, retorna null
            
            Paradero paradero = null; 
                Console.WriteLine("Ingrese en Nombre del paradero:");
                // Arreglar para solo mostrar los Paraderos.
                Console.WriteLine($"Paraderos Disponibles: [{Paraderos[0].Nombre}, {Paraderos[1].Nombre}, {Paraderos[2].Nombre}, {Paraderos[3].Nombre}, {Paraderos[4].Nombre}, {Paraderos[5].Nombre}, {Paraderos[6].Nombre}]");
                string input = Console.ReadLine();
                foreach(Paradero item in Paraderos){
                    if(item.Nombre == input){
                        paradero = item;
                        break;
                    }
                }
            return paradero; 
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